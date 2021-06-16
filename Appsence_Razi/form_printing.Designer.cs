namespace Appsence_Razi
{
    partial class form_printing
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_printing));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.appsence_RAZIDataSet = new Appsence_Razi.Appsence_RAZIDataSet();
            this.aBSANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBSANCETableAdapter = new Appsence_Razi.Appsence_RAZIDataSetTableAdapters.ABSANCETableAdapter();
            this.tableAdapterManager = new Appsence_Razi.Appsence_RAZIDataSetTableAdapters.TableAdapterManager();
            this.fONCTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fONCTIONTableAdapter = new Appsence_Razi.Appsence_RAZIDataSetTableAdapters.FONCTIONTableAdapter();
            this.pERSONNELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONNELTableAdapter = new Appsence_Razi.Appsence_RAZIDataSetTableAdapters.PERSONNELTableAdapter();
            this.tYPE_ABSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPE_ABSTableAdapter = new Appsence_Razi.Appsence_RAZIDataSetTableAdapters.TYPE_ABSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appsence_RAZIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBSANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fONCTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_ABSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1181, 666);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // appsence_RAZIDataSet
            // 
            this.appsence_RAZIDataSet.DataSetName = "Appsence_RAZIDataSet";
            this.appsence_RAZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBSANCEBindingSource
            // 
            this.aBSANCEBindingSource.DataMember = "ABSANCE";
            this.aBSANCEBindingSource.DataSource = this.appsence_RAZIDataSet;
            // 
            // aBSANCETableAdapter
            // 
            this.aBSANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABSANCETableAdapter = this.aBSANCETableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FONCTIONTableAdapter = this.fONCTIONTableAdapter;
            this.tableAdapterManager.PERSONNELTableAdapter = this.pERSONNELTableAdapter;
            this.tableAdapterManager.RECRUTEMENTTableAdapter = null;
            this.tableAdapterManager.SPESIALITETableAdapter = null;
            this.tableAdapterManager.TYPE_ABSTableAdapter = this.tYPE_ABSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Appsence_Razi.Appsence_RAZIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // fONCTIONBindingSource
            // 
            this.fONCTIONBindingSource.DataMember = "FONCTION";
            this.fONCTIONBindingSource.DataSource = this.appsence_RAZIDataSet;
            // 
            // fONCTIONTableAdapter
            // 
            this.fONCTIONTableAdapter.ClearBeforeFill = true;
            // 
            // pERSONNELBindingSource
            // 
            this.pERSONNELBindingSource.DataMember = "PERSONNEL";
            this.pERSONNELBindingSource.DataSource = this.appsence_RAZIDataSet;
            // 
            // pERSONNELTableAdapter
            // 
            this.pERSONNELTableAdapter.ClearBeforeFill = true;
            // 
            // tYPE_ABSBindingSource
            // 
            this.tYPE_ABSBindingSource.DataMember = "TYPE_ABS";
            this.tYPE_ABSBindingSource.DataSource = this.appsence_RAZIDataSet;
            // 
            // tYPE_ABSTableAdapter
            // 
            this.tYPE_ABSTableAdapter.ClearBeforeFill = true;
            // 
            // form_printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 666);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_printing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_printing";
            this.Load += new System.EventHandler(this.form_printing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appsence_RAZIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBSANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fONCTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_ABSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Appsence_RAZIDataSet appsence_RAZIDataSet;
        private System.Windows.Forms.BindingSource aBSANCEBindingSource;
        private Appsence_RAZIDataSetTableAdapters.ABSANCETableAdapter aBSANCETableAdapter;
        private Appsence_RAZIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Appsence_RAZIDataSetTableAdapters.FONCTIONTableAdapter fONCTIONTableAdapter;
        private System.Windows.Forms.BindingSource fONCTIONBindingSource;
        private Appsence_RAZIDataSetTableAdapters.PERSONNELTableAdapter pERSONNELTableAdapter;
        private System.Windows.Forms.BindingSource pERSONNELBindingSource;
        private Appsence_RAZIDataSetTableAdapters.TYPE_ABSTableAdapter tYPE_ABSTableAdapter;
        private System.Windows.Forms.BindingSource tYPE_ABSBindingSource;
    }
}