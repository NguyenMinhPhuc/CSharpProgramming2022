
using System.Drawing;

namespace Pro2_20CT111
{
    partial class Frm_TestComponents
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
            this.myColorTextBox1 = new Pro2_20CT111.MyComponents.MyColorTextBox();
            this.myColorTextBox2 = new Pro2_20CT111.MyComponents.MyColorTextBox();
            this.myNumberTextBox1 = new Pro2_20CT111.MyComponents.MyNumberTextBox(this.components);
            this.btnInt = new System.Windows.Forms.Button();
            this.cricleButton1 = new MyLibraryUI.CricleButton();
            this.SuspendLayout();
            // 
            // myColorTextBox1
            // 
            this.myColorTextBox1.BackColorMyTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myColorTextBox1.Font = new System.Drawing.Font("Arial", 18F);
            this.myColorTextBox1.Location = new System.Drawing.Point(29, 29);
            this.myColorTextBox1.Name = "myColorTextBox1";
            this.myColorTextBox1.Size = new System.Drawing.Size(521, 35);
            this.myColorTextBox1.TabIndex = 0;
            // 
            // myColorTextBox2
            // 
            this.myColorTextBox2.BackColorMyTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myColorTextBox2.Font = new System.Drawing.Font("Arial", 18F);
            this.myColorTextBox2.Location = new System.Drawing.Point(29, 95);
            this.myColorTextBox2.Name = "myColorTextBox2";
            this.myColorTextBox2.Size = new System.Drawing.Size(521, 35);
            this.myColorTextBox2.TabIndex = 1;
            // 
            // myNumberTextBox1
            // 
            this.myNumberTextBox1.BackColorMyTextBox = System.Drawing.Color.Lime;
            this.myNumberTextBox1.Font = new System.Drawing.Font("Arial", 18F);
            this.myNumberTextBox1.Location = new System.Drawing.Point(29, 150);
            this.myNumberTextBox1.Name = "myNumberTextBox1";
            this.myNumberTextBox1.Size = new System.Drawing.Size(521, 35);
            this.myNumberTextBox1.TabIndex = 2;
            this.myNumberTextBox1.Text = "0";
            this.myNumberTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(437, 213);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 23);
            this.btnInt.TabIndex = 3;
            this.btnInt.Text = "INt";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // cricleButton1
            // 
            this.cricleButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cricleButton1.BorderRadius = 65;
            this.cricleButton1.BorderSize = 0;
            this.cricleButton1.FlatAppearance.BorderSize = 0;
            this.cricleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cricleButton1.ForeColor = System.Drawing.Color.White;
            this.cricleButton1.Location = new System.Drawing.Point(606, 255);
            this.cricleButton1.Name = "cricleButton1";
            this.cricleButton1.Size = new System.Drawing.Size(130, 130);
            this.cricleButton1.TabIndex = 4;
            this.cricleButton1.Text = "cricleButton1";
            this.cricleButton1.TextColor = System.Drawing.Color.White;
            this.cricleButton1.UseVisualStyleBackColor = false;
            // 
            // Frm_TestComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cricleButton1);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.myNumberTextBox1);
            this.Controls.Add(this.myColorTextBox2);
            this.Controls.Add(this.myColorTextBox1);
            this.Name = "Frm_TestComponents";
            this.Text = "Frm_TestComponents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyComponents.MyColorTextBox myColorTextBox1;
        private MyComponents.MyColorTextBox myColorTextBox2;
        private MyComponents.MyNumberTextBox myNumberTextBox1;
        private System.Windows.Forms.Button btnInt;
        private MyLibraryUI.CricleButton cricleButton1;
    }
}