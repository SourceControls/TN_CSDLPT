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
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        private String maCoSo = "";
        private int vitri;
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSet);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.DSet.LOP);
            // TODO: This line of code loads data into the 'DSet.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.DSet.LOP);
            DSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dSet.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DSet.KHOA);

            // TODO: This line of code loads data into the 'DSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DSet.GIAOVIEN);

            // TODO: This line of code loads data into the 'DSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'DSet.BODE' table. You can move, or remove it, as needed.
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DSet.BODE);

            if (bdsKhoa.Count > 0)
                maCoSo = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            else
                return;


            cmbCoSo.DataSource = Program.bdsDSPM;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            //Phân quyền dùng app theo group
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnGhi.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnGhi.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                cmbCoSo.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            bdsKhoa.AddNew();
            txtMACS.Text = maCoSo;

            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            panelKhoa.Enabled = true;
            gcKHOA.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;

            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            panelKhoa.Enabled = true;
            gcKHOA.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKhoa = "";
            if (bdsGiaoVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa đã có giáo viên");
                return;
            }
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa đã có lớp");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa khoa? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKhoa.RemoveCurrent();
                    maKhoa = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                    KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    KHOATableAdapter.Update(DSet.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khoa! " + ex.ToString());
                    KHOATableAdapter.Fill(DSet.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", maKhoa);
                    return;
                }
            }
            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKH.Text.Trim().Length == 0 || txtTENKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã Khoa Và Tên Khoa Không Được Để Trống");
                return;
            }

            // thiếu code mã khoa không được trùng trên các phân mảnh

            try
            {
                bdsKhoa.EndEdit();
                KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                KHOATableAdapter.Update(DSet.KHOA);
                bdsKhoa.ResetCurrentItem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Khoa: " + ex.Message);
                KHOATableAdapter.Fill(DSet.KHOA);
            }
            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelKhoa.Enabled = false;
            gcKHOA.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            bdsKhoa.Position = vitri;
            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelKhoa.Enabled = false;
            gcKHOA.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KHOATableAdapter.Fill(DSet.KHOA);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.ToString());
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtMACS_TextChanged(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsGiaoVien.AddNew();
            ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAKH"] = txtMAKH.Text;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String maGV = "";
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên vì đã đăng ký môn học");
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên vì đã làm bộ đề thi");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa giáo viên? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsGiaoVien.RemoveCurrent();
                    maGV = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGV"].ToString();
                    GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    GIAOVIENTableAdapter.Update(DSet.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa giáo viên! " + ex.ToString());
                    GIAOVIENTableAdapter.Fill(DSet.GIAOVIEN);
                    bdsGiaoVien.Position = bdsGiaoVien.Find("MAGV", maGV);
                    return;
                }
            }
            if (bdsGiaoVien.Count == 0) xoaToolStripMenuItem.Enabled = false;
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= bdsGiaoVien.Count; i++)
            {
                if (((DataRowView)bdsGiaoVien[i])["MAGV"].ToString().Length == 0 ||
                    ((DataRowView)bdsGiaoVien[i])["HO"].ToString().Length == 0 ||
                    ((DataRowView)bdsGiaoVien[i])["TEN"].ToString().Length == 0 ||
                    ((DataRowView)bdsGiaoVien[i])["DIACHI"].ToString().Length == 0) 
                {
                    MessageBox.Show("Không được để dữ liệu trống ở các cột!");
                    return;
                }
            }
            // thiếu code mã khoa không được trùng trên các phân mảnh

            try
            {
                bdsGiaoVien.EndEdit();
                GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                GIAOVIENTableAdapter.Update(DSet.GIAOVIEN);
                bdsGiaoVien.ResetCurrentItem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên: " + ex.Message);
                GIAOVIENTableAdapter.Fill(DSet.GIAOVIEN);
            }
        }

        private void gcKHOA_Click(object sender, EventArgs e)
        {

        }
    }
}