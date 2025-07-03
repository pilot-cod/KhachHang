using System;
using System.Windows.Forms;

namespace KHACHHANG
{
    public partial class ResultForm : Form
    {
        public ResultForm(string content)
        {
            InitializeComponent();
            txtResult.Text = content;
        }
    }
}
