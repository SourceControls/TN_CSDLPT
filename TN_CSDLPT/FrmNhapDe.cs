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

namespace TN_CSDLPT.Resources
{
    public partial class frmNhapDe1 : DevExpress.XtraEditors.XtraForm
    {

        BindingSource bdsTrinhDo = new BindingSource();

        public frmNhapDe1()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void frmNhapDe1_Load(object sender, EventArgs e)
        {
            dSet.EnforceConstraints = true;
            // TODO: This line of code loads data into the 'dSet.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.dSet.MONHOC);


            cbMonHoc.DataSource = bdsMonHoc;
            cbMonHoc.DisplayMember = "TENMH";
            cbMonHoc.ValueMember = "MAMH";

            bdsTrinhDo.Add("A - Đại học,chuyên ngành");
            bdsTrinhDo.Add("B - Đại học, không chuyên ngành");
            bdsTrinhDo.Add("C - Cao đẳng");
            cbTrinhDo.DataSource = bdsTrinhDo;
        }

        private void btnLayBoDe_Click(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex == -1 || cbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn môn học và trình độ");
                return;
            }
            String maMH = cbMonHoc.SelectedValue.ToString();
            String maTrinhDo = cbTrinhDo.SelectedItem.ToString().Substring(0, 1 );
            this.SP_LAY_BO_DETableAdapter.Fill(this.dSet.SP_LAY_BO_DE, maMH, maTrinhDo);
            bdsLayBoDe.AddNew();
        }

    }
}