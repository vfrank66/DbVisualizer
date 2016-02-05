using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Data;
using System.IO;

namespace VictorsVisualizer
{
    /// <summary>
    /// Non-serializable assistance for DataRow, DataView, DataRowView, DataRowCollection
    /// </summary>
    public class DataRowVisualizerObjectSource : VisualizerObjectSource
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="incomingData"></param>
        /// <param name="outgoingData"></param>
        public override void TransferData(object target, Stream incomingData, Stream outgoingData)
        {
            if (target is DataRow)
            {
                DataRow row = target as DataRow;
                var itemArray = StreamSerializer.StreamToObject(incomingData) as object[];

                // the first column was added on the visualizer form, is the status column
                for (int i = 1; i < itemArray.Length; i++)
                {
                    if (!(target as DataRow).Table.Columns[i - 1].ReadOnly && !CompareData.Compare(row, itemArray, i - 1, i))
                    {
                        row[i - 1] = itemArray[i];
                    }
                }
            }
            else if (target is DataView)
            {
                DataView view = target as DataView;
                DataTable table = StreamSerializer.StreamToObject(incomingData) as DataTable;

                for (int r = 0; r < view.Table.Rows.Count; r++)
                {
                    for (int i = 1; i <= view.Table.Columns.Count; i++)
                    {
                        if (!view.Table.Columns[i - 1].ReadOnly && !CompareData.Compare(view[r].Row, table.Rows[r], i - 1, i))
                            view[r].Row[i - 1] = table.Rows[r][i];
                    }
                }
            }
            else if (target is DataRowView)
            {
                DataRowView view = target as DataRowView;
                DataTable table = StreamSerializer.StreamToObject(incomingData) as DataTable;

                for (int i = 1; i <= view.DataView.Table.Columns.Count; i++)
                {
                    if (!view.DataView.Table.Columns[i - 1].ReadOnly && !CompareData.Compare(view.Row, table.Rows[0], i - 1, i))
                        view[i + 1] = table.Rows[0][i];
                }
            }
        }

        /// <summary>
        /// Convert non-serializable DataRow, DataView, DataRowView, DataRowCollection to a DataTable
        /// and send it to <see cref="StreamSerializer.ObjectToStream(Stream, object)"/> to create a 
        /// serializable Stream.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="outgoingData"></param>
        public override void GetData(object target, Stream outgoingData)
        {
            if (target != null)
            {
                ///////////// DataRow ///////////////////////
                if (target is DataRow)
                {
                    DataRow row = target as DataRow;
                    DataTable table;

                    if (row.Table == null)
                    {
                        table = new DataTable("DataRowDebuggerTableObjectSource");

                        for (int i = 0; i < row.ItemArray.Length; i++)
                        {
                            table.Columns.Add(string.Format("Col{o}", i.ToString()), typeof(string));
                        }
                    }
                    else
                    {
                        table = row.Table.Clone();
                    }
                }
                ///////////// DataView ///////////////////////
                else if (target is DataView)
                {
                    DataView view = target as DataView;
                    DataTable table;

                    table = view.Table.Clone();

                    foreach (DataRow row in view.Table.Rows)
                    {
                        table.LoadDataRow(row.ItemArray, true);
                    }
                    StreamSerializer.ObjectToStream(outgoingData, table);
                }
                ///////////// DataRowView ///////////////////////
                else if (target is DataRowView)
                {
                    DataRowView view = target as DataRowView;
                    DataTable table = table = view.Row.Table.Clone();

                    table.LoadDataRow(view.Row.ItemArray, true);

                    StreamSerializer.ObjectToStream(outgoingData, table);
                }
                ///////////// DataRowCollection ///////////////////////
                else if (target is DataRowCollection)
                {
                    DataRowCollection rows = target as DataRowCollection;
                    DataTable table = null;

                    if (rows != null && rows.Count > 0)
                    {
                        if (rows[0].Table == null)
                        {
                            table = new DataTable("DataRowDebuggerTableObjectSource");

                            for (int i = 0; i < rows[0].ItemArray.Length; i++)
                            {
                                table.Columns.Add(string.Format("Col{o}", i.ToString()), typeof(string));
                            }
                        }
                        else
                        {
                            table = rows[0].Table.Clone();
                        }
                        foreach (DataRow row in rows)
                        {
                            table.LoadDataRow(row.ItemArray, true);
                        }
                    }
                    StreamSerializer.ObjectToStream(outgoingData, table);
                } // else if
            } // if (target == null)
        } // getdata
    } // class
} // namespace