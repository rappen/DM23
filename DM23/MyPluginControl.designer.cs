namespace DM23
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.xrmEntity = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.xrmView = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.xrmPrimaryName = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.xrmRecordHost1 = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.xrmData = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.toolStripMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(560, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(46, 22);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(187, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 4);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.xrmEntity);
            this.flowLayoutPanel1.Controls.Add(this.chkManaged);
            this.flowLayoutPanel1.Controls.Add(this.xrmView);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 41);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // xrmEntity
            // 
            this.xrmEntity.AddNullOption = true;
            this.xrmEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmEntity.FormattingEnabled = true;
            this.xrmEntity.Location = new System.Drawing.Point(1, 1);
            this.xrmEntity.Margin = new System.Windows.Forms.Padding(1);
            this.xrmEntity.Name = "xrmEntity";
            this.xrmEntity.Size = new System.Drawing.Size(223, 21);
            this.xrmEntity.TabIndex = 0;
            this.xrmEntity.SelectedIndexChanged += new System.EventHandler(this.xrmEntity_SelectedIndexChanged);
            // 
            // chkManaged
            // 
            this.chkManaged.AutoSize = true;
            this.chkManaged.Location = new System.Drawing.Point(226, 1);
            this.chkManaged.Margin = new System.Windows.Forms.Padding(1);
            this.chkManaged.Name = "chkManaged";
            this.chkManaged.Size = new System.Drawing.Size(71, 17);
            this.chkManaged.TabIndex = 1;
            this.chkManaged.Text = "Managed";
            this.chkManaged.UseVisualStyleBackColor = true;
            this.chkManaged.CheckedChanged += new System.EventHandler(this.chkManaged_CheckedChanged);
            // 
            // xrmView
            // 
            this.xrmView.AddNullRecord = true;
            this.xrmView.Column = null;
            this.xrmView.DisplayFormat = "";
            this.xrmView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmView.Filter = null;
            this.xrmView.FormattingEnabled = true;
            this.xrmView.Location = new System.Drawing.Point(299, 1);
            this.xrmView.Margin = new System.Windows.Forms.Padding(1);
            this.xrmView.Name = "xrmView";
            this.xrmView.RecordHost = null;
            this.xrmView.Service = null;
            this.xrmView.Size = new System.Drawing.Size(186, 21);
            this.xrmView.TabIndex = 2;
            this.xrmView.SelectedIndexChanged += new System.EventHandler(this.xrmView_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.xrmPrimaryName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xrmData);
            this.splitContainer1.Size = new System.Drawing.Size(560, 234);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 69);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xrmPrimaryName
            // 
            this.xrmPrimaryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmPrimaryName.Column = null;
            this.xrmPrimaryName.DisplayFormat = "";
            this.xrmPrimaryName.Location = new System.Drawing.Point(10, 34);
            this.xrmPrimaryName.Margin = new System.Windows.Forms.Padding(1);
            this.xrmPrimaryName.Name = "xrmPrimaryName";
            this.xrmPrimaryName.RecordHost = this.xrmRecordHost1;
            this.xrmPrimaryName.Size = new System.Drawing.Size(166, 20);
            this.xrmPrimaryName.TabIndex = 0;
            // 
            // xrmRecordHost1
            // 
            this.xrmRecordHost1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordHost1.LogicalName = null;
            this.xrmRecordHost1.Record = null;
            this.xrmRecordHost1.Service = null;
            // 
            // xrmData
            // 
            this.xrmData.AllowUserToAddRows = false;
            this.xrmData.AllowUserToDeleteRows = false;
            this.xrmData.AllowUserToOrderColumns = true;
            this.xrmData.AllowUserToResizeRows = false;
            this.xrmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmData.ColumnOrder = "";
            this.xrmData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmData.FilterColumns = "";
            this.xrmData.LayoutXML = null;
            this.xrmData.Location = new System.Drawing.Point(0, 0);
            this.xrmData.Margin = new System.Windows.Forms.Padding(1);
            this.xrmData.Name = "xrmData";
            this.xrmData.ReadOnly = true;
            this.xrmData.RowHeadersWidth = 102;
            this.xrmData.RowTemplate.Height = 40;
            this.xrmData.Service = null;
            this.xrmData.ShowFriendlyNames = true;
            this.xrmData.ShowIdColumn = false;
            this.xrmData.ShowIndexColumn = false;
            this.xrmData.ShowLocalTimes = true;
            this.xrmData.Size = new System.Drawing.Size(372, 234);
            this.xrmData.TabIndex = 0;
            this.xrmData.RecordClick += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.xrmData_RecordClick);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(560, 300);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MyPluginControl_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmEntity;
        private System.Windows.Forms.CheckBox chkManaged;
        private Rappen.XTB.Helpers.Controls.XRMColumnLookup xrmView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmData;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmPrimaryName;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost xrmRecordHost1;
        private System.Windows.Forms.Button btnSave;
    }
}
