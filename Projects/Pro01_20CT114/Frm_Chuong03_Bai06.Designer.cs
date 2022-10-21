
namespace Pro01_20CT114
{
    partial class Frm_Chuong03_Bai06
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
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.lbHoaDon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnHuyHet = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnThucHienLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 29;
            this.lbMenu.Location = new System.Drawing.Point(12, 100);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(484, 352);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Click += new System.EventHandler(this.lbMenu_Click);
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.FormattingEnabled = true;
            this.lbHoaDon.ItemHeight = 29;
            this.lbHoaDon.Location = new System.Drawing.Point(676, 100);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(484, 352);
            this.lbHoaDon.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(548, 100);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(73, 58);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(548, 164);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 58);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "<";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChonHet
            // 
            this.btnChonHet.Location = new System.Drawing.Point(548, 228);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(73, 58);
            this.btnChonHet.TabIndex = 4;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click);
            // 
            // btnHuyHet
            // 
            this.btnHuyHet.Location = new System.Drawing.Point(548, 292);
            this.btnHuyHet.Name = "btnHuyHet";
            this.btnHuyHet.Size = new System.Drawing.Size(73, 58);
            this.btnHuyHet.TabIndex = 5;
            this.btnHuyHet.Text = "<<";
            this.btnHuyHet.UseVisualStyleBackColor = true;
            this.btnHuyHet.Click += new System.EventHandler(this.btnHuyHet_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(676, 471);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(260, 29);
            this.lblThanhTien.TabIndex = 6;
            this.lblThanhTien.Text = "Tổng thành tiền: 0 VND";
            // 
            // btnThucHienLai
            // 
            this.btnThucHienLai.Location = new System.Drawing.Point(676, 516);
            this.btnThucHienLai.Name = "btnThucHienLai";
            this.btnThucHienLai.Size = new System.Drawing.Size(255, 38);
            this.btnThucHienLai.TabIndex = 7;
            this.btnThucHienLai.Text = "Thực hiện lại";
            this.btnThucHienLai.UseVisualStyleBackColor = true;
            this.btnThucHienLai.Click += new System.EventHandler(this.btnThucHienLai_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1193, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ QUÁN ĂN   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Chuong03_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThucHienLai);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btnHuyHet);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbHoaDon);
            this.Controls.Add(this.lbMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_Chuong03_Bai06";
            this.Text = "Frm_Chuong03_Bai06";
            this.Load += new System.EventHandler(this.Frm_Chuong03_Bai06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.ListBox lbHoaDon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnHuyHet;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnThucHienLai;
        private System.Windows.Forms.Label label1;
    }
}