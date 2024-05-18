namespace SoftwareApp
{
    partial class Form14
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
            text = new Label();
            text_userid = new TextBox();
            button_purchase = new Button();
            button1 = new Button();
            dataGridView = new DataGridView();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.ForeColor = Color.Beige;
            text.Location = new Point(139, 431);
            text.Name = "text";
            text.Size = new Size(92, 27);
            text.TabIndex = 2;
            text.Text = "User ID";
            // 
            // text_userid
            // 
            text_userid.Location = new Point(264, 431);
            text_userid.Margin = new Padding(3, 4, 3, 4);
            text_userid.Name = "text_userid";
            text_userid.Size = new Size(175, 27);
            text_userid.TabIndex = 4;
            // 
            // button_purchase
            // 
            button_purchase.BackColor = Color.White;
            button_purchase.FlatAppearance.BorderColor = Color.White;
            button_purchase.FlatStyle = FlatStyle.Flat;
            button_purchase.Location = new Point(521, 552);
            button_purchase.Margin = new Padding(3, 4, 3, 4);
            button_purchase.Name = "button_purchase";
            button_purchase.Size = new Size(114, 56);
            button_purchase.TabIndex = 12;
            button_purchase.Text = "Purchase";
            button_purchase.UseVisualStyleBackColor = false;
            button_purchase.Click += button_purchase_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(264, 552);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 56);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.Beige;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(71, 45);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(736, 294);
            dataGridView.TabIndex = 14;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Teal;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(781, 522);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(71, 411);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(886, 666);
            Controls.Add(dataGridView);
            Controls.Add(button1);
            Controls.Add(button_purchase);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(text_userid);
            Controls.Add(text);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Purchase Ticket";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox text_userid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_purchase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

