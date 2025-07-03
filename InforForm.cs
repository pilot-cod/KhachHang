using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KHACHHANG
{
    public partial class EditForm : Form
    {
        private readonly DatabaseConnect db = new DatabaseConnect();
        private readonly string _customerID;   

        public EditForm() : this(null) { }

        public EditForm(DataRow data)
        {
            InitializeComponent();

            if (data == null) return;     

            _customerID = data["CustomerID"].ToString();   

            txtMKH.Text = _customerID;
            txtTKH.Text = data["CustomerName"].ToString();
            textBox3.Text = data["TaxCode"].ToString();
            txtDT.Text = data["Mobile"].ToString();
            txtE.Text = data["Email"].ToString();
            txtDC.Text = data["Address"].ToString();
            txtNLH.Text = data["ContactPerson"].ToString();
            txtGHTN.Text = data["DebtLimit"].ToString();
            txtGHNN.Text = data["NumberDayLimit"].ToString();

            Cbkh.Checked = Convert.ToBoolean(data["IsCustomer"]);
            Cbncc.Checked = Convert.ToBoolean(data["IsVendor"]);
            Cbcn.Checked = Convert.ToBoolean(data["IsPersonal"]);
        }

        private void HuyButton_Click(object sender, EventArgs e) => Close();

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_customerID))
            {
                MessageBox.Show("Thiếu ID khách hàng – không thể cập nhật!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"
                  UPDATE DMKH SET
                        CustomerName   = @name,
                        TaxCode        = @tax,
                        IsCustomer     = @cus,
                        IsVendor       = @ven,
                        IsPersonal     = @per,
                        Mobile         = @mobile,
                        Email          = @email,
                        Address        = @address,
                        ContactPerson  = @contact,
                        DebtLimit      = @limit,
                        NumberDayLimit = @days
                  WHERE CustomerID     = @id";

            SqlParameter[] prm = {
                new SqlParameter("@name",    txtTKH.Text.Trim()),
                new SqlParameter("@tax",     textBox3.Text.Trim()),
                new SqlParameter("@cus",     Cbkh.Checked),
                new SqlParameter("@ven",     Cbncc.Checked),
                new SqlParameter("@per",     Cbcn.Checked),
                new SqlParameter("@mobile",  txtDT.Text.Trim()),
                new SqlParameter("@email",   txtE.Text.Trim()),
                new SqlParameter("@address", txtDC.Text.Trim()),
                new SqlParameter("@contact", txtNLH.Text.Trim()),
                new SqlParameter("@limit",   decimal.TryParse(txtGHTN.Text, out var lim) ? lim : 0),
                new SqlParameter("@days",    int.TryParse(txtGHNN.Text, out var day) ? day : 0),
                new SqlParameter("@id",      _customerID)
            };

            try
            {
                int rows = db.ExecuteNonQuery(sql, prm);   
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;   
                    Close();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu được thay đổi.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
