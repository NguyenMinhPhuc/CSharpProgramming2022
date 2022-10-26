
namespace Pro2_20CT111.MyComponents
{
    partial class MyNumberTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cricleButton1 = new MyLibraryUI.CricleButton();
            this.SuspendLayout();
            // 
            // cricleButton1
            // 
            this.cricleButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cricleButton1.BorderRadius = 10;
            this.cricleButton1.BorderSize = 0;
            this.cricleButton1.FlatAppearance.BorderSize = 0;
            this.cricleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cricleButton1.ForeColor = System.Drawing.Color.White;
            this.cricleButton1.Location = new System.Drawing.Point(0, 0);
            this.cricleButton1.Name = "cricleButton1";
            this.cricleButton1.Size = new System.Drawing.Size(150, 40);
            this.cricleButton1.TabIndex = 0;
            this.cricleButton1.Text = "cricleButton1";
            this.cricleButton1.TextColor = System.Drawing.Color.White;
            this.cricleButton1.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }

        #endregion

        private MyLibraryUI.CricleButton cricleButton1;
    }
}
