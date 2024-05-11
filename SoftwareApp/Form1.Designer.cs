namespace SoftwareApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Button1
            //
            this.Button1.Text = "Log In";
            this.Button1.Location = new System.Drawing.Point(160, 60);
            this.Button1.Size = new System.Drawing.Size(150, 70);
            this.Button1.TabIndex = 1;
            //
            // Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Text = "Welcome to our Event Tickting System";
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(-4, 8);
            this.Label4.Size = new System.Drawing.Size(472, 35);
            this.Label4.TabIndex = 4;
            //
            // Button6
            //
            this.Button6.Text = "Update Details";
            this.Button6.Location = new System.Drawing.Point(160, 220);
            this.Button6.Size = new System.Drawing.Size(150, 70);
            this.Button6.TabIndex = 6;
            //
            // Button7
            //
            this.Button7.Text = "Sign Up";
            this.Button7.Location = new System.Drawing.Point(160, 140);
            this.Button7.Size = new System.Drawing.Size(150, 70);
            this.Button7.TabIndex = 7;
            //
            // form
            //
            this.Size = new System.Drawing.Size(480, 352);
            this.Text = "Welcome Form";
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
    }
}

