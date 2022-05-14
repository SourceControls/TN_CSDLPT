﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        private List<CauHoi> list = new List<CauHoi>();
        private int giay = 0;
        private int soCauThi = 0;
        private int thoiGian = 0;
        private String trinhDo = "";
        private bool timeOut = false;
        private string maLop = "";
        int maBD = 0;
        public frmThi()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSet);

        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            DSet.EnforceConstraints = false;

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DSet.MONHOC);

            lb2.Text = Program.username;
            if (Program.mGroup.ToUpper().Equals("GIANGVIEN") || Program.mGroup.ToUpper().Equals("COSO"))
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DSet.LOP);
                lb1.Text = "MÃ GIÁO VIÊN:";
                lb5.Text = "TÊN GIÁO VIÊN:";
                lb6.Text = Program.mHoTen;
                lb3.Visible = lb4.Visible
                    = lb7.Visible = lb8.Visible = false;
               /*
                lb10.Text = "00:10";*/
            
            }
            else if(Program.mGroup.ToUpper().Equals("SINHVIEN"))
            {
                cbLop.Enabled = false;
                string strLenh = "exec sp_lay_tt_lop_tu_masv '" + Program.username + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null || !Program.myReader.Read()) return;
                
                maLop = Program.myReader.GetString(0);
                string tenLop = Program.myReader.GetString(1);
                lb4.Text = Program.mHoTen;
                lb6.Text = maLop;
                lb8.Text = tenLop;
            }
            btnBatDau.Enabled = false;
            panelGVDK.Enabled = true;
            cmbTenMH.SelectedIndex = 0;
            cmbLan.SelectedIndex = 0;
        }

        private bool kiemTraTruocKhiTim()
        {
            if (string.IsNullOrEmpty(dateNgayThi.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày thi!", "", MessageBoxButtons.OK);
                dateNgayThi.Focus();
                return false;
            }
            return true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiTim() == false) return;
            //if (date_NgayThi.DateTime.Date != DateTime.Now.Date)
            //{
            //    MessageBox.Show("Ngày thi phải là hôm nay!", "", MessageBoxButtons.OK);
            //    date_NgayThi.Focus();
            //    return;
            //}
            if (Program.mGroup.ToUpper().Equals("GIANGVIEN") || Program.mGroup.ToUpper().Equals("COSO") || Program.mGroup.ToUpper().Equals("SINHVIEN"))
            {
                string strLenh = "exec sp_tim_thong_tin_thi N'" + cmbTenMH.SelectedValue.ToString()
                          + "', N'" + dateNgayThi.DateTime.ToString("yyyy-MM-dd")
                          + "', " + cmbLan.SelectedItem  + ", '" 
                          + (cbLop.SelectedValue == null ? maLop : cbLop.SelectedValue.ToString()) + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                } else if(Program.myReader.Read() == false)
                {
                    MessageBox.Show("Không tìm thấy thông tin đăng ký thi!");
                    return;
                }

                trinhDo = Program.myReader.GetString(0);
                lb14.Text = trinhDo.ToString();

                soCauThi = Program.myReader.GetInt16(1);
                lb16.Text = soCauThi.ToString();

                thoiGian = Program.myReader.GetInt16(2);
                lb18.Text = thoiGian.ToString() + " Phút";
                //Int16 time = Program.myReader.GetInt16(2);
                //giay = time * 60;
                //time_Thi.Text = time.ToString() + ":00";

                btnBatDau.Enabled = true;
            /*    cmbTenMH.Enabled = false;
                dateNgayThi.Enabled = false;
                cmbLan.Enabled = false;
                cbLop.Enabled = false*/

                Program.myReader.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            int minutes = giay / 60;
            int seconds = giay % 60;
            string mi = "" + minutes;
            string se = "" + seconds;
            if (minutes < 10)
            {
                mi = "0" + mi;
            }
            if (seconds < 10)
            {
                se = "0" + se;
            }
            lb10.Text = mi + ":" + se;
            if (giay == 0)
            {
                timeOut = true;
                btnBatDau.PerformClick();

                panelGVDK.Enabled = true;
                btnBatDau.Enabled = false;
                btnTim.Enabled = true;
                btnThoat.Enabled = true;
            }
        }

        private void setColorDapAn(CauHoi x, Color c)
        {
            if (x.DapAn == "A")
            {
                x.Rbtn_A.ForeColor = c;

            }
            else if (x.DapAn == "B")
            {
                x.Rbtn_B.ForeColor = c;
            }
            else if (x.DapAn == "C")
            {
                x.Rbtn_C.ForeColor = c;
            }
            else if (x.DapAn == "D")
            {
                x.Rbtn_D.ForeColor = c;
            }
        }

        private string getDapAn(CauHoi x)
        {
            string da = "";
            if (x.Rbtn_A.Checked == true)
            {
                da = "A";
            }
            else if (x.Rbtn_B.Checked == true)
            {
                da = "B";
            }
            else if (x.Rbtn_C.Checked == true)
            {
                da = "C";
            }
            else if (x.Rbtn_D.Checked == true)
            {
                da = "D";
            }
            return da;
        }

        private int loadCauHoiThi()
        {
            string maMH = cmbTenMH.SelectedValue.ToString();
            string strLenh = "exec sp_lay_cau_hoi_thi '" + maMH + "', '" + trinhDo + "', " + soCauThi;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return -1;
            int cauHoi, stt = 1;
            string noiDung, a, b, c, d, dapAn;
           
             while(Program.myReader.Read())
             {
                 cauHoi = Program.myReader.GetInt32(0);
                 noiDung = Program.myReader.GetString(1);
                 a = Program.myReader.GetString(2);
                 b = Program.myReader.GetString(3);
                 c = Program.myReader.GetString(4);
                 d = Program.myReader.GetString(5);
                 dapAn = Program.myReader.GetString(6);
                 flowCH.Controls.Add(new CauHoi(stt++, cauHoi, noiDung, a, b, c, d, dapAn));
             }
            return stt;
        }
        private double tinhDiem()
        {
            int soCauDung = 0;
            foreach (CauHoi ch in flowCH.Controls)
            {
                string da = getDapAn(ch);
                if (da == ch.DapAn)
                {
                    soCauDung++;
                    setColorDapAn(ch, Color.Blue);
                }
                else
                {
                    setColorDapAn(ch, Color.Red);
                }
            }
            return Math.Round((soCauDung * 10) * 1.0 / soCauThi);
        }

        private int insertBangDiem(double diem)
        {
            //ghi vao bang diem
            string strLenh = "exec sp_insert_bang_diem N'"
             + Program.username + "', N'"
             + cmbTenMH.SelectedValue.ToString() + "', "
             + cmbLan.SelectedItem + ", N'"
             + dateNgayThi.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', "
             + diem;

            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0)
            {
                MessageBox.Show("Lỗi ghi bảng điểm!", "", MessageBoxButtons.OK);
            }
            return kq;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                int errorCode = loadCauHoiThi();
                if (errorCode == -1)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
                    return;
                }
                if(errorCode < soCauThi)
                {
                    if(MessageBox.Show("Bộ đề thiếu câu hỏi thi, bạn có muốn tiếp tục!", "Xác nhận?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        this.Close();
                        return;
                    }
                }
                giay = thoiGian * 60;
                btnBatDau.Text = "NỘP BÀI";
                timer1.Start();

                btnThoat.Enabled = false;
                btnTim.Enabled = false;
                cmbTenMH.Enabled = false;
                dateNgayThi.Enabled = false;
                cmbLan.Enabled = false;
                cbLop.Enabled = false;
            }
            else
            {
                if (timeOut == true || MessageBox.Show("Bạn có thật sự muốn nộp bài ? ", "Xác nhận",
                      MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnBatDau.Text = "BẮT ĐẦU";
                    timer1.Stop();
                    double diem = tinhDiem();

                    if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
                    {
                        MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;

                    }
                    else
                    {
                        if (insertBangDiem(diem) == 0)
                        {
                            //ghi chi tiet bai thi
                         //   insertBaiThi();

                        }

                        MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;
                    }
                    btnBatDau.Enabled = false;

                    cmbTenMH.Enabled = true;
                    dateNgayThi.Enabled = true;
                    cmbLan.Enabled = true;
                    cbLop.Enabled = true;
                    btnTim.Enabled = true;
                    btnThoat.Enabled = true;
                }

            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}
