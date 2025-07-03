namespace KHACHHANG
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDebtLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumberDayLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERLISTDataSet = new KHACHHANG.CUSTOMERLISTDataSet();
            this.dMKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMKHTableAdapter = new KHACHHANG.CUSTOMERLISTDataSetTableAdapters.DMKHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERLISTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(485, 652);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(389, 78);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(1032, 652);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(367, 78);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Cập nhật";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(1513, 652);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(331, 78);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(16, 652);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(359, 78);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Tìm";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomerID,
            this.txtCustomerName,
            this.txtTaxCode,
            this.txtIsCustomer,
            this.txtIsVendor,
            this.txtIsPersonal,
            this.txtMobile,
            this.txtEmail,
            this.txtAddress,
            this.txtContactPerson,
            this.txtDebtLimit,
            this.txtNumberDayLimit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerList.Location = new System.Drawing.Point(16, 15);
            this.CustomerList.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(1828, 614);
            this.CustomerList.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.HeaderText = "Mã Khách Hàng";
            this.txtCustomerID.Name = "txtCustomerID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.HeaderText = "Tên Khách hàng";
            this.txtCustomerName.Name = "txtCustomerName";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.HeaderText = "Mã Số Thuế";
            this.txtTaxCode.Name = "txtTaxCode";
            // 
            // txtIsCustomer
            // 
            this.txtIsCustomer.HeaderText = "Là Khách Hàng";
            this.txtIsCustomer.Name = "txtIsCustomer";
            // 
            // txtIsVendor
            // 
            this.txtIsVendor.HeaderText = "Là Nhà Cung Cấp";
            this.txtIsVendor.Name = "txtIsVendor";
            // 
            // txtIsPersonal
            // 
            this.txtIsPersonal.HeaderText = "Là Cá Nhân";
            this.txtIsPersonal.Name = "txtIsPersonal";
            // 
            // txtMobile
            // 
            this.txtMobile.HeaderText = "Điện Thoại";
            this.txtMobile.Name = "txtMobile";
            // 
            // txtEmail
            // 
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.Name = "txtEmail";
            // 
            // txtAddress
            // 
            this.txtAddress.HeaderText = "Địa Chỉ";
            this.txtAddress.Name = "txtAddress";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.HeaderText = "Người Liên Hệ";
            this.txtContactPerson.Name = "txtContactPerson";
            // 
            // txtDebtLimit
            // 
            this.txtDebtLimit.HeaderText = "Giới Hạn Tiền Nợ Cho Phép";
            this.txtDebtLimit.Name = "txtDebtLimit";
            // 
            // txtNumberDayLimit
            // 
            this.txtNumberDayLimit.HeaderText = "Giới Hạn Ngày Nợ Cho Phép";
            this.txtNumberDayLimit.Name = "txtNumberDayLimit";
            // 
            // cUSTOMERLISTDataSet
            // 
            this.cUSTOMERLISTDataSet.DataSetName = "CUSTOMERLISTDataSet";
            this.cUSTOMERLISTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMKHBindingSource
            // 
            this.dMKHBindingSource.DataMember = "DMKH";
            this.dMKHBindingSource.DataSource = this.cUSTOMERLISTDataSet;
            // 
            // dMKHTableAdapter
            // 
            this.dMKHTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 775);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "CustomerForm";
            this.Text = "DANH MỤC KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERLISTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView CustomerList;
        private CUSTOMERLISTDataSet cUSTOMERLISTDataSet;
        private System.Windows.Forms.BindingSource dMKHBindingSource;
        private CUSTOMERLISTDataSetTableAdapters.DMKHTableAdapter dMKHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDebtLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumberDayLimit;
    }
}

