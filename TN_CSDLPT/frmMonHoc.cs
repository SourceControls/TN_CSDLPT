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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private object tableAdapterManager;
        int vitri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }


       /* private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            object p = this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }*/

       private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSet.MONHOC' table. You can move, or remove it, as needed.
        //    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DSet.MONHOC);

            // TODO: This line of code loads data into the 'dSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        //    this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'dSet.BODE' table. You can move, or remove it, as needed.
        //    this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DSet.BODE);

            // TODO: This line of code loads data into the 'dSet.BANGDIEM' table. You can move, or remove it, as needed.
        //    this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.DSet.BANGDIEM);
           
            /* if(Program.mGroup == "Truong") //Được lấy từ form đăng nhập do người đăng nhập thuộc nhóm nào.
             {
                  btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
              }
              else
              {*/
                  btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = true;
                  btnGhi.Enabled = false;
            //}
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            panelControl1.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMONHOC.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vt = -1;
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtMAMH.Focus();
                return;
            }

            if(txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtTENMH.Focus();
                return;
            }

            //Bắt điều kiện không trùng các môn học khác
            vt = bdsMonHoc.Find("MAMH", txtMAMH.Text.Trim());
            if (vt != -1)
            {
                MessageBox.Show("Môn học này đã tồn tại!", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
            //    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DSet.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMONHOC.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelControl1.Enabled = false;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMONHOC.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
            if(bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã được giảng viên đăng ký", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong bộ đề thi", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong bảng điểm", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn thật sự muốn xóa môn học này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                  //  maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                //    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DSet.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
            gcMONHOC.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MONHOCTableAdapter.Fill(this.DSet.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.DSet);

        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {

        }

        private void mONHOCBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENMHLabel_Click(object sender, EventArgs e)
        {

        }
    }
}