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
    public partial class CustomerForm : Form
    {
        DatabaseConnect db = new DatabaseConnect();

        public CustomerForm()
        {
            InitializeComponent();
            CustomerList.CellFormatting += CustomerList_CellFormatting;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cUSTOMERLISTDataSet.DMKH' table. You can move, or remove it, as needed.
            SetColumnBindings();
            LoadData();
        }

        private void Custable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData()
        {
            string query = "SELECT * FROM DMKH"; 
            DataTable dt = db.ExecuteQuery(query);
            CustomerList.AutoGenerateColumns = false;
            CustomerList.DataSource = dt;
        }

        private void SetColumnBindings()
        {        
            txtCustomerID.DataPropertyName = "CustomerID";
            txtCustomerName.DataPropertyName = "CustomerName";
            txtTaxCode.DataPropertyName = "TaxCode";
            txtIsCustomer.DataPropertyName = "IsCustomer";
            txtIsVendor.DataPropertyName = "IsVendor";
            txtIsPersonal.DataPropertyName = "IsPersonal";
            txtMobile.DataPropertyName = "Mobile";
            txtEmail.DataPropertyName = "Email";
            txtAddress.DataPropertyName = "Address";
            txtContactPerson.DataPropertyName = "ContactPerson"; 
            txtDebtLimit.DataPropertyName = "DebtLimit";
            txtNumberDayLimit.DataPropertyName = "NumberDayLimit";
        }

        private void CustomerList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string col = CustomerList.Columns[e.ColumnIndex].Name;

            if ((col == "txtIsCustomer" || col == "txtIsVendor" || col == "txtIsPersonal")
                && e.Value is bool)
            {
                e.Value = ((bool)e.Value) ? "Có" : "Không";
                e.FormattingApplied = true;           
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (SearchForm sf = new SearchForm())
            {
                if (sf.ShowDialog() != DialogResult.OK) return;
              
                if (!string.IsNullOrWhiteSpace(sf.CustomerNameFilter))
                {
                    string nameQuery = @"
                SELECT * 
                FROM DMKH 
                WHERE LTRIM(RTRIM(CustomerName)) COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @name";

                    SqlParameter[] nameParams = {
                new SqlParameter("@name", $"%{sf.CustomerNameFilter.Trim()}%")
            };

                    DataTable nameResults = db.ExecuteQuery(nameQuery, nameParams);

                    if (nameResults.Rows.Count > 0)
                    {
                        StringBuilder msg = new StringBuilder("Thông tin khách hàng tìm thấy:\n\n");

                        foreach (DataRow row in nameResults.Rows)
                        {
                            msg.AppendLine($"ID                : {row["CustomerID"]}");
                            msg.AppendLine($"Tên               : {row["CustomerName"]}");
                            msg.AppendLine($"Mã số thuế        : {row["TaxCode"]}");
                            msg.AppendLine($"Là KH             : {(Convert.ToBoolean(row["IsCustomer"]) ? "Có" : "Không")}");
                            msg.AppendLine($"Là NCC            : {(Convert.ToBoolean(row["IsVendor"]) ? "Có" : "Không")}");
                            msg.AppendLine($"Là cá nhân        : {(Convert.ToBoolean(row["IsPersonal"]) ? "Có" : "Không")}");
                            msg.AppendLine($"Điện thoại        : {row["Mobile"]}");
                            msg.AppendLine($"Email             : {row["Email"]}");
                            msg.AppendLine($"Địa chỉ           : {row["Address"]}");
                            msg.AppendLine($"Người liên hệ     : {row["ContactPerson"]}");
                            msg.AppendLine($"Hạn mức CN        : {row["DebtLimit"]}");
                            msg.AppendLine($"Số ngày nợ tối đa : {row["NumberDayLimit"]}");
                            msg.AppendLine(new string('-', 50));
                        }
                        using (ResultForm rf = new ResultForm(msg.ToString()))
                        {
                            rf.ShowDialog();      
                        }
                    }
                    else
                    {

                        using (ResultForm rf = new ResultForm("Không tìm thấy khách hàng nào!"))
                        {
                            rf.ShowDialog();
                        }
                    }
                }
            
                StringBuilder sql = new StringBuilder("SELECT * FROM DMKH WHERE 1=1");
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (sf.IsCustomerFilter.HasValue)
                {
                    sql.Append(" AND IsCustomer = @isCus");
                    parameters.Add(new SqlParameter("@isCus", SqlDbType.Bit) { Value = sf.IsCustomerFilter.Value });
                }

                if (sf.IsVendorFilter.HasValue)
                {
                    sql.Append(" AND IsVendor = @isVen");
                    parameters.Add(new SqlParameter("@isVen", SqlDbType.Bit) { Value = sf.IsVendorFilter.Value });
                }

                if (sf.IsPersonalFilter.HasValue)
                {
                    sql.Append(" AND IsPersonal = @isPer");
                    parameters.Add(new SqlParameter("@isPer", SqlDbType.Bit) { Value = sf.IsPersonalFilter.Value });
                }

                if (parameters.Count > 0)
                {
                    DataTable dt = db.ExecuteQuery(sql.ToString(), parameters.ToArray());
                    CustomerList.AutoGenerateColumns = false;
                    CustomerList.DataSource = dt;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            GetIDForm f = new GetIDForm();
            f.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm();
            f.ShowDialog();
        }
    }
}
