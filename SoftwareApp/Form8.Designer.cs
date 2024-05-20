namespace SoftwareApp
{
    partial class Form8
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
            textBox1 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            button4 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(156, 169);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Sponsor About ...";
            textBox1.Size = new Size(280, 142);
            textBox1.TabIndex = 68;
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
            button3.Location = new Point(433, -4);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(33, 39);
            button3.TabIndex = 67;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(18, 169);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 66;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(18, 120);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 65;
            label1.Text = "Name:";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(99, 122);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Sponsor Name:";
            textBox6.Size = new Size(337, 30);
            textBox6.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 22);
            label8.Name = "label8";
            label8.Size = new Size(345, 36);
            label8.TabIndex = 63;
            label8.Text = "Add A New Sponsor";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Beige;
            button4.Location = new Point(117, 338);
            button4.Name = "button4";
            button4.Size = new Size(213, 47);
            button4.TabIndex = 69;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 71;
            label3.Text = "Select Event:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 26);
            comboBox1.TabIndex = 70;
            comboBox1.Tag = "";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(13F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(463, 411);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Teal;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SET TICKET";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private Label label8;
        private Button button4;
        private Label label3;
        private ComboBox comboBox1;
    }
}