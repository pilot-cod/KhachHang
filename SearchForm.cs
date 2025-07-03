using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHACHHANG
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public string CustomerNameFilter { get; private set; }
        public bool? IsCustomerFilter { get; private set; }
        public bool? IsVendorFilter { get; private set; }
        public bool? IsPersonalFilter { get; private set; }


        private void HuyBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            CustomerNameFilter = txtTKH.Text.Trim();

            IsCustomerFilter = Cbkh.CheckState == CheckState.Indeterminate ? (bool?)null : Cbkh.Checked;
            IsVendorFilter = Cbncc.CheckState == CheckState.Indeterminate ? (bool?)null : Cbncc.Checked;
            IsPersonalFilter = Cbcn.CheckState == CheckState.Indeterminate ? (bool?)null : Cbcn.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
