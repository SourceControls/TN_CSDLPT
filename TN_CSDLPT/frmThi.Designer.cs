﻿
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label label1;
            this.panelTTSV = new DevExpress.XtraEditors.PanelControl();
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.DSet = new TN_CSDLPT.DSet();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dateNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.lb18 = new System.Windows.Forms.Label();
            this.lb17 = new System.Windows.Forms.Label();
            this.lb16 = new System.Windows.Forms.Label();
            this.lb15 = new System.Windows.Forms.Label();
            this.lb14 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new TN_CSDLPT.DSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSetTableAdapters.TableAdapterManager();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowCH = new System.Windows.Forms.FlowLayoutPanel();
            this.tenlopmalopTableAdapter1 = new TN_CSDLPT.DSetTableAdapters.TENLOPMALOPTableAdapter();
            this.lOPTableAdapter = new TN_CSDLPT.DSetTableAdapters.LOPTableAdapter();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            tENMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelTTSV)).BeginInit();
            this.panelTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGVDK)).BeginInit();
            this.panelGVDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(26, 23);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(88, 19);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "MÔN HỌC:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 19);
            label1.TabIndex = 15;
            label1.Text = "LỚP:";
            // 
            // panelTTSV
            // 
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
            this.panelTTSV.Name = "panelTTSV";
            this.panelTTSV.Size = new System.Drawing.Size(1514, 99);
            this.panelTTSV.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1323, 28);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 45);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(1134, 35);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(68, 27);
            this.lb10.TabIndex = 9;
            this.lb10.Text = "00:00";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(998, 35);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(131, 27);
            this.lb9.TabIndex = 8;
            this.lb9.Text = "THỜI GIAN:";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(642, 54);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(51, 19);
            this.lb8.TabIndex = 7;
            this.lb8.Text = "label8";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(471, 54);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(79, 19);
            this.lb7.TabIndex = 6;
            this.lb7.Text = "TÊN LỚP:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(642, 13);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(51, 19);
            this.lb6.TabIndex = 5;
            this.lb6.Text = "label6";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(471, 13);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(72, 19);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "MÃ LỚP:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(244, 54);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(51, 19);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "label4";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(96, 54);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(128, 19);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "TÊN SINH VIÊN:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(244, 13);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(51, 19);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "label2";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(96, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(121, 19);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "MÃ SINH VIÊN:";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // panelGVDK
            // 
            this.panelGVDK.Controls.Add(this.cmbLan);
            this.panelGVDK.Controls.Add(this.cbLop);
            this.panelGVDK.Controls.Add(label1);
            this.panelGVDK.Controls.Add(this.btnBatDau);
            this.panelGVDK.Controls.Add(this.btnTim);
            this.panelGVDK.Controls.Add(this.dateNgayThi);
            this.panelGVDK.Controls.Add(this.lb18);
            this.panelGVDK.Controls.Add(this.lb17);
            this.panelGVDK.Controls.Add(this.lb16);
            this.panelGVDK.Controls.Add(this.lb15);
            this.panelGVDK.Controls.Add(this.lb14);
            this.panelGVDK.Controls.Add(this.lb13);
            this.panelGVDK.Controls.Add(this.lb12);
            this.panelGVDK.Controls.Add(this.lb11);
            this.panelGVDK.Controls.Add(tENMHLabel);
            this.panelGVDK.Controls.Add(this.cmbTenMH);
            this.panelGVDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGVDK.Location = new System.Drawing.Point(0, 99);
            this.panelGVDK.Name = "panelGVDK";
            this.panelGVDK.Size = new System.Drawing.Size(1514, 142);
            this.panelGVDK.TabIndex = 1;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.bdsLop;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(120, 66);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(264, 27);
            this.cbLop.TabIndex = 15;
            this.cbLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DSet;
            // 
            // DSet
            // 
            this.DSet.DataSetName = "DSet";
            this.DSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(1308, 35);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(150, 60);
            this.btnBatDau.TabIndex = 13;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1086, 15);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 39);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.EditValue = null;
            this.dateNgayThi.Location = new System.Drawing.Point(564, 15);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Size = new System.Drawing.Size(150, 28);
            this.dateNgayThi.TabIndex = 10;
            // 
            // lb18
            // 
            this.lb18.AutoSize = true;
            this.lb18.Location = new System.Drawing.Point(952, 77);
            this.lb18.Name = "lb18";
            this.lb18.Size = new System.Drawing.Size(39, 19);
            this.lb18.TabIndex = 9;
            this.lb18.Text = "<60";
            // 
            // lb17
            // 
            this.lb17.AutoSize = true;
            this.lb17.Location = new System.Drawing.Point(831, 77);
            this.lb17.Name = "lb17";
            this.lb17.Size = new System.Drawing.Size(98, 19);
            this.lb17.TabIndex = 8;
            this.lb17.Text = "THỜI GIAN:";
            // 
            // lb16
            // 
            this.lb16.AutoSize = true;
            this.lb16.Location = new System.Drawing.Point(590, 77);
            this.lb16.Name = "lb16";
            this.lb16.Size = new System.Drawing.Size(48, 19);
            this.lb16.TabIndex = 7;
            this.lb16.Text = "<100";
            // 
            // lb15
            // 
            this.lb15.AutoSize = true;
            this.lb15.Location = new System.Drawing.Point(476, 77);
            this.lb15.Name = "lb15";
            this.lb15.Size = new System.Drawing.Size(105, 19);
            this.lb15.TabIndex = 6;
            this.lb15.Text = "SỐ CÂU THI:";
            // 
            // lb14
            // 
            this.lb14.AutoSize = true;
            this.lb14.Location = new System.Drawing.Point(758, 77);
            this.lb14.Name = "lb14";
            this.lb14.Size = new System.Drawing.Size(51, 19);
            this.lb14.TabIndex = 5;
            this.lb14.Text = "A;B;C";
            // 
            // lb13
            // 
            this.lb13.AutoSize = true;
            this.lb13.Location = new System.Drawing.Point(660, 77);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(91, 19);
            this.lb13.TabIndex = 4;
            this.lb13.Text = "TRÌNH ĐỘ:";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(795, 23);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(45, 19);
            this.lb12.TabIndex = 3;
            this.lb12.Text = "LẦN:";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Location = new System.Drawing.Point(468, 23);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(90, 19);
            this.lb11.TabIndex = 2;
            this.lb11.Text = "NGÀY THI:";
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsMonHoc;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(120, 15);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(264, 27);
            this.cmbTenMH.TabIndex = 1;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DSet;
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
            this.tableAdapterManager.SP_SELECT_BO_DETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowCH
            // 
            this.flowCH.AllowDrop = true;
            this.flowCH.AutoScroll = true;
            this.flowCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCH.Location = new System.Drawing.Point(0, 241);
            this.flowCH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowCH.Name = "flowCH";
            this.flowCH.Size = new System.Drawing.Size(1514, 396);
            this.flowCH.TabIndex = 2;
            // 
            // tenlopmalopTableAdapter1
            // 
            this.tenlopmalopTableAdapter1.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLan.Location = new System.Drawing.Point(846, 15);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(121, 27);
            this.cmbLan.TabIndex = 16;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 637);
            this.Controls.Add(this.flowCH);
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTTSV;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.PanelControl panelGVDK;
        private DSet DSet;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private DevExpress.XtraEditors.DateEdit dateNgayThi;
        private System.Windows.Forms.Label lb18;
        private System.Windows.Forms.Label lb17;
        private System.Windows.Forms.Label lb16;
        private System.Windows.Forms.Label lb15;
        private System.Windows.Forms.Label lb14;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb11;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowCH;
        private DSetTableAdapters.TENLOPMALOPTableAdapter tenlopmalopTableAdapter1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cmbLan;
    }
}