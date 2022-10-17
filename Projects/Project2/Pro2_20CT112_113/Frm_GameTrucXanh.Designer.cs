
namespace Pro2_20CT112_113
{
    partial class Frm_GameTrucXanh
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
            this.btnMaTran2 = new System.Windows.Forms.Button();
            this.btnMaTran4 = new System.Windows.Forms.Button();
            this.btnMaTran6 = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaTran2
            // 
            this.btnMaTran2.Location = new System.Drawing.Point(26, 47);
            this.btnMaTran2.Margin = new System.Windows.Forms.Padding(7);
            this.btnMaTran2.Name = "btnMaTran2";
            this.btnMaTran2.Size = new System.Drawing.Size(175, 51);
            this.btnMaTran2.TabIndex = 0;
            this.btnMaTran2.Text = "2 x 2";
            this.btnMaTran2.UseVisualStyleBackColor = true;
            this.btnMaTran2.Click += new System.EventHandler(this.btnMaTran2_Click);
            // 
            // btnMaTran4
            // 
            this.btnMaTran4.Location = new System.Drawing.Point(215, 47);
            this.btnMaTran4.Margin = new System.Windows.Forms.Padding(7);
            this.btnMaTran4.Name = "btnMaTran4";
            this.btnMaTran4.Size = new System.Drawing.Size(175, 51);
            this.btnMaTran4.TabIndex = 1;
            this.btnMaTran4.Text = "4 x 4";
            this.btnMaTran4.UseVisualStyleBackColor = true;
            this.btnMaTran4.Click += new System.EventHandler(this.btnMaTran4_Click);
            // 
            // btnMaTran6
            // 
            this.btnMaTran6.Location = new System.Drawing.Point(404, 47);
            this.btnMaTran6.Margin = new System.Windows.Forms.Padding(7);
            this.btnMaTran6.Name = "btnMaTran6";
            this.btnMaTran6.Size = new System.Drawing.Size(175, 51);
            this.btnMaTran6.TabIndex = 2;
            this.btnMaTran6.Text = "6 x 6";
            this.btnMaTran6.UseVisualStyleBackColor = true;
            this.btnMaTran6.Click += new System.EventHandler(this.btnMaTran6_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 123);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1634, 629);
            this.pnlContainer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMaTran2);
            this.groupBox1.Controls.Add(this.btnMaTran4);
            this.groupBox1.Controls.Add(this.btnMaTran6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1634, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Frm_GameTrucXanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 752);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Frm_GameTrucXanh";
            this.Text = "Frm_GameTrucXanh";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaTran2;
        private System.Windows.Forms.Button btnMaTran4;
        private System.Windows.Forms.Button btnMaTran6;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}