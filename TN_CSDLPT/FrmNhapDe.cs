using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmNhapDe : DevExpress.XtraEditors.XtraForm
    {

        BindingSource bdsTrinhDo = new BindingSource();
        String maMonHoc = "";
        String maTrinhDo = "";
        int slCau = 1;

        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            dSet.EnforceConstraints = true;
            // TODO: This line of code loads data into the 'dSet.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dSet.MONHOC);


            cbMonHoc.DataSource = bdsMonHoc;
            cbMonHoc.DisplayMember = "TENMH";
            cbMonHoc.ValueMember = "MAMH";

            bdsTrinhDo.Add("A - Đại học,chuyên ngành");
            bdsTrinhDo.Add("B - Đại học, không chuyên ngành");
            bdsTrinhDo.Add("C - Cao đẳng");
            cbTrinhDo.DataSource = bdsTrinhDo;
            btnLuuBoDe.Enabled = btnHuyNhap.Enabled = nHAP_BO_DEGridControl.Enabled = false;
        }

        private void btnbatDauNhap_Click(object sender, EventArgs e)
        {
            int slCau = (int) txtSoLuongCau.Value;

            String maMH = cbMonHoc.SelectedValue.ToString();
            String maTrinhDo = cbTrinhDo.SelectedItem.ToString().Substring(0, 1);
            for (int i = 0; i < slCau; i++)
            {
                bdsNhapBoDe.AddNew();
            }
            bdsNhapBoDe.Position = 0;
            btnBatDauNhap.Enabled = txtSoLuongCau.Enabled = false;
            nHAP_BO_DEGridControl.Enabled = btnLuuBoDe.Enabled = btnHuyNhap.Enabled = true;

        }

        private void sP_LAY_BO_DEGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuBoDe_Click(object sender, EventArgs e)
        {

            bdsNhapBoDe.CancelEdit();
            if (cbMonHoc.SelectedIndex == -1 || cbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn môn học và trình độ");
                return;
            }
            DataTable dt = dSet.NHAP_BO_DE.Copy();
            String maMH = cbMonHoc.SelectedValue.ToString();
            String maTrinhDo = cbTrinhDo.SelectedItem.ToString().Substring(0, 1);
          
            DataRow dtrow;
            for (int row = dt.Rows.Count - 1; row > -1; row--)
             {
                dtrow = dt.Rows[row];
                if (dtrow.ItemArray[1].ToString().Trim().Length != 0)  //check có câu hỏi nhưng thiếu đáp án hoặc câu tl
                    for (int col = 2; col <= 6; col++)
                    {
                        if (dtrow.ItemArray[col].ToString().Trim().Length == 0) {
                            bdsNhapBoDe.Position = row;
                            MessageBox.Show("Đáp án và câu trả lời không được để trống");
                            return;
                        }
                }
                else
                {
                    dtrow.Delete();  //nội dung câu hỏi trống thì coi như bỏ dòng đó 
                }
            }

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_BO_DE";
            para.ParameterName = "@BODE";
            para.Value = dt;

            SqlParameter para1 = new SqlParameter();
            para1.SqlDbType = SqlDbType.Char;
            para1.ParameterName = "@MAGV";
            para1.Value = Program.mloginDN;

            SqlParameter para2 = new SqlParameter();
            para2.SqlDbType = SqlDbType.Char;
            para2.ParameterName = "@MAMH";
            para2.Value = maMH;
            
            SqlParameter para3 = new SqlParameter();
            para3.SqlDbType = SqlDbType.Char;
            para3.ParameterName = "@MATRINHDO";
            para3.Value =  maTrinhDo;

            Program.connectToDB();
            SqlCommand Sqlcmd = new SqlCommand("SP_INSERT_BODE", Program.conn);
            Sqlcmd.Parameters.Clear();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.Parameters.Add(para);
            Sqlcmd.Parameters.Add(para1);
            Sqlcmd.Parameters.Add(para2);
            Sqlcmd.Parameters.Add(para3);
            if(Sqlcmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Lưu bộ đề thành công");
                dSet.NHAP_BO_DE.Clear();
                dSet.NHAP_BO_DE.STTColumn.AutoIncrementSeed = -1;
                dSet.NHAP_BO_DE.STTColumn.AutoIncrementStep = -1;
                dSet.NHAP_BO_DE.STTColumn.AutoIncrementSeed = 1;
                dSet.NHAP_BO_DE.STTColumn.AutoIncrementStep = 1;
                btnBatDauNhap.Enabled = txtSoLuongCau.Enabled = true;
                nHAP_BO_DEGridControl.Enabled = btnLuuBoDe.Enabled = btnHuyNhap.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lưu bộ đề thất bại");

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdsNhapBoDe.CancelEdit();
            dSet.NHAP_BO_DE.Clear();
            dSet.NHAP_BO_DE.STTColumn.AutoIncrementSeed = -1;
            dSet.NHAP_BO_DE.STTColumn.AutoIncrementStep = -1;
            dSet.NHAP_BO_DE.STTColumn.AutoIncrementSeed = 1;
            dSet.NHAP_BO_DE.STTColumn.AutoIncrementStep = 1;
            btnBatDauNhap.Enabled = txtSoLuongCau.Enabled =  true;
            nHAP_BO_DEGridControl.Enabled = btnLuuBoDe.Enabled = btnHuyNhap.Enabled = false;
        }
    }
}