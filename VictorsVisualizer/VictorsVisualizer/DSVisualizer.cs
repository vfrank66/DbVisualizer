using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Data;
using System.Windows.Forms;
using VictorsVisualizer;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DSVisualizer), typeof(VisualizerObjectSource), Target = typeof(DataSet), Description = "Victor DataSet Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DTVisualizer), typeof(VisualizerObjectSource), Target = typeof(DataTable), Description = "Victor DataTable Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DRVisualizer), typeof(DataRowVisualizerObjectSource), Target = typeof(DataRow), Description = "Victor DataRow Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DVVisualizer), typeof(VictorsVisualizer.DataRowVisualizerObjectSource), Target = typeof(DataView), Description = "Victor DataView Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DRVVisualizer), typeof(DataRowVisualizerObjectSource), Target = typeof(DataRowView), Description = "Victor DataRowView Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DRCollectionVisualizer), typeof(DataRowVisualizerObjectSource), Target = typeof(DataRowCollection), Description = "Victor DataRowCollection Visualizer")]

namespace VictorsVisualizer
{
    /// <summary>
    /// The DataRowCollection Visualizers
    /// </summary>
    public class DRCollectionVisualizer : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizeHost = new VisualizerDevelopmentHost(objectToVisualize,
                typeof(DRCollectionVisualizer),
                typeof(DataRowVisualizerObjectSource),
                true);
            visualizeHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");
            DataTable dt = objectProvider.GetObject() as DataTable;

            if (dt != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(dt, objectProvider.IsObjectReplaceable, "DataRowCollection Visualizer");

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                        objectProvider.TransferData(StreamSerializer.ObjectToStream(null, dt));
                }
            }
        }
    }

    /// <summary>
    /// The DataRow Visualizers
    /// </summary>
    public class DRVisualizer : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, 
                typeof(DRVisualizer), 
                typeof(DataRowVisualizerObjectSource), 
                true);
            visualizerHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            DataTable dt = objectProvider.GetObject() as DataTable;

            if (dt != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(dt, objectProvider.IsObjectReplaceable, "DataRow Visualizer");

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                    {
                        /// DataRow is not serializable, so we serialize the item array
                        /// in the TransferData override of the DataRowVisualizerObjectSource we deserialize the itemArray
                        /// and update the values on the original DataRow
                        objectProvider.TransferData(StreamSerializer.ObjectToStream(null, dt.Rows[0].ItemArray));
                    }
                }
            }
        }
    }

    /// <summarary>
    /// The DataRowView Visualizers
    /// </summary>
    public class DRVVisualizer : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizeHost = new VisualizerDevelopmentHost(objectToVisualize, 
                typeof(DRVVisualizer), 
                typeof(DataRowVisualizerObjectSource), 
                true);
            visualizeHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");
                        
            DataTable dt = objectProvider.GetObject() as DataTable;

            if (dt != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(dt, objectProvider.IsObjectReplaceable, "DataRowView Visualizer");

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                        objectProvider.TransferData(StreamSerializer.ObjectToStream(null, dt));
                }
            }
        }
    }

    /// <summary>
    /// The DataSet Visualizers
    /// </summary>
    public class DSVisualizer : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize,
                typeof(DSVisualizer), 
                typeof(VisualizerObjectSource), 
                true);
            visualizerHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            DataSet ds = objectProvider.GetObject() as DataSet;

            if (ds != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(ds, objectProvider.IsObjectReplaceable);

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                        objectProvider.ReplaceObject(ds);
                }
            }
        }
    }

    /// <summary>
    /// The DataTable Visualizers
    /// </summary>
    public class DTVisualizer : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, 
                typeof(DTVisualizer));
            visualizerHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            DataTable dt = objectProvider.GetObject() as DataTable;

            if (dt != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(dt, objectProvider.IsObjectReplaceable);

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                        objectProvider.ReplaceObject(dt);
                }
            }
        }
    }

    /// <summary>
    /// The DataView Visualizer
    /// </summary>
    public class DVVisualizer : DialogDebuggerVisualizer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectToVisualize"></param>
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, 
                typeof(DVVisualizer), 
                typeof(DataRowVisualizerObjectSource), 
                true);
            visualizerHost.ShowVisualizer();
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            DataTable dt = objectProvider.GetObject() as DataTable;

            if (dt != null)
            {
                using (FormMainDataSet main = new FormMainDataSet())
                {
                    main.Init(dt, objectProvider.IsObjectReplaceable, "DataView Visualizer");

                    DialogResult dr = windowService.ShowDialog(main);

                    if (objectProvider.IsObjectReplaceable && dr == DialogResult.OK)
                        objectProvider.ReplaceObject(dt);
                }
            }
        }
    }
}