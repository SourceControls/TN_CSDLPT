
namespace TN_CSDLPT
{
    partial class frmNhapDe
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
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoLuongCau = new DevExpress.XtraEditors.SpinEdit();
            this.btnHuyNhap = new System.Windows.Forms.Button();
            this.btnLuuBoDe = new System.Windows.Forms.Button();
            this.btnBatDauNhap = new System.Windows.Forms.Button();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dSet = new TN_CSDLPT.DSet();
            this.MONHOCTableAdapter = new TN_CSDLPT.DSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSetTableAdapters.TableAdapterManager();
            this.bdsNhapBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.nHAP_BO_DEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAP_BO_DEGridControl)).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(488, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 17);
            label2.TabIndex = 7;
            label2.Text = "Số Lượng Câu";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoLuongCau);
            this.panel1.Controls.Add(this.btnHuyNhap);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.btnLuuBoDe);
            this.panel1.Controls.Add(this.btnBatDauNhap);
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
            // txtSoLuongCau
            // 
            this.txtSoLuongCau.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSoLuongCau.Location = new System.Drawing.Point(491, 112);
            this.txtSoLuongCau.Name = "txtSoLuongCau";
            this.txtSoLuongCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongCau.Properties.IsFloatValue = false;
            this.txtSoLuongCau.Properties.Mask.EditMask = "N00";
            this.txtSoLuongCau.Properties.MaxLength = 3;
            this.txtSoLuongCau.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtSoLuongCau.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSoLuongCau.Size = new System.Drawing.Size(93, 24);
            this.txtSoLuongCau.TabIndex = 9;
            // 
            // btnHuyNhap
            // 
            this.btnHuyNhap.Location = new System.Drawing.Point(707, 108);
            this.btnHuyNhap.Name = "btnHuyNhap";
            this.btnHuyNhap.Size = new System.Drawing.Size(136, 33);
            this.btnHuyNhap.TabIndex = 8;
            this.btnHuyNhap.Text = "Hủy Nhập";
            this.btnHuyNhap.UseVisualStyleBackColor = true;
            this.btnHuyNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuuBoDe
            // 
            this.btnLuuBoDe.Location = new System.Drawing.Point(707, 65);
            this.btnLuuBoDe.Name = "btnLuuBoDe";
            this.btnLuuBoDe.Size = new System.Drawing.Size(136, 33);
            this.btnLuuBoDe.TabIndex = 5;
            this.btnLuuBoDe.Text = "Lưu Bộ Đề";
            this.btnLuuBoDe.UseVisualStyleBackColor = true;
            this.btnLuuBoDe.Click += new System.EventHandler(this.btnLuuBoDe_Click);
            // 
            // btnBatDauNhap
            // 
            this.btnBatDauNhap.Location = new System.Drawing.Point(707, 21);
            this.btnBatDauNhap.Name = "btnBatDauNhap";
            this.btnBatDauNhap.Size = new System.Drawing.Size(136, 33);
            this.btnBatDauNhap.TabIndex = 4;
            this.btnBatDauNhap.Text = "Bắt Đầu Nhập";
            this.btnBatDauNhap.UseVisualStyleBackColor = true;
            this.btnBatDauNhap.Click += new System.EventHandler(this.btnbatDauNhap_Click);
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
            // bdsNhapBoDe
            // 
            this.bdsNhapBoDe.DataMember = "NHAP_BO_DE";
            this.bdsNhapBoDe.DataSource = this.dSet;
            // 
            // nHAP_BO_DEGridControl
            // 
            this.nHAP_BO_DEGridControl.DataSource = this.bdsNhapBoDe;
            this.nHAP_BO_DEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHAP_BO_DEGridControl.Location = new System.Drawing.Point(0, 173);
            this.nHAP_BO_DEGridControl.MainView = this.gridView1;
            this.nHAP_BO_DEGridControl.Name = "nHAP_BO_DEGridControl";
            this.nHAP_BO_DEGridControl.Size = new System.Drawing.Size(984, 483);
            this.nHAP_BO_DEGridControl.TabIndex = 1;
            this.nHAP_BO_DEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN});
            this.gridView1.GridControl = this.nHAP_BO_DEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowEdit = false;
            this.colSTT.OptionsColumn.AllowSize = false;
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 53;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 1;
            this.colNOIDUNG.Width = 147;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 2;
            this.colA.Width = 147;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 3;
            this.colB.Width = 147;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 4;
            this.colC.Width = 147;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 5;
            this.colD.Width = 147;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 6;
            this.colDAP_AN.Width = 166;
            // 
            // frmNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 656);
            this.Controls.Add(this.nHAP_BO_DEGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapDe";
            this.Text = "frmNhapDe";
            this.Load += new System.EventHandler(this.frmNhapDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAP_BO_DEGridControl)).EndInit();
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
        private System.Windows.Forms.Button btnBatDauNhap;
        private System.Windows.Forms.BindingSource bdsNhapBoDe;
        private DevExpress.XtraGrid.GridControl nHAP_BO_DEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private System.Windows.Forms.Button btnHuyNhap;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongCau;
    }
}