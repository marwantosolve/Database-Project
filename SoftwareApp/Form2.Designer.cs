namespace SoftwareApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button3 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
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
            button3.Location = new Point(330, -3);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(44, 41);
            button3.TabIndex = 12;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(59, 45);
            label3.Name = "label3";
            label3.Size = new Size(256, 25);
            label3.TabIndex = 13;
            label3.Text = "Create a new Account";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Verdana", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 64, 64);
            checkBox1.Location = new Point(219, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 20);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(59, 251);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Password:";
            textBox3.Size = new Size(290, 30);
            textBox3.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(59, 199);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email:";
            textBox1.Size = new Size(290, 30);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(59, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Full Name:";
            textBox2.Size = new Size(290, 30);
            textBox2.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(59, 98);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "ID:";
            textBox4.Size = new Size(290, 30);
            textBox4.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 98);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
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
            button2.Location = new Point(101, 334);
            button2.Name = "button2";
            button2.Size = new Size(153, 42);
            button2.TabIndex = 23;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(369, 409);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button3);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Button button2;
    }
}