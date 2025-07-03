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
    public partial class DeleteForm : Form
    {
        private readonly DatabaseConnect db = new DatabaseConnect();

        public DeleteForm()
        {
            InitializeComponent();
            DeleteButton.Click += DeleteButton_Click; // sự kiện nút xóa
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string customerID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng có mã \"{customerID}\" không?",
                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string sql = "DELETE FROM DMKH WHERE CustomerID = @id";
            SqlParameter[] prm = { new SqlParameter("@id", customerID) };

            try
            {
                int rows = db.ExecuteNonQuery(sql, prm);
                if (rows > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // báo form cha cập nhật
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
