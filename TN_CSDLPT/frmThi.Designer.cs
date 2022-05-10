
namespace TN_CSDLPT
{
    partial class frmThi
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
            System.Windows.Forms.Label lbMonHoc;
            System.Windows.Forms.Label lbNgayThi;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label lbTrinhDo;
            System.Windows.Forms.Label lbSoCauThi;
            System.Windows.Forms.Label lbThoiGian;
            this.panelTTSV = new DevExpress.XtraEditors.PanelControl();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.panelGVDK = new DevExpress.XtraEditors.PanelControl();
            this.spinLan = new DevExpress.XtraEditors.SpinEdit();
            this.dateNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.lbThoiGianGhi = new System.Windows.Forms.Label();
            this.lbSoCauThiGhi = new System.Windows.Forms.Label();
            this.lbTrinhDoGhi = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.DSet = new TN_CSDLPT.DSet();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new TN_CSDLPT.DSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSetTableAdapters.TableAdapterManager();
            this.panelThi = new DevExpress.XtraEditors.PanelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            lbMonHoc = new System.Windows.Forms.Label();
            lbNgayThi = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            lbTrinhDo = new System.Windows.Forms.Label();
            lbSoCauThi = new System.Windows.Forms.Label();
            lbThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelTTSV)).BeginInit();
            this.panelTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGVDK)).BeginInit();
            this.panelGVDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMonHoc
            // 
            lbMonHoc.AutoSize = true;
            lbMonHoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbMonHoc.Location = new System.Drawing.Point(60, 33);
            lbMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMonHoc.Name = "lbMonHoc";
            lbMonHoc.Size = new System.Drawing.Size(105, 24);
            lbMonHoc.TabIndex = 0;
            lbMonHoc.Text = "MÔN HỌC:";
            // 
            // lbNgayThi
            // 
            lbNgayThi.AutoSize = true;
            lbNgayThi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbNgayThi.Location = new System.Drawing.Point(499, 29);
            lbNgayThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbNgayThi.Name = "lbNgayThi";
            lbNgayThi.Size = new System.Drawing.Size(106, 24);
            lbNgayThi.TabIndex = 2;
            lbNgayThi.Text = "NGÀY THI:";
            lbNgayThi.Click += new System.EventHandler(this.lbNgayThi_Click);
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(864, 33);
            lANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(52, 24);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "LẦN:";
            lANLabel.Click += new System.EventHandler(this.lANLabel_Click);
            // 
            // lbTrinhDo
            // 
            lbTrinhDo.AutoSize = true;
            lbTrinhDo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbTrinhDo.Location = new System.Drawing.Point(60, 88);
            lbTrinhDo.Name = "lbTrinhDo";
            lbTrinhDo.Size = new System.Drawing.Size(109, 24);
            lbTrinhDo.TabIndex = 12;
            lbTrinhDo.Text = "TRÌNH ĐỘ:";
            // 
            // lbSoCauThi
            // 
            lbSoCauThi.AutoSize = true;
            lbSoCauThi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSoCauThi.Location = new System.Drawing.Point(499, 88);
            lbSoCauThi.Name = "lbSoCauThi";
            lbSoCauThi.Size = new System.Drawing.Size(124, 24);
            lbSoCauThi.TabIndex = 13;
            lbSoCauThi.Text = "SỐ CÂU THI:";
            // 
            // lbThoiGian
            // 
            lbThoiGian.AutoSize = true;
            lbThoiGian.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbThoiGian.Location = new System.Drawing.Point(864, 88);
            lbThoiGian.Name = "lbThoiGian";
            lbThoiGian.Size = new System.Drawing.Size(116, 24);
            lbThoiGian.TabIndex = 14;
            lbThoiGian.Text = "THỜI GIAN:";
            lbThoiGian.Click += new System.EventHandler(this.tHOIGIANLabel_Click);
            // 
            // panelTTSV
            // 
            this.panelTTSV.Controls.Add(this.btnBatDau);
            this.panelTTSV.Controls.Add(this.btnThoat);
            this.panelTTSV.Controls.Add(this.lb10);
            this.panelTTSV.Controls.Add(this.lb9);
            this.panelTTSV.Controls.Add(this.lb8);
            this.panelTTSV.Controls.Add(this.lb7);
            this.panelTTSV.Controls.Add(this.lb6);
            this.panelTTSV.Controls.Add(this.lb5);
            this.panelTTSV.Controls.Add(this.lb4);
            this.panelTTSV.Controls.Add(this.lb3);
            this.panelTTSV.Controls.Add(this.lb2);
            this.panelTTSV.Controls.Add(this.lb1);
            this.panelTTSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTTSV.Location = new System.Drawing.Point(0, 0);
            this.panelTTSV.Margin = new System.Windows.Forms.Padding(6);
            this.panelTTSV.Name = "panelTTSV";
            this.panelTTSV.Size = new System.Drawing.Size(1353, 183);
            this.panelTTSV.TabIndex = 0;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(777, 79);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(156, 53);
            this.btnBatDau.TabIndex = 11;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1029, 79);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 52);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(941, 25);
            this.lb10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(85, 34);
            this.lb10.TabIndex = 9;
            this.lb10.Text = "00:00";
            this.lb10.Click += new System.EventHandler(this.lb10_Click);
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(768, 25);
            this.lb9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(165, 34);
            this.lb9.TabIndex = 8;
            this.lb9.Text = "THỜI GIAN:";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.Location = new System.Drawing.Point(576, 96);
            this.lb8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(64, 24);
            this.lb8.TabIndex = 7;
            this.lb8.Text = "label8";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(461, 96);
            this.lb7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(95, 24);
            this.lb7.TabIndex = 6;
            this.lb7.Text = "TÊN LỚP:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(576, 33);
            this.lb6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(64, 24);
            this.lb6.TabIndex = 5;
            this.lb6.Text = "label6";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(470, 33);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(86, 24);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "MÃ LỚP:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(232, 96);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(64, 24);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "label4";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(60, 96);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(153, 24);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "TÊN SINH VIÊN:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(232, 33);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(64, 24);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "label2";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(60, 33);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(144, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "MÃ SINH VIÊN:";
            // 
            // panelGVDK
            // 
            this.panelGVDK.Controls.Add(this.spinLan);
            this.panelGVDK.Controls.Add(this.dateNgayThi);
            this.panelGVDK.Controls.Add(this.lbThoiGianGhi);
            this.panelGVDK.Controls.Add(this.lbSoCauThiGhi);
            this.panelGVDK.Controls.Add(this.lbTrinhDoGhi);
            this.panelGVDK.Controls.Add(lbThoiGian);
            this.panelGVDK.Controls.Add(lbSoCauThi);
            this.panelGVDK.Controls.Add(lbTrinhDo);
            this.panelGVDK.Controls.Add(this.btnTim);
            this.panelGVDK.Controls.Add(lANLabel);
            this.panelGVDK.Controls.Add(lbNgayThi);
            this.panelGVDK.Controls.Add(lbMonHoc);
            this.panelGVDK.Controls.Add(this.cmbTenMH);
            this.panelGVDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGVDK.Location = new System.Drawing.Point(0, 183);
            this.panelGVDK.Margin = new System.Windows.Forms.Padding(6);
            this.panelGVDK.Name = "panelGVDK";
            this.panelGVDK.Size = new System.Drawing.Size(1353, 135);
            this.panelGVDK.TabIndex = 1;
            this.panelGVDK.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGVDK_Paint);
            // 
            // spinLan
            // 
            this.spinLan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinLan.Location = new System.Drawing.Point(935, 24);
            this.spinLan.Name = "spinLan";
            this.spinLan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinLan.Properties.Appearance.Options.UseFont = true;
            this.spinLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinLan.Size = new System.Drawing.Size(64, 32);
            this.spinLan.TabIndex = 19;
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.EditValue = null;
            this.dateNgayThi.Location = new System.Drawing.Point(630, 24);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.Properties.Appearance.Options.UseFont = true;
            this.dateNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Size = new System.Drawing.Size(150, 32);
            this.dateNgayThi.TabIndex = 18;
            // 
            // lbThoiGianGhi
            // 
            this.lbThoiGianGhi.AutoSize = true;
            this.lbThoiGianGhi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianGhi.Location = new System.Drawing.Point(996, 88);
            this.lbThoiGianGhi.Name = "lbThoiGianGhi";
            this.lbThoiGianGhi.Size = new System.Drawing.Size(53, 24);
            this.lbThoiGianGhi.TabIndex = 17;
            this.lbThoiGianGhi.Text = "< 60";
            // 
            // lbSoCauThiGhi
            // 
            this.lbSoCauThiGhi.AutoSize = true;
            this.lbSoCauThiGhi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoCauThiGhi.Location = new System.Drawing.Point(635, 88);
            this.lbSoCauThiGhi.Name = "lbSoCauThiGhi";
            this.lbSoCauThiGhi.Size = new System.Drawing.Size(58, 24);
            this.lbSoCauThiGhi.TabIndex = 16;
            this.lbSoCauThiGhi.Text = "<100";
            // 
            // lbTrinhDoGhi
            // 
            this.lbTrinhDoGhi.AutoSize = true;
            this.lbTrinhDoGhi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrinhDoGhi.Location = new System.Drawing.Point(184, 88);
            this.lbTrinhDoGhi.Name = "lbTrinhDoGhi";
            this.lbTrinhDoGhi.Size = new System.Drawing.Size(60, 24);
            this.lbTrinhDoGhi.TabIndex = 15;
            this.lbTrinhDoGhi.Text = "A;B;C";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1101, 25);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 43);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsMonHoc;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(188, 25);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(262, 32);
            this.cmbTenMH.TabIndex = 1;
            this.cmbTenMH.ValueMember = "MAMH";
            this.cmbTenMH.SelectedIndexChanged += new System.EventHandler(this.cmbTenMH_SelectedIndexChanged);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DSet;
            // 
            // DSet
            // 
            this.DSet.DataSetName = "DSet";
            this.DSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.DSet;
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
            // panelThi
            // 
            this.panelThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThi.Location = new System.Drawing.Point(0, 318);
            this.panelThi.Margin = new System.Windows.Forms.Padding(6);
            this.panelThi.Name = "panelThi";
            this.panelThi.Size = new System.Drawing.Size(1353, 337);
            this.panelThi.TabIndex = 2;
            this.panelThi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThi_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 655);
            this.Controls.Add(this.panelThi);
            this.Controls.Add(this.panelGVDK);
            this.Controls.Add(this.panelTTSV);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTTSV)).EndInit();
            this.panelTTSV.ResumeLayout(false);
            this.panelTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGVDK)).EndInit();
            this.panelGVDK.ResumeLayout(false);
            this.panelGVDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTTSV;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.PanelControl panelGVDK;
        private DSet DSet;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraEditors.PanelControl panelThi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lbThoiGianGhi;
        private System.Windows.Forms.Label lbSoCauThiGhi;
        private System.Windows.Forms.Label lbTrinhDoGhi;
        private DevExpress.XtraEditors.SpinEdit spinLan;
        private DevExpress.XtraEditors.DateEdit dateNgayThi;
    }
}