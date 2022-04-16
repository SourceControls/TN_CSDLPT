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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dSet.KHOA);
            // TODO: This line of code loads data into the 'dSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dSet.LOP);

        }

        private void lOPBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}