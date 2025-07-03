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
    public partial class AddForm : Form
    {

        private DatabaseConnect db = new DatabaseConnect();

        public AddForm()
        {
            InitializeComponent();
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string query = @"
        INSERT INTO DMKH 
        (CustomerID, CustomerName, TaxCode, IsCustomer, IsVendor, IsPersonal, Mobile, Email, Address, ContactPerson, DebtLimit, NumberDayLimit)
        VALUES 
        (@id, @name, @tax, @cus, @ven, @per, @mobile, @email, @address, @contact, @debt, @days)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@id", txtMKH.Text.Trim()),
        new SqlParameter("@name", txtTKH.Text.Trim()),
        new SqlParameter("@tax", textBox3.Text.Trim()),
        new SqlParameter("@cus", Cbkh.Checked),
        new SqlParameter("@ven", Cbncc.Checked),
        new SqlParameter("@per", Cbcn.Checked),
        new SqlParameter("@mobile", txtDT.Text.Trim()),
        new SqlParameter("@email", txtE.Text.Trim()),
        new SqlParameter("@address", txtDC.Text.Trim()),
        new SqlParameter("@contact", txtNLH.Text.Trim()),
        new SqlParameter("@debt", decimal.TryParse(txtGHTN.Text, out decimal debt) ? debt : 0),
        new SqlParameter("@days", int.TryParse(txtGHNN.Text, out int days) ? days : 0)
            };

            try
            {
                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thêm được khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
