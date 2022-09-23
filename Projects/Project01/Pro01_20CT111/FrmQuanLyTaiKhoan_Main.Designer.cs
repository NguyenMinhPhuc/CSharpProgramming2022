
namespace Pro01_20CT111
{
    partial class FrmQuanLyTaiKhoan_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTaiKhoan_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNapLai = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhoMatKhau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChangedPassword = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNapLai,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnDong,
            this.btnChangedPassword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(980, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Image = global::Pro01_20CT111.Properties.Resources.refresh_16px;
            this.btnNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(92, 29);
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.ToolTipText = "Nhấn button để load lại dữ liệu";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Pro01_20CT111.Properties.Resources.plus_16px;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 29);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::Pro01_20CT111.Properties.Resources.restart_16px;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Pro01_20CT111.Properties.Resources.trash_16px;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 29);
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::Pro01_20CT111.Properties.Resources.close_window_16px;
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(78, 29);
            this.btnDong.Text = "Đóng";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colHoVaTen,
            this.colTaiKhoan,
            this.colMatKhau,
            this.colNhoMatKhau});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 32);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowTemplate.Height = 32;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(980, 407);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoVaTen.DataPropertyName = "HoVaTen";
            this.colHoVaTen.HeaderText = "Họ và tên";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.ReadOnly = true;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.DataPropertyName = "TaiKhoan";
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            this.colTaiKhoan.Width = 200;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            this.colMatKhau.Visible = false;
            // 
            // colNhoMatKhau
            // 
            this.colNhoMatKhau.DataPropertyName = "NhoMatKhau";
            this.colNhoMatKhau.FalseValue = "False";
            this.colNhoMatKhau.HeaderText = "Nhớ mật khẩu";
            this.colNhoMatKhau.Name = "colNhoMatKhau";
            this.colNhoMatKhau.ReadOnly = true;
            this.colNhoMatKhau.TrueValue = "True";
            this.colNhoMatKhau.Width = 200;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Trợ giúp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongUser,
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(980, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongUser
            // 
            this.lblTongUser.Name = "lblTongUser";
            this.lblTongUser.Size = new System.Drawing.Size(113, 17);
            this.lblTongUser.Text = "Tổng SL tài khoản: 0";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangedPassword.Image")));
            this.btnChangedPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(192, 29);
            this.btnChangedPassword.Text = "Changed Password";
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // FrmQuanLyTaiKhoan_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 461);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmQuanLyTaiKhoan_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyTaiKhoan_Main";
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNhoMatKhau;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnNapLai;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongUser;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.ToolStripButton btnChangedPassword;
    }
}