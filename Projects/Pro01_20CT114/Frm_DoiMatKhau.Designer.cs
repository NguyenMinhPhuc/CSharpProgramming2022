
namespace Pro01_20CT114
{
    partial class Frm_DoiMatKhau
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
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetMatKhau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gbAdmin.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnResetMatKhau);
            this.gbAdmin.Controls.Add(this.label1);
            this.gbAdmin.Controls.Add(this.cboUser);
            this.gbAdmin.Location = new System.Drawing.Point(26, 34);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(764, 142);
            this.gbAdmin.TabIndex = 0;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnCapNhat);
            this.gbUser.Controls.Add(this.txtMatKhau2);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.txtMatKhau1);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Location = new System.Drawing.Point(26, 182);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(764, 200);
            this.gbUser.TabIndex = 1;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // cboUser
            // 
            this.cboUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(33, 71);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(507, 37);
            this.cboUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách User:";
            // 
            // btnResetMatKhau
            // 
            this.btnResetMatKhau.Location = new System.Drawing.Point(547, 71);
            this.btnResetMatKhau.Name = "btnResetMatKhau";
            this.btnResetMatKhau.Size = new System.Drawing.Size(205, 37);
            this.btnResetMatKhau.TabIndex = 2;
            this.btnResetMatKhau.Text = "Tạo lại mật khẩu";
            this.btnResetMatKhau.UseVisualStyleBackColor = true;
            this.btnResetMatKhau.Click += new System.EventHandler(this.btnResetMatKhau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.Location = new System.Drawing.Point(33, 67);
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.Size = new System.Drawing.Size(507, 35);
            this.txtMatKhau1.TabIndex = 1;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(33, 143);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Size = new System.Drawing.Size(507, 35);
            this.txtMatKhau2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lập lại mật khẩu:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(547, 67);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(205, 111);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Đổi mật khẩu";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 398);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnResetMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.Label label2;
    }
}