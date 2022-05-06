
namespace TN_CSDLPT.Resources
{
    partial class frmNhapDe1
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuBoDe = new System.Windows.Forms.Button();
            this.btnLayBoDe = new System.Windows.Forms.Button();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dSet = new TN_CSDLPT.DSet();
            this.MONHOCTableAdapter = new TN_CSDLPT.DSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSetTableAdapters.TableAdapterManager();
            this.bdsLayBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LAY_BO_DETableAdapter = new TN_CSDLPT.DSetTableAdapters.SP_LAY_BO_DETableAdapter();
            this.sP_LAY_BO_DEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_BO_DEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(28, 65);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(89, 17);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "Tên Môn Học";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 17);
            label1.TabIndex = 3;
            label1.Text = "Trình Độ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuuBoDe);
            this.panel1.Controls.Add(this.btnLayBoDe);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.cbTrinhDo);
            this.panel1.Controls.Add(tENMHLabel);
            this.panel1.Controls.Add(this.cbMonHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 173);
            this.panel1.TabIndex = 0;
            // 
            // btnLuuBoDe
            // 
            this.btnLuuBoDe.Location = new System.Drawing.Point(706, 65);
            this.btnLuuBoDe.Name = "btnLuuBoDe";
            this.btnLuuBoDe.Size = new System.Drawing.Size(136, 33);
            this.btnLuuBoDe.TabIndex = 5;
            this.btnLuuBoDe.Text = "Lưu Bộ Đề";
            this.btnLuuBoDe.UseVisualStyleBackColor = true;
            // 
            // btnLayBoDe
            // 
            this.btnLayBoDe.Location = new System.Drawing.Point(521, 62);
            this.btnLayBoDe.Name = "btnLayBoDe";
            this.btnLayBoDe.Size = new System.Drawing.Size(136, 33);
            this.btnLayBoDe.TabIndex = 4;
            this.btnLayBoDe.Text = "Lấy Bộ Đề";
            this.btnLayBoDe.UseVisualStyleBackColor = true;
            this.btnLayBoDe.Click += new System.EventHandler(this.btnLayBoDe_Click);
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Location = new System.Drawing.Point(131, 105);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(324, 24);
            this.cbTrinhDo.TabIndex = 2;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(131, 62);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(324, 24);
            this.cbMonHoc.TabIndex = 1;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dSet;
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsLayBoDe
            // 
            this.bdsLayBoDe.DataMember = "SP_LAY_BO_DE";
            this.bdsLayBoDe.DataSource = this.dSet;
            // 
            // SP_LAY_BO_DETableAdapter
            // 
            this.SP_LAY_BO_DETableAdapter.ClearBeforeFill = true;
            // 
            // sP_LAY_BO_DEGridControl
            // 
            this.sP_LAY_BO_DEGridControl.DataSource = this.bdsLayBoDe;
            this.sP_LAY_BO_DEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAY_BO_DEGridControl.Location = new System.Drawing.Point(0, 173);
            this.sP_LAY_BO_DEGridControl.MainView = this.gridView1;
            this.sP_LAY_BO_DEGridControl.Name = "sP_LAY_BO_DEGridControl";
            this.sP_LAY_BO_DEGridControl.Size = new System.Drawing.Size(984, 435);
            this.sP_LAY_BO_DEGridControl.TabIndex = 2;
            this.sP_LAY_BO_DEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colIDCAUHOI,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN});
            this.gridView1.GridControl = this.sP_LAY_BO_DEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 94;
            // 
            // colIDCAUHOI
            // 
            this.colIDCAUHOI.Caption = "ID câu hỏi";
            this.colIDCAUHOI.FieldName = "IDCAUHOI";
            this.colIDCAUHOI.MinWidth = 25;
            this.colIDCAUHOI.Name = "colIDCAUHOI";
            this.colIDCAUHOI.Visible = true;
            this.colIDCAUHOI.VisibleIndex = 1;
            this.colIDCAUHOI.Width = 94;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội Dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 94;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 94;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            this.colB.Width = 94;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 94;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            this.colD.Width = 94;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp Án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            this.colDAP_AN.Width = 94;
            // 
            // frmNhapDe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 656);
            this.Controls.Add(this.sP_LAY_BO_DEGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapDe1";
            this.Text = "frmNhapDe1";
            this.Load += new System.EventHandler(this.frmNhapDe1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_BO_DEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSet dSet;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btnLuuBoDe;
        private System.Windows.Forms.Button btnLayBoDe;
        private System.Windows.Forms.BindingSource bdsLayBoDe;
        private DSetTableAdapters.SP_LAY_BO_DETableAdapter SP_LAY_BO_DETableAdapter;
        private DevExpress.XtraGrid.GridControl sP_LAY_BO_DEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
    }
}