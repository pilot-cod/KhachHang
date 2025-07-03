namespace KHACHHANG
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.Cbkh = new System.Windows.Forms.CheckBox();
            this.Cbncc = new System.Windows.Forms.CheckBox();
            this.Cbcn = new System.Windows.Forms.CheckBox();
            this.SearchBut = new System.Windows.Forms.Button();
            this.HuyBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Là khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Là nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Là cá nhân";
            // 
            // txtTKH
            // 
            this.txtTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKH.Location = new System.Drawing.Point(207, 28);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(541, 26);
            this.txtTKH.TabIndex = 1;
            // 
            // Cbkh
            // 
            this.Cbkh.AutoSize = true;
            this.Cbkh.Location = new System.Drawing.Point(207, 77);
            this.Cbkh.Name = "Cbkh";
            this.Cbkh.Size = new System.Drawing.Size(15, 14);
            this.Cbkh.TabIndex = 2;
            this.Cbkh.ThreeState = true;
            this.Cbkh.UseVisualStyleBackColor = true;
            // 
            // Cbncc
            // 
            this.Cbncc.AutoSize = true;
            this.Cbncc.Location = new System.Drawing.Point(207, 136);
            this.Cbncc.Name = "Cbncc";
            this.Cbncc.Size = new System.Drawing.Size(15, 14);
            this.Cbncc.TabIndex = 2;
            this.Cbncc.UseVisualStyleBackColor = true;
            // 
            // Cbcn
            // 
            this.Cbcn.AutoSize = true;
            this.Cbcn.Location = new System.Drawing.Point(207, 192);
            this.Cbcn.Name = "Cbcn";
            this.Cbcn.Size = new System.Drawing.Size(15, 14);
            this.Cbcn.TabIndex = 2;
            this.Cbcn.UseVisualStyleBackColor = true;
            // 
            // SearchBut
            // 
            this.SearchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut.Location = new System.Drawing.Point(29, 251);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(202, 49);
            this.SearchBut.TabIndex = 3;
            this.SearchBut.Text = "Tìm";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // HuyBut
            // 
            this.HuyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyBut.Location = new System.Drawing.Point(546, 251);
            this.HuyBut.Name = "HuyBut";
            this.HuyBut.Size = new System.Drawing.Size(202, 49);
            this.HuyBut.TabIndex = 3;
            this.HuyBut.Text = "Hủy";
            this.HuyBut.UseVisualStyleBackColor = true;
            this.HuyBut.Click += new System.EventHandler(this.HuyBut_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 326);
            this.Controls.Add(this.HuyBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.Cbcn);
            this.Controls.Add(this.Cbncc);
            this.Controls.Add(this.Cbkh);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.CheckBox Cbkh;
        private System.Windows.Forms.CheckBox Cbncc;
        private System.Windows.Forms.CheckBox Cbcn;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Button HuyBut;
    }
}