
namespace Pro2_20CT112_113
{
    partial class Frm_Chuong06_BaiTap01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnPhatSinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongNut = new System.Windows.Forms.TextBox();
            this.txtSoLuongNutTrenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.txtSoLuongNutTrenHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoLuongNut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPhatSinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1425, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tham số đầu vào";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 135);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1425, 612);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnPhatSinh
            // 
            this.btnPhatSinh.Location = new System.Drawing.Point(715, 45);
            this.btnPhatSinh.Name = "btnPhatSinh";
            this.btnPhatSinh.Size = new System.Drawing.Size(142, 76);
            this.btnPhatSinh.TabIndex = 0;
            this.btnPhatSinh.Text = "Phát sinh";
            this.btnPhatSinh.UseVisualStyleBackColor = true;
            this.btnPhatSinh.Click += new System.EventHandler(this.btnPhatSinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng button:";
            // 
            // txtSoLuongNut
            // 
            this.txtSoLuongNut.Location = new System.Drawing.Point(266, 45);
            this.txtSoLuongNut.Name = "txtSoLuongNut";
            this.txtSoLuongNut.Size = new System.Drawing.Size(443, 35);
            this.txtSoLuongNut.TabIndex = 2;
            this.txtSoLuongNut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuongNut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNut_KeyPress);
            // 
            // txtSoLuongNutTrenHang
            // 
            this.txtSoLuongNutTrenHang.Location = new System.Drawing.Point(266, 86);
            this.txtSoLuongNutTrenHang.Name = "txtSoLuongNutTrenHang";
            this.txtSoLuongNutTrenHang.Size = new System.Drawing.Size(443, 35);
            this.txtSoLuongNutTrenHang.TabIndex = 4;
            this.txtSoLuongNutTrenHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuongNutTrenHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNutTrenHang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số button trên hàng:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(715, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(13, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Frm_Chuong06_BaiTap01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 747);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_Chuong06_BaiTap01";
            this.Text = "Frm_Chuong06_BaiTap01";
            this.Load += new System.EventHandler(this.Frm_Chuong06_BaiTap01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuongNutTrenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuongNut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhatSinh;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}