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

namespace KHACHHANG
{
    public partial class GetIDForm : Form
    {
        public GetIDForm()
        {
            InitializeComponent();
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = txtMKH.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nhập tên khách hàng!"); return;
            }

            DatabaseConnect db = new DatabaseConnect();
            string sql = "SELECT * FROM DMKH WHERE CustomerID = @id";
            DataTable dt = db.ExecuteQuery(sql, new[] { new SqlParameter("@id", id) });

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy!"); return;
            }

            using (EditForm ef = new EditForm(dt.Rows[0]))
            {
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    // Gửi tín hiệu cho form chính refresh – cách đơn giản là sự kiện hoặc delegate
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

    }
}
