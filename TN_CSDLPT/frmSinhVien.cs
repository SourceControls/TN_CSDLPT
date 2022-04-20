using DevExpress.XtraEditors;
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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        private static int viTri;
        private static String maLop;
        private static String maSV;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoatLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSet);
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            this.DSet.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DSet.KHOA);

           this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DSet.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DSet.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DSet.SINHVIEN);

            if (bdsLop.Count == 0) btnXoaLop.Enabled = false;

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TENCN";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            if(Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                cbCoSo.Enabled = true;
            } else
            {
                cbCoSo.Enabled = false;
            }

            if(Program.mGroup == "TRUONG")
            {
                btnThemLop.Enabled = btnHieuChinhLop.Enabled =
                btnXoaLop.Enabled = btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
            } else
            {
                btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
            }

            if(bdsKhoa.Count == 0)
            {
                MessageBox.Show("Không có khoa, phải có ít nhất một khoa tồn tại!");
                return;
            }
        }

        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.AddNew();

            //bật tắt các controller khác
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            panelLop.Enabled = true;
            gcLop.Enabled = false;
            btnThemLop.Enabled = btnHieuChinhLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = false;
        }

        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbTenKhoa.SelectedValue == null) return;
                txtMaKhoa.Text = cbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnHieuChinhLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKhoa.Position;

            //bật tắt các controller khácbtnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            panelLop.Enabled = true;
            gcLop.Enabled = false;
            btnThemLop.Enabled = btnHieuChinhLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = false;

        }

        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGV_DK.Count > 0)
            {
                MessageBox.Show("Lớp đã được đăng ký, không thể xoá!");
                return;
            }
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Lớp đang có sinh viên, không thể xoá!");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa lớp? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    lOPTableAdapter.Update(this.DSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lớp! " + ex.ToString());
                    lOPTableAdapter.Fill(this.DSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoaLop.Enabled = false;
        }

        private void btnGhiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (edtMaLop.Text.Trim().Length == 0 || edtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp và Tên lớp Không Được Để Trống");
                return;
            }
/*
            String cmd = "exec sp_kt_ton_tai_lop '" + edtMaLop.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            int isTonTai = Program.myReader.GetInt32(0);

            if (isTonTai == 1)
            {
                MessageBox.Show("Lớp đã tồn tại!");
                return;
            }*/

            try
            {
                bdsLop.EndEdit();
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTableAdapter.Update(DSet.LOP);
                bdsLop.ResetCurrentItem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp: " + ex.Message);
                lOPTableAdapter.Fill(DSet.LOP);
            }
            //bật tắt các controller khác
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
            panelLop.Enabled = false;
            gcLop.Enabled = true;
            btnHieuChinhLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = true;
        }

        private void btnReloadLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lOPTableAdapter.Fill(DSet.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.ToString());
                return;
            }
        }

        private void btnPhucHoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThemLop.Enabled == false) bdsLop.Position = viTri;
            //bật tắt các controller khác
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
            panelLop.Enabled = false;
            gcLop.Enabled = true;
            btnHieuChinhLop.Enabled = btnXoaLop.Enabled = 
            btnReloadLop.Enabled = btnThoatLop.Enabled = btnThemLop.Enabled = true;
        }

        private void cbTenKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbTenKhoa.SelectedValue == null) return;
                txtMaKhoa.Text = cbTenKhoa.SelectedValue.ToString();
            } catch (Exception)
            {

            }
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một lớp!");
                return;
            }
            bdsSinhVien.AddNew();
            ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MALOP"] = edtMaLop.Text;
        }

        private void ghiSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String masv = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            String ho = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["HO"].ToString();
            String ten = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["TEN"].ToString();
            if (masv.Trim().Length == 0 || ho.Trim().Length == 0 || ten.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn cần nhập đầy đủ các trường Mã sinh viên, họ, tên!");
                return;
            }
            try
            {
                bdsSinhVien.EndEdit();
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                sINHVIENTableAdapter.Update(DSet.SINHVIEN);
                bdsSinhVien.ResetCurrentItem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp: " + ex.Message);
                sINHVIENTableAdapter.Fill(DSet.SINHVIEN);
            }
        }

        private void xoáSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count == 0) return;
            if (MessageBox.Show("Xác nhận xóa sinh viên? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                    bdsSinhVien.RemoveCurrent();
                    sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    sINHVIENTableAdapter.Update(this.DSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên! " + ex.ToString());
                    sINHVIENTableAdapter.Fill(this.DSet.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                    return;
                }
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsSinhVien.CancelEdit();
        }
    }
}