using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private String maLop;
        private String maMonHoc;
        private String lanThi;

        public frmBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void initBDS()
        {
            this.DSet.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DSet.MONHOC);

            this.tENLOPMALOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENLOPMALOPTableAdapter.Fill(this.DSet.TENLOPMALOP);
        }

        private void frmBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            initBDS();

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TENCN";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup.ToUpper().Equals("TRUONG") || Program.mGroup.ToUpper().Equals("GIANGVIEN"))
            {
                cbCoSo.Enabled = true;
            }
            else
            {
                cbCoSo.Enabled = false;
            }

            cbLanThi.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.mCoSo = cbCoSo.SelectedIndex;
            Program.connectToOtherSite(cbCoSo.SelectedValue.ToString());
            initBDS();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            XrptBangDiemMonHoc rptBDMH = new XrptBangDiemMonHoc(maLop, maMonHoc, int.Parse(cbLanThi.Text.ToString()));
            rptBDMH.lbHeaderBangDiemMonHoc.Text = "DANH SÁCH ĐIỂM KẾT THÚC MÔN CỦA LỚP " + cbLop.Text.ToString().ToUpper() 
                    + " MÔN HỌC " + cbMonHoc.Text.ToString() + " LẦN " + cbLanThi.Text.ToString();
            ReportPrintTool rpt = new ReportPrintTool(rptBDMH);
            rpt.ShowPreviewDialog();

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maLop = cbLop.SelectedValue.ToString();
            } catch(Exception)
            {

            }
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maMonHoc = cbMonHoc.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}