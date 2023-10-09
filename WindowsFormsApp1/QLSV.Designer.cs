namespace WindowsFormsApp1
{
    partial class QLSV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHT,
            this.ColumnMSSV,
            this.ColumnGT,
            this.ColumnNgaySinh,
            this.ColumnNoiSinh,
            this.ColumnKhoa,
            this.ColumnSDT,
            this.ColumnEmail});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnHT
            // 
            this.ColumnHT.HeaderText = "Họ tên";
            this.ColumnHT.Name = "ColumnHT";
            // 
            // ColumnMSSV
            // 
            this.ColumnMSSV.HeaderText = "Mã số sinh viên";
            this.ColumnMSSV.Name = "ColumnMSSV";
            // 
            // ColumnGT
            // 
            this.ColumnGT.HeaderText = "Giới tính";
            this.ColumnGT.Name = "ColumnGT";
            // 
            // ColumnNgaySinh
            // 
            this.ColumnNgaySinh.HeaderText = "Ngày sinh";
            this.ColumnNgaySinh.Name = "ColumnNgaySinh";
            // 
            // ColumnNoiSinh
            // 
            this.ColumnNoiSinh.HeaderText = "Nơi sinh";
            this.ColumnNoiSinh.Name = "ColumnNoiSinh";
            // 
            // ColumnKhoa
            // 
            this.ColumnKhoa.HeaderText = "Khoa";
            this.ColumnKhoa.Name = "ColumnKhoa";
            // 
            // ColumnSDT
            // 
            this.ColumnSDT.HeaderText = "Số điện thoại";
            this.ColumnSDT.Name = "ColumnSDT";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(508, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(589, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(670, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLSV";
            this.Text = "QuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button1;
    }
}