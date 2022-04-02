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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        private String maCoSo = "";
        private int viTri = 0;

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa1_Load(object sender, EventArgs e)
        {
            DSet.EnforceConstraints = false;


            this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter.Fill(this.DSet.KHOA);
            // TODO: This line of code loads data into the 'DSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaoVienTableAdapter.Fill(this.DSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'DSet.LOP' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.DSet.LOP);
            



            if (bdsKhoa.Count > 0)
                maCoSo = ((DataRowView)bdsKhoa[0])["MACS"].ToString();


            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TENCN";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            //Phân quyền dùng app theo group
            btnGhiKhoa.Enabled = btnPhucHoiKhoa.Enabled = false;

                if (Program.mGroup == "TRUONG")
            {
                cbCoSo.Enabled = true;
                btnGhiKhoa.Enabled = btnHieuChinhKhoa.Enabled = btnXoaKhoa.Enabled = false;
            }
            else
            {
                btnGhiKhoa.Enabled = btnHieuChinhKhoa.Enabled = btnXoaKhoa.Enabled = true;
                cbCoSo.Enabled = false;
            }
        }

        private void panelKhoa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.AddNew();
            txtMaCoSo.Text = maCoSo;

            //bật tắt các controller khác
            btnGhiKhoa.Enabled = btnPhucHoiKhoa.Enabled = true;
            panelKhoa.Enabled = true;
            gcKhoa.Enabled = false;
            btnHieuChinhKhoa.Enabled = btnXoaKhoa.Enabled = btnReloadKhoa.Enabled = btnThoatKhoa.Enabled = false;
        }

        private void btnHieuChinhKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKhoa.Position;

            //bật tắt các controller khác
            btnGhiKhoa.Enabled = btnPhucHoiKhoa.Enabled = true;
            panelKhoa.Enabled = true;
            gcKhoa.Enabled = false;
            btnHieuChinhKhoa.Enabled = btnXoaKhoa.Enabled = btnReloadKhoa.Enabled = btnThoatKhoa.Enabled = false;
        }

        private void btnXoaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKhoa = "";
            if (gvKhoa.GetSelectedRows().Length == 0) return;  //check xem có row được chọn không
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
                    khoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    khoaTableAdapter.Update(DSet.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khoa! " + ex.ToString());
                    khoaTableAdapter.Fill(DSet.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", maKhoa);
                    return;
                }
            }
            if (bdsKhoa.Count == 0) btnXoaKhoa.Enabled = false;
        }

        private void btnGhiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhucHoiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            if (btnThemKhoa.Enabled == false) bdsKhoa.Position = viTri;
            //bật tắt các controller khác
            btnGhiKhoa.Enabled = btnPhucHoiKhoa.Enabled = false;
            panelKhoa.Enabled = false;
            gcKhoa.Enabled = true;
            btnHieuChinhKhoa.Enabled = btnXoaKhoa.Enabled = btnReloadKhoa.Enabled = btnThoatKhoa.Enabled = true;
        }

        private void btnReloadKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoaTableAdapter.Fill(DSet.KHOA);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.ToString());
                return;
            }
        }

        private void btnThoatKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

    }
   
}