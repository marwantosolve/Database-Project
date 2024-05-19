namespace SoftwareApp
{
    partial class Form10
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
            button3 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button3.Location = new Point(497, -4);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(38, 39);
            button3.TabIndex = 13;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(62, 65);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 73;
            label3.Text = "Select Report:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(216, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 26);
            comboBox1.TabIndex = 72;
            comboBox1.Tag = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(118, 9);
            label8.Name = "label8";
            label8.Size = new Size(311, 36);
            label8.TabIndex = 74;
            label8.Text = "Generate Reports";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Teal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(535, 292);
            dataGridView1.TabIndex = 75;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Beige;
            button2.Location = new Point(189, 109);
            button2.Name = "button2";
            button2.Size = new Size(163, 31);
            button2.TabIndex = 76;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(530, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private ComboBox comboBox1;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}