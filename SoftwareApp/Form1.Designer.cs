namespace SoftwareApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(57, 204);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 0;
            label1.Text = "Event Ticketing System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 493);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Beige;
            button1.Location = new Point(118, 426);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 2;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(77, 392);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 1;
            label2.Text = "Don't have an account ?";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(454, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email:";
            textBox1.Size = new Size(331, 30);
            textBox1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(417, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(418, 201);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(414, 154);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 6;
            label3.Text = "Login Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(476, 44);
            label5.Name = "label5";
            label5.Size = new Size(253, 34);
            label5.TabIndex = 8;
            label5.Text = "Welcome, User";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(454, 254);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Password:";
            textBox3.Size = new Size(331, 30);
            textBox3.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Beige;
            button2.Location = new Point(525, 316);
            button2.Name = "button2";
            button2.Size = new Size(153, 42);
            button2.TabIndex = 4;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Verdana", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 64, 64);
            checkBox1.Location = new Point(660, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 20);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Beige;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 64, 64);
            button3.Location = new Point(781, -3);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(44, 41);
            button3.TabIndex = 11;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(820, 483);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label5;
        private TextBox textBox3;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
    }
}