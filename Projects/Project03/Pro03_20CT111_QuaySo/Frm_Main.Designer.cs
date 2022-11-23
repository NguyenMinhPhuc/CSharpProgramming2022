
namespace Pro03_20CT111_QuaySo
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonDanhSach = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGiaiThuong = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVienNhanGiai = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaiThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnXuatFileINI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienNhanGiai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuatFileINI);
            this.panel1.Controls.Add(this.btnChonDanhSach);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.btnBatDau);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboGiaiThuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnChonDanhSach
            // 
            this.btnChonDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChonDanhSach.FlatAppearance.BorderSize = 0;
            this.btnChonDanhSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChonDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnChonDanhSach.Location = new System.Drawing.Point(984, 30);
            this.btnChonDanhSach.Name = "btnChonDanhSach";
            this.btnChonDanhSach.Size = new System.Drawing.Size(230, 37);
            this.btnChonDanhSach.TabIndex = 4;
            this.btnChonDanhSach.Text = "Chọn DS nhân viên";
            this.btnChonDanhSach.UseVisualStyleBackColor = false;
            this.btnChonDanhSach.Click += new System.EventHandler(this.btnChonDanhSach_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(596, 29);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(188, 37);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatDau.FlatAppearance.BorderSize = 0;
            this.btnBatDau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBatDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.White;
            this.btnBatDau.Location = new System.Drawing.Point(400, 29);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(188, 37);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn giải thưởng";
            // 
            // cboGiaiThuong
            // 
            this.cboGiaiThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiaiThuong.FormattingEnabled = true;
            this.cboGiaiThuong.Location = new System.Drawing.Point(15, 30);
            this.cboGiaiThuong.Name = "cboGiaiThuong";
            this.cboGiaiThuong.Size = new System.Drawing.Size(374, 37);
            this.cboGiaiThuong.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1366, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(964, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 565);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colPhongBan});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(396, 546);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Mã số";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Width = 80;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            // 
            // colPhongBan
            // 
            this.colPhongBan.DataPropertyName = "PhongBan";
            this.colPhongBan.HeaderText = "Phòng ban";
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            this.colPhongBan.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanVienNhanGiai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên trúng giải";
            // 
            // dgvNhanVienNhanGiai
            // 
            this.dgvNhanVienNhanGiai.AllowUserToAddRows = false;
            this.dgvNhanVienNhanGiai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNhanVienNhanGiai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVienNhanGiai.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVienNhanGiai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVienNhanGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVienNhanGiai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colGiaiThuong});
            this.dgvNhanVienNhanGiai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVienNhanGiai.Location = new System.Drawing.Point(3, 16);
            this.dgvNhanVienNhanGiai.Name = "dgvNhanVienNhanGiai";
            this.dgvNhanVienNhanGiai.ReadOnly = true;
            this.dgvNhanVienNhanGiai.RowHeadersVisible = false;
            this.dgvNhanVienNhanGiai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVienNhanGiai.Size = new System.Drawing.Size(958, 258);
            this.dgvNhanVienNhanGiai.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhanVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhongBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phòng ban";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // colGiaiThuong
            // 
            this.colGiaiThuong.DataPropertyName = "TenGiaiThuong";
            this.colGiaiThuong.HeaderText = "Giải thưởng";
            this.colGiaiThuong.Name = "colGiaiThuong";
            this.colGiaiThuong.ReadOnly = true;
            this.colGiaiThuong.Width = 200;
            // 
            // lblN1
            // 
            this.lblN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(33, 128);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(178, 216);
            this.lblN1.TabIndex = 4;
            this.lblN1.Text = "1";
            // 
            // lblN2
            // 
            this.lblN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(211, 128);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(178, 216);
            this.lblN2.TabIndex = 5;
            this.lblN2.Text = "2";
            // 
            // lblN4
            // 
            this.lblN4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN4.Location = new System.Drawing.Point(567, 128);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(178, 216);
            this.lblN4.TabIndex = 7;
            this.lblN4.Text = "4";
            // 
            // lblN3
            // 
            this.lblN3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(389, 128);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(178, 216);
            this.lblN3.TabIndex = 6;
            this.lblN3.Text = "3";
            // 
            // lblN5
            // 
            this.lblN5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN5.Location = new System.Drawing.Point(745, 128);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(178, 216);
            this.lblN5.TabIndex = 8;
            this.lblN5.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnXuatFileINI
            // 
            this.btnXuatFileINI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatFileINI.FlatAppearance.BorderSize = 0;
            this.btnXuatFileINI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXuatFileINI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileINI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileINI.ForeColor = System.Drawing.Color.White;
            this.btnXuatFileINI.Location = new System.Drawing.Point(790, 30);
            this.btnXuatFileINI.Name = "btnXuatFileINI";
            this.btnXuatFileINI.Size = new System.Drawing.Size(188, 37);
            this.btnXuatFileINI.TabIndex = 5;
            this.btnXuatFileINI.Text = "Xuất INI";
            this.btnXuatFileINI.UseVisualStyleBackColor = false;
            this.btnXuatFileINI.Click += new System.EventHandler(this.btnXuatFileINI_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 681);
            this.Controls.Add(this.lblN5);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienNhanGiai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Button btnChonDanhSach;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGiaiThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridView dgvNhanVienNhanGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaiThuong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnXuatFileINI;
    }
}

