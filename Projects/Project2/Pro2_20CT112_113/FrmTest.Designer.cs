
namespace Pro2_20CT112_113
{
    partial class FrmTest
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
            this.cricleButton1 = new MyLibraryUI.CricleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cricleButton1
            // 
            this.cricleButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cricleButton1.BorderRadius = 50;
            this.cricleButton1.BorderSize = 0;
            this.cricleButton1.FlatAppearance.BorderSize = 0;
            this.cricleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cricleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cricleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cricleButton1.ForeColor = System.Drawing.Color.White;
            this.cricleButton1.Location = new System.Drawing.Point(600, 163);
            this.cricleButton1.Name = "cricleButton1";
            this.cricleButton1.Size = new System.Drawing.Size(100, 100);
            this.cricleButton1.TabIndex = 0;
            this.cricleButton1.TextColor = System.Drawing.Color.White;
            this.cricleButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 218);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(111, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 327);
            this.panel1.TabIndex = 2;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cricleButton1);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyLibraryUI.CricleButton cricleButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}