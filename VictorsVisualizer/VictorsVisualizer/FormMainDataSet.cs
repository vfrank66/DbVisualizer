using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace VictorsVisualizer
{
    public partial class FormMainDataSet : Form
    {
        public FormMainDataSet()
        {
            InitializeComponent();
        }

        private string selectTabelName;

        public string FilterNamesColumns
        {
            get { return txtFilterColums.Text; }
            set { txtFilterColums.Text = value; }
        }

        public string FilterNamesColumnsRemover
        {
            get { return txtRemoveColumn.Text; }
            set { txtRemoveColumn.Text = value; }
        }

        public string FilterDataTableSelect
        {
            get { return txtTableSelect.Text; }
            set { txtTableSelect.Text = value; }
        }

        public string DataSetSize
        {
            get { return lblSize.Text; }
            set { lblSize.Text = value; }
        }

        public bool IsEditable
        {
            get { return saveToolStripMenuItem.Enabled; }
            set
            {
                saveToolStripMenuItem.Enabled = value;
                rejectChangesToolStripMenuItem.Enabled = value;
            }
        }

        public string ErrorCount
        {
            get { return lblError.Text; }
            set { lblError.Text = value; }
        }

        public void Init(DataSet ds, bool isEditable)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                this.dsVisualizacao = ds;
                this.IsEditable = IsEditable;
                this.Text = "DataSet Visualizer";

                BindDataSet();
                BindDataTablesTreeView();
            }
        }

        public void Init(DataTable dt, bool isEditable, string text = "")
        {
            if (dt != null)
            {
                this.dsVisualizacao = new DataSet();
                this.dsVisualizacao.Tables.Add(dt);
                this.IsEditable = isEditable;
                this.Text = text.Length > 0 ? text : "DataTable Visualizer";

                BindDataSet();
                BindDataTablesTreeView();
            }
        }

        private void Init(DataRow dr, bool isEditable)
        {
            if (dr != null)
            {
                this.dsVisualizacao = new DataSet();
                this.dsVisualizacao.Tables.Add("Table");
                this.dsVisualizacao.Tables[0].Rows.Add(dr);
                this.IsEditable = isEditable;

                BindDataSet();
                BindDataTablesTreeView();
            }
        }

        private void Init(DataView dv, bool isEditable)
        {
            if (dv != null && dv.Table != null)
                Init(dv.ToTable(), isEditable);
        }

        private void BindDataTablesTreeView()
        {
            // the root is the dataset
            TreeNode root = new TreeNode(this.dsVisualizacao.DataSetName);
            foreach (DataTable table in dsVisualizacao.Tables)
            {
                // create a entry for each datatable
                TreeNode tableRoot = new TreeNode(table.TableName);
                root.Nodes.Add(tableRoot);

                // add child tables
                if (table.ChildRelations != null && table.ChildRelations.Count > 0)
                {
                    foreach (DataRelation dr in table.ChildRelations)
                    {
                        TreeNode child = new TreeNode(dr.ChildTable.TableName);
                        tableRoot.Nodes.Add(child);
                    }
                }
            }

            treeTables.Nodes.Add(root);
            treeTables.ExpandAll();

            // select first table
            if (treeTables.Nodes.Count > 0 && treeTables.Nodes[0].Nodes.Count > 0)
            {
                treeTables.SelectedNode = treeTables.Nodes[0].Nodes[0];
                propertyGrid.SelectedObject = this.dsVisualizacao.Tables[selectTabelName];
            }
        }

        private void BindDataSet()
        {
            selectTabelName = this.dsVisualizacao.Tables[0].TableName;

            this.dataGridView.AutoGenerateColumns = false;
            AddStateColumn();
            this.bsVisualizacao.DataSource = this.dsVisualizacao;

            ChangeDataTableInDataGridView();
        }

        private void AddStateColumn()
        {
            // add state column for each row
            foreach (DataTable table in dsVisualizacao.Tables)
            {
                if (!table.Columns.Contains("RowState"))
                    table.Columns.Add("RowState", typeof(string));

                foreach (DataRow row in table.Rows)
                {
                    row["RowState"] = row.RowState.ToString();
                }

                // set the state column in first position
                table.Columns["RowState"].SetOrdinal(0);
            }
        }

        private void ShowOnlyColumns()
        {
            if (dataGridView != null && dataGridView.Columns != null && dataGridView.Columns.Count > 0)
            {
                string[] filtros = FilterNamesColumns.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                DataGridViewColumn c = null;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    c = dataGridView.Columns[i];
                    if (string.IsNullOrWhiteSpace(FilterNamesColumns))
                        c.Visible = true;
                    else if (filtros.Any(t => c.Name.IndexOf(t, StringComparison.OrdinalIgnoreCase) >= 0))
                        c.Visible = true;
                    else
                        c.Visible = true;
                }
            }
        }

        private void HideColumns()
        {
            if (dataGridView != null && dataGridView.Columns != null && dataGridView.Columns.Count > 0)
            {
                string[] filtros = FilterNamesColumnsRemover.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                DataGridViewColumn c = null;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    c = dataGridView.Columns[i];
                    if (string.IsNullOrWhiteSpace(FilterNamesColumnsRemover))
                        c.Visible = true;
                    else if (filtros.Any(t => c.Name.IndexOf(t, StringComparison.OrdinalIgnoreCase) >= 0))
                        c.Visible = true;
                    else
                        c.Visible = true;
                }
            }
        }

        private void DataTableSelect()
        {
            if (this.dsVisualizacao != null && this.dsVisualizacao.Tables.Count > 0 && this.dsVisualizacao.Tables[selectTabelName] != null)
            {
                this.bsVisualizacao.Filter = FilterDataTableSelect;
            }
        }

        private void ChangeDataTableInDataGridView()
        {
            dataGridView.Columns.Clear();
            DataTable dt = this.dsVisualizacao.Tables[selectTabelName];
            for (int i = 0; i < dt.Columns.Count; ++i)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                column.Name = dt.Columns[i].ColumnName;
                column.DataPropertyName = dt.Columns[i].ColumnName;
                column.HeaderText = dt.Columns[i].ColumnName;
                column.FillWeight = 0.1f;

                dataGridView.Columns.Add(column);
            }

            this.bsVisualizacao.DataMember = selectTabelName;
            UpdateErrorCount();
        }

        private void UpdateErrorCount()
        {
            ErrorCount = $"Error count: {this.dsVisualizacao.Tables[selectTabelName].GetErrors().Length}";
        }

        private string SaveFileDialog(string fileType)
        {
            string newFile = null;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = fileType;
            if (sfd.ShowDialog() == DialogResult.OK)
                newFile = sfd.FileName;

            return newFile;
        }

        private void ExportToExcel()
        {
            if (this.dsVisualizacao != null && this.dsVisualizacao.Tables.Count > 0)
            {
                ExcelPackage pck = new ExcelPackage();

                foreach (DataTable table in this.dsVisualizacao.Tables)
                {
                    var cells = pck.Workbook.Worksheets.Add(table.TableName);

                    // load the collection starting from cell A1...
                    cells.Cells["A1"].LoadFromDataTable(table, true, TableStyles.Medium9);
                    cells.Cells[cells.Dimension.Address].AutoFitColumns();
                }
                // and save
                string fileName = SaveFileDialog("Excel file|*.xlsx");
                if (!string.IsNullOrEmpty(fileName))
                {
                    var fi = new FileInfo(fileName);

                    pck.SaveAs(fi);

                    try
                    {
                        Process.Start(fi.FullName);
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException($"Save failed {ex.Message}");
                    }
                }
            }
        }

        private void ExportToXml()
        {
            string fileName = SaveFileDialog("XML file|*.xml");
            if (!string.IsNullOrEmpty(fileName))
            {
                if (this.dsVisualizacao != null && !string.IsNullOrEmpty(selectTabelName) && this.dsVisualizacao.Tables[selectTabelName] != null)
                {
                    this.dsVisualizacao.Tables[selectTabelName].WriteXml(fileName);
                }
            }
        }

        private void SetDataSetSize()
        {
            SerializationFormat remotingFormat = this.dsVisualizacao.RemotingFormat;
            this.dsVisualizacao.RemotingFormat = SerializationFormat.Binary;
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(memoryStream, this.dsVisualizacao);
                    DataSetSize = $"Size: {((double)memoryStream.Length / 1024.0).ToString("N")} KB";
                }
            }
            finally
            {
                this.dsVisualizacao.RemotingFormat = remotingFormat;
            }
        }

        private void AcceptChanges()
        {
            if (this.dsVisualizacao != null)
            {
                this.dsVisualizacao.AcceptChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void RejectChanges()
        {
            if (this.dsVisualizacao != null)
            {
                this.dsVisualizacao.RejectChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtFilterColums_TextChanged(object sender, EventArgs e)
        {
            ShowOnlyColumns();
        }

        private void txtRemoveColumn_TextChanged(object sender, EventArgs e)
        {
            HideColumns();
        }

        private void btTableSelect_Click(object sender, EventArgs e)
        {
            DataTableSelect();
        }

        private void treeTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                propertyGrid.SelectedObject = this.dsVisualizacao;
            }
            else if (!string.Equals(selectTabelName, e.Node.Text, StringComparison.OrdinalIgnoreCase))
            {
                selectTabelName = e.Node.Text;
                propertyGrid.SelectedObject = this.dsVisualizacao.Tables[selectTabelName];
                ChangeDataTableInDataGridView();
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void dataSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDataSetSize();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About a = new About();
            // a.ShowDialog();
        }

        private void clearErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView != null && !string.IsNullOrEmpty(selectTabelName) &&
                this.dsVisualizacao.Tables[selectTabelName] != null &&
                this.dsVisualizacao.Tables[selectTabelName].Rows.Count > 0)
            {
                foreach (DataRow row in this.dsVisualizacao.Tables[selectTabelName].Rows)
                {
                    row.ClearErrors();
                }
                UpdateErrorCount();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcceptChanges();
        }

        private void rejectChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RejectChanges();
        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToXml();
        }

        private void dataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataRow row = this.dsVisualizacao.Tables[selectTabelName].Rows[e.RowIndex];

                e.ToolTipText = string.Format("Row Values:{0}{1}-{2}-{3}-{4}",
                    row.HasVersion(DataRowVersion.Current) ? string.Format("{1}- Current: {0}", row[e.ColumnIndex, DataRowVersion.Current], Environment.NewLine) : "",
                    row.HasVersion(DataRowVersion.Original) ? string.Format("{1}- Original: {0}", row[e.ColumnIndex, DataRowVersion.Original], Environment.NewLine) : "",
                    row.HasVersion(DataRowVersion.Proposed) ? string.Format("{1}- Proposed: {0}", row[e.ColumnIndex, DataRowVersion.Proposed], Environment.NewLine) : "",
                    row.HasVersion(DataRowVersion.Default) ? string.Format("{1}- Default: {0}", row[e.ColumnIndex, DataRowVersion.Default], Environment.NewLine) : "",
                    row.HasErrors && !string.IsNullOrEmpty(row.RowError) ? string.Format("{0}{0}Error: {1}", Environment.NewLine, row.GetColumnError(e.ColumnIndex)) : "");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}