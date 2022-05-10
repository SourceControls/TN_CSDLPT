using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private void openForm(Form newFrm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if ( f.GetType() == newFrm.GetType())
                {
                    MessageBox.Show("Form đã mở sẵn");  
                    f.Activate();
                    return;
                }
            }
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        public void closeAllForm()
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            this.rbGiangVien.Visible = false;
            this.rbBaoCao.Visible = false;
            this.rbNghiepVu.Visible = false;
        }


        public frmMain()
        {
            InitializeComponent();
            //dữ liệu ban đầu

            openForm(new frmLogin());

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmLogin());
            XrptKetQuaBaiThi x = new XrptKetQuaBaiThi();
            ReportPrintTool rpt = new ReportPrintTool(x);
            rpt.ShowPreviewDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmRegister());
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmKhoa());
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmMonHoc());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmLop());
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmSinhVien());
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmGiaoVien());
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmBangDiemMonHoc());
        }
    }
}
