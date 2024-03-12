namespace Test_04
{
    partial class FormKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btn_lammoi = new Button();
            groupBox3 = new GroupBox();
            ckb_la_canhan = new CheckBox();
            groupBox2 = new GroupBox();
            ckb_la_nhacungcap = new CheckBox();
            groupBox1 = new GroupBox();
            ckb_la_khachhang = new CheckBox();
            txt_masothue = new TextBox();
            txt_tenkh = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_cap_nhat = new Button();
            btn_them_moi = new Button();
            txt_songaychophep = new TextBox();
            txt_tiennochophep = new TextBox();
            txt_nglienhe = new TextBox();
            txt_diachi = new TextBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            txt_makh = new TextBox();
            panel2 = new Panel();
            grdv_khachang = new DataGridView();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCustomerDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isVendorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isPersonalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mobileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            debtLimitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDayLimitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            khachHangBindingSource = new BindingSource(components);
            btn_xoa = new Button();
            label13 = new Label();
            label14 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdv_khachang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_lammoi);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txt_masothue);
            panel1.Controls.Add(txt_tenkh);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_cap_nhat);
            panel1.Controls.Add(btn_them_moi);
            panel1.Controls.Add(txt_songaychophep);
            panel1.Controls.Add(txt_tiennochophep);
            panel1.Controls.Add(txt_nglienhe);
            panel1.Controls.Add(txt_diachi);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(txt_makh);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 618);
            panel1.TabIndex = 0;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(216, 562);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(88, 34);
            btn_lammoi.TabIndex = 34;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckb_la_canhan);
            groupBox3.Location = new Point(216, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 25);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // ckb_la_canhan
            // 
            ckb_la_canhan.AutoSize = true;
            ckb_la_canhan.Location = new Point(17, 6);
            ckb_la_canhan.Name = "ckb_la_canhan";
            ckb_la_canhan.Size = new Size(55, 19);
            ckb_la_canhan.TabIndex = 29;
            ckb_la_canhan.Text = "Đúng";
            ckb_la_canhan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckb_la_nhacungcap);
            groupBox2.Location = new Point(216, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 29);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // ckb_la_nhacungcap
            // 
            ckb_la_nhacungcap.AutoSize = true;
            ckb_la_nhacungcap.Location = new Point(17, 10);
            ckb_la_nhacungcap.Name = "ckb_la_nhacungcap";
            ckb_la_nhacungcap.Size = new Size(55, 19);
            ckb_la_nhacungcap.TabIndex = 28;
            ckb_la_nhacungcap.Text = "Đúng";
            ckb_la_nhacungcap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckb_la_khachhang);
            groupBox1.Location = new Point(216, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 35);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // ckb_la_khachhang
            // 
            ckb_la_khachhang.AutoSize = true;
            ckb_la_khachhang.Location = new Point(17, 13);
            ckb_la_khachhang.Name = "ckb_la_khachhang";
            ckb_la_khachhang.Size = new Size(55, 19);
            ckb_la_khachhang.TabIndex = 0;
            ckb_la_khachhang.Text = "Đúng";
            ckb_la_khachhang.UseVisualStyleBackColor = true;
            // 
            // txt_masothue
            // 
            txt_masothue.Location = new Point(216, 103);
            txt_masothue.Name = "txt_masothue";
            txt_masothue.Size = new Size(294, 23);
            txt_masothue.TabIndex = 30;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(216, 62);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(294, 23);
            txt_tenkh.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 513);
            label12.Name = "label12";
            label12.Size = new Size(165, 15);
            label12.TabIndex = 25;
            label12.Text = "Giới hạn số ngày nợ cho phép";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 465);
            label11.Name = "label11";
            label11.Size = new Size(159, 15);
            label11.TabIndex = 24;
            label11.Text = "Giới hạn số tiền nợ cho phép";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 421);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 23;
            label10.Text = "Người liên hệ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 379);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 22;
            label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 334);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 21;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 290);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 20;
            label7.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Location = new Point(3, 246);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 19;
            label6.Text = "Là cá nhân";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 18;
            label5.Text = " Là nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 17;
            label4.Text = "Mã số thuế";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 157);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 17;
            label3.Text = "Là khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 16;
            label2.Text = "Tên khách hàng ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã khách hàng";
            // 
            // btn_cap_nhat
            // 
            btn_cap_nhat.Location = new Point(109, 562);
            btn_cap_nhat.Name = "btn_cap_nhat";
            btn_cap_nhat.Size = new Size(88, 34);
            btn_cap_nhat.TabIndex = 14;
            btn_cap_nhat.Text = "Cập nhật";
            btn_cap_nhat.UseVisualStyleBackColor = true;
            btn_cap_nhat.Click += btn_cap_nhat_Click;
            // 
            // btn_them_moi
            // 
            btn_them_moi.Location = new Point(5, 562);
            btn_them_moi.Name = "btn_them_moi";
            btn_them_moi.Size = new Size(88, 34);
            btn_them_moi.TabIndex = 13;
            btn_them_moi.Text = "Thêm mới";
            btn_them_moi.UseVisualStyleBackColor = true;
            btn_them_moi.Click += btn_them_moi_Click;
            // 
            // txt_songaychophep
            // 
            txt_songaychophep.Location = new Point(216, 505);
            txt_songaychophep.Name = "txt_songaychophep";
            txt_songaychophep.Size = new Size(294, 23);
            txt_songaychophep.TabIndex = 11;
            // 
            // txt_tiennochophep
            // 
            txt_tiennochophep.Location = new Point(216, 457);
            txt_tiennochophep.Name = "txt_tiennochophep";
            txt_tiennochophep.Size = new Size(294, 23);
            txt_tiennochophep.TabIndex = 10;
            // 
            // txt_nglienhe
            // 
            txt_nglienhe.Location = new Point(216, 413);
            txt_nglienhe.Name = "txt_nglienhe";
            txt_nglienhe.Size = new Size(294, 23);
            txt_nglienhe.TabIndex = 9;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(216, 371);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(294, 23);
            txt_diachi.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(216, 326);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(294, 23);
            txt_email.TabIndex = 7;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(216, 282);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(294, 23);
            txt_sdt.TabIndex = 6;
            // 
            // txt_makh
            // 
            txt_makh.Location = new Point(216, 17);
            txt_makh.Name = "txt_makh";
            txt_makh.Size = new Size(294, 23);
            txt_makh.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdv_khachang);
            panel2.Controls.Add(btn_xoa);
            panel2.Location = new Point(575, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 618);
            panel2.TabIndex = 1;
            // 
            // grdv_khachang
            // 
            grdv_khachang.AutoGenerateColumns = false;
            grdv_khachang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdv_khachang.Columns.AddRange(new DataGridViewColumn[] { customerIDDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, taxCodeDataGridViewTextBoxColumn, isCustomerDataGridViewCheckBoxColumn, isVendorDataGridViewCheckBoxColumn, isPersonalDataGridViewCheckBoxColumn, mobileDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactPersonDataGridViewTextBoxColumn, debtLimitDataGridViewTextBoxColumn, numberDayLimitDataGridViewTextBoxColumn });
            grdv_khachang.DataSource = khachHangBindingSource;
            grdv_khachang.Location = new Point(12, 62);
            grdv_khachang.Name = "grdv_khachang";
            grdv_khachang.RowTemplate.Height = 25;
            grdv_khachang.Size = new Size(879, 534);
            grdv_khachang.TabIndex = 1;
            grdv_khachang.CellClick += grdv_khachang_CellClick;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // taxCodeDataGridViewTextBoxColumn
            // 
            taxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode";
            taxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode";
            taxCodeDataGridViewTextBoxColumn.Name = "taxCodeDataGridViewTextBoxColumn";
            // 
            // isCustomerDataGridViewCheckBoxColumn
            // 
            isCustomerDataGridViewCheckBoxColumn.DataPropertyName = "IsCustomer";
            isCustomerDataGridViewCheckBoxColumn.HeaderText = "IsCustomer";
            isCustomerDataGridViewCheckBoxColumn.Name = "isCustomerDataGridViewCheckBoxColumn";
            // 
            // isVendorDataGridViewCheckBoxColumn
            // 
            isVendorDataGridViewCheckBoxColumn.DataPropertyName = "IsVendor";
            isVendorDataGridViewCheckBoxColumn.HeaderText = "IsVendor";
            isVendorDataGridViewCheckBoxColumn.Name = "isVendorDataGridViewCheckBoxColumn";
            // 
            // isPersonalDataGridViewCheckBoxColumn
            // 
            isPersonalDataGridViewCheckBoxColumn.DataPropertyName = "IsPersonal";
            isPersonalDataGridViewCheckBoxColumn.HeaderText = "IsPersonal";
            isPersonalDataGridViewCheckBoxColumn.Name = "isPersonalDataGridViewCheckBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            // 
            // debtLimitDataGridViewTextBoxColumn
            // 
            debtLimitDataGridViewTextBoxColumn.DataPropertyName = "DebtLimit";
            debtLimitDataGridViewTextBoxColumn.HeaderText = "DebtLimit";
            debtLimitDataGridViewTextBoxColumn.Name = "debtLimitDataGridViewTextBoxColumn";
            // 
            // numberDayLimitDataGridViewTextBoxColumn
            // 
            numberDayLimitDataGridViewTextBoxColumn.DataPropertyName = "NumberDayLimit";
            numberDayLimitDataGridViewTextBoxColumn.HeaderText = "NumberDayLimit";
            numberDayLimitDataGridViewTextBoxColumn.Name = "numberDayLimitDataGridViewTextBoxColumn";
            // 
            // khachHangBindingSource
            // 
            khachHangBindingSource.DataSource = typeof(Entities.KhachHang);
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(12, 10);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(88, 34);
            btn_xoa.TabIndex = 0;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 9);
            label13.Name = "label13";
            label13.Size = new Size(141, 37);
            label13.TabIndex = 2;
            label13.Text = "Thông tin";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(575, 9);
            label14.Name = "label14";
            label14.Size = new Size(147, 37);
            label14.TabIndex = 3;
            label14.Text = "Danh sách";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 681);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormKhachHang";
            Text = "Khách hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdv_khachang).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_cap_nhat;
        private Button btn_them_moi;
        private TextBox txt_songaychophep;
        private TextBox txt_tiennochophep;
        private TextBox txt_nglienhe;
        private TextBox txt_diachi;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txt_masothue;
        private TextBox txt_makh;
        private Panel panel2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_tenkh;
        private Label label13;
        private Label label14;
        private Button btn_xoa;
        private DataGridView grdv_khachang;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxCodeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCustomerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isVendorDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isPersonalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn debtLimitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDayLimitDataGridViewTextBoxColumn;
        private BindingSource khachHangBindingSource;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckBox ckb_la_canhan;
        private CheckBox ckb_la_nhacungcap;
        private CheckBox ckb_la_khachhang;
        private Button btn_lammoi;
        private ErrorProvider errorProvider1;
    }
}