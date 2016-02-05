namespace VictorsVisualizer
{
    partial class FormMainDataSet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsVisualizacao = new System.Windows.Forms.BindingSource(this.components);
            this.dsVisualizacao = new System.Data.DataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTables = new System.Windows.Forms.TabPage();
            this.treeTables = new System.Windows.Forms.TreeView();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.btTableSelect = new System.Windows.Forms.Button();
            this.txtTableSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemoveColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterColums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageProperties = new System.Windows.Forms.TabPage();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolTipInfoFilter = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisualizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVisualizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTables.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.tabPageProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsVisualizacao
            // 
            this.bsVisualizacao.DataSource = this.dsVisualizacao;
            this.bsVisualizacao.Position = 0;
            // 
            // dsVisualizacao
            // 
            this.dsVisualizacao.DataSetName = "NewDataSet";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(957, 333);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageTables);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Controls.Add(this.tabPageProperties);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(188, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTables
            // 
            this.tabPageTables.Controls.Add(this.treeTables);
            this.tabPageTables.Location = new System.Drawing.Point(4, 4);
            this.tabPageTables.Name = "tabPageTables";
            this.tabPageTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTables.Size = new System.Drawing.Size(180, 307);
            this.tabPageTables.TabIndex = 0;
            this.tabPageTables.Text = "Tables";
            this.tabPageTables.UseVisualStyleBackColor = true;
            // 
            // treeTables
            // 
            this.treeTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTables.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTables.FullRowSelect = true;
            this.treeTables.Location = new System.Drawing.Point(3, 3);
            this.treeTables.Name = "treeTables";
            this.treeTables.ShowLines = false;
            this.treeTables.Size = new System.Drawing.Size(174, 301);
            this.treeTables.TabIndex = 0;
            this.treeTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTables_AfterSelect);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.btTableSelect);
            this.tabPageOptions.Controls.Add(this.txtTableSelect);
            this.tabPageOptions.Controls.Add(this.label3);
            this.tabPageOptions.Controls.Add(this.txtRemoveColumn);
            this.tabPageOptions.Controls.Add(this.label2);
            this.tabPageOptions.Controls.Add(this.txtFilterColums);
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 4);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(180, 307);
            this.tabPageOptions.TabIndex = 1;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // btTableSelect
            // 
            this.btTableSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTableSelect.Location = new System.Drawing.Point(123, 278);
            this.btTableSelect.Name = "btTableSelect";
            this.btTableSelect.Size = new System.Drawing.Size(54, 23);
            this.btTableSelect.TabIndex = 10;
            this.btTableSelect.Text = "Select";
            this.btTableSelect.UseVisualStyleBackColor = true;
            this.btTableSelect.Click += new System.EventHandler(this.btTableSelect_Click);
            // 
            // txtTableSelect
            // 
            this.txtTableSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableSelect.Location = new System.Drawing.Point(9, 102);
            this.txtTableSelect.Multiline = true;
            this.txtTableSelect.Name = "txtTableSelect";
            this.txtTableSelect.Size = new System.Drawing.Size(165, 170);
            this.txtTableSelect.TabIndex = 9;
            this.toolTipInfoFilter.SetToolTip(this.txtTableSelect, "Binding source filter");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table Select:";
            // 
            // txtRemoveColumn
            // 
            this.txtRemoveColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemoveColumn.Location = new System.Drawing.Point(7, 63);
            this.txtRemoveColumn.Name = "txtRemoveColumn";
            this.txtRemoveColumn.Size = new System.Drawing.Size(167, 22);
            this.txtRemoveColumn.TabIndex = 4;
            this.toolTipInfoFilter.SetToolTip(this.txtRemoveColumn, "Use ; to filter several columns");
            this.txtRemoveColumn.TextChanged += new System.EventHandler(this.txtRemoveColumn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Column remover:";
            // 
            // txtFilterColums
            // 
            this.txtFilterColums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterColums.Location = new System.Drawing.Point(10, 23);
            this.txtFilterColums.Name = "txtFilterColums";
            this.txtFilterColums.Size = new System.Drawing.Size(164, 22);
            this.txtFilterColums.TabIndex = 1;
            this.toolTipInfoFilter.SetToolTip(this.txtFilterColums, "Use ; to filter several columns");
            this.txtFilterColums.TextChanged += new System.EventHandler(this.txtFilterColums_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column filter:";
            // 
            // tabPageProperties
            // 
            this.tabPageProperties.Controls.Add(this.propertyGrid);
            this.tabPageProperties.Location = new System.Drawing.Point(4, 4);
            this.tabPageProperties.Name = "tabPageProperties";
            this.tabPageProperties.Size = new System.Drawing.Size(180, 307);
            this.tabPageProperties.TabIndex = 2;
            this.tabPageProperties.Text = "Properties";
            this.tabPageProperties.UseVisualStyleBackColor = true;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(180, 307);
            this.propertyGrid.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.DataSource = this.bsVisualizacao;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(765, 333);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView_CellToolTipTextNeeded);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // toolTipInfoFilter
            // 
            this.toolTipInfoFilter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfoFilter.ToolTipTitle = "Info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.rejectChangesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportExcelToolStripMenuItem,
            this.exportXMLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.saveToolStripMenuItem.Text = "Accept changes and exit";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // rejectChangesToolStripMenuItem
            // 
            this.rejectChangesToolStripMenuItem.Name = "rejectChangesToolStripMenuItem";
            this.rejectChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.X)));
            this.rejectChangesToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.rejectChangesToolStripMenuItem.Text = "Reject changes and exit";
            this.rejectChangesToolStripMenuItem.Click += new System.EventHandler(this.rejectChangesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // exportExcelToolStripMenuItem
            // 
            this.exportExcelToolStripMenuItem.Name = "exportExcelToolStripMenuItem";
            this.exportExcelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.exportExcelToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exportExcelToolStripMenuItem.Text = "Export excel";
            this.exportExcelToolStripMenuItem.Click += new System.EventHandler(this.exportExcelToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSizeToolStripMenuItem,
            this.clearErrorsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // dataSizeToolStripMenuItem
            // 
            this.dataSizeToolStripMenuItem.Name = "dataSizeToolStripMenuItem";
            this.dataSizeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.dataSizeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dataSizeToolStripMenuItem.Text = "Data size";
            this.dataSizeToolStripMenuItem.Click += new System.EventHandler(this.dataSizeToolStripMenuItem_Click);
            // 
            // clearErrorsToolStripMenuItem
            // 
            this.clearErrorsToolStripMenuItem.Name = "clearErrorsToolStripMenuItem";
            this.clearErrorsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.clearErrorsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearErrorsToolStripMenuItem.Text = "Clear errors";
            this.clearErrorsToolStripMenuItem.Click += new System.EventHandler(this.clearErrorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSize,
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSize
            // 
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 17);
            this.lblSize.Text = "Size:";
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 17);
            this.lblError.Text = "Error:";
            // 
            // FormMainDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 385);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMainDataSet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bsVisualizacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVisualizacao)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTables.ResumeLayout(false);
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.tabPageProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dsVisualizacao;
        private System.Windows.Forms.BindingSource bsVisualizacao;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTables;
        private System.Windows.Forms.TreeView treeTables;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TextBox txtFilterColums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtRemoveColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipInfoFilter;
        private System.Windows.Forms.Button btTableSelect;
        private System.Windows.Forms.TextBox txtTableSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearErrorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblSize;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
