namespace Booking_2_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            roundedPanel1 = new HOTELMANAGE.Customs.RoundedPanel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            roundedButtonVer21 = new HOTELMANAGE.Customs.RoundedButtonVer2();
            dataGridView1 = new DataGridView();
            roundedButtonVer22 = new HOTELMANAGE.Customs.RoundedButtonVer2();
            roundedButtonVer23 = new HOTELMANAGE.Customs.RoundedButtonVer2();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewComboBoxColumn();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(dataGridView1);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Location = new Point(182, 59);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 20;
            roundedPanel1.Size = new Size(1131, 564);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Thickness = 5F;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 84);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(0, 7, 45);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(44, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 87);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 7, 45);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(44, 219);
            button2.Name = "button2";
            button2.Size = new Size(75, 87);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(0, 7, 45);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(44, 312);
            button3.Name = "button3";
            button3.Size = new Size(75, 87);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(0, 7, 45);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(44, 405);
            button4.Name = "button4";
            button4.Size = new Size(75, 87);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(0, 7, 45);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(44, 587);
            button5.Name = "button5";
            button5.Size = new Size(75, 87);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(40, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 57);
            panel1.TabIndex = 0;
            // 
            // roundedButtonVer21
            // 
            roundedButtonVer21.BackColor = Color.White;
            roundedButtonVer21.BackgroundColor = Color.White;
            roundedButtonVer21.BorderColor = Color.PaleVioletRed;
            roundedButtonVer21.BorderRadius = 7;
            roundedButtonVer21.BorderSize = 0;
            roundedButtonVer21.FlatAppearance.BorderSize = 0;
            roundedButtonVer21.FlatStyle = FlatStyle.Flat;
            roundedButtonVer21.ForeColor = Color.Black;
            roundedButtonVer21.Location = new Point(852, 647);
            roundedButtonVer21.Name = "roundedButtonVer21";
            roundedButtonVer21.Size = new Size(131, 35);
            roundedButtonVer21.TabIndex = 7;
            roundedButtonVer21.Text = "Add Booking";
            roundedButtonVer21.TextColor = Color.Black;
            roundedButtonVer21.UseVisualStyleBackColor = false;
            roundedButtonVer21.Click += roundedButtonVer21_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(3, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1128, 226);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roundedButtonVer22
            // 
            roundedButtonVer22.BackColor = Color.White;
            roundedButtonVer22.BackgroundColor = Color.White;
            roundedButtonVer22.BorderColor = Color.PaleVioletRed;
            roundedButtonVer22.BorderRadius = 7;
            roundedButtonVer22.BorderSize = 0;
            roundedButtonVer22.FlatAppearance.BorderSize = 0;
            roundedButtonVer22.FlatStyle = FlatStyle.Flat;
            roundedButtonVer22.ForeColor = Color.Black;
            roundedButtonVer22.Location = new Point(1010, 647);
            roundedButtonVer22.Name = "roundedButtonVer22";
            roundedButtonVer22.Size = new Size(131, 35);
            roundedButtonVer22.TabIndex = 8;
            roundedButtonVer22.Text = "Edit Booking";
            roundedButtonVer22.TextColor = Color.Black;
            roundedButtonVer22.UseVisualStyleBackColor = false;
            // 
            // roundedButtonVer23
            // 
            roundedButtonVer23.BackColor = Color.White;
            roundedButtonVer23.BackgroundColor = Color.White;
            roundedButtonVer23.BorderColor = Color.PaleVioletRed;
            roundedButtonVer23.BorderRadius = 7;
            roundedButtonVer23.BorderSize = 0;
            roundedButtonVer23.FlatAppearance.BorderSize = 0;
            roundedButtonVer23.FlatStyle = FlatStyle.Flat;
            roundedButtonVer23.ForeColor = Color.Black;
            roundedButtonVer23.Location = new Point(1170, 647);
            roundedButtonVer23.Name = "roundedButtonVer23";
            roundedButtonVer23.Size = new Size(131, 35);
            roundedButtonVer23.TabIndex = 9;
            roundedButtonVer23.Text = "Delete Booking";
            roundedButtonVer23.TextColor = Color.Black;
            roundedButtonVer23.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Booking ID";
            Column1.Name = "Column1";
            Column1.Width = 181;
            // 
            // Column2
            // 
            Column2.HeaderText = "Guest Name";
            Column2.Name = "Column2";
            Column2.Width = 181;
            // 
            // Column3
            // 
            Column3.HeaderText = "Room Number";
            Column3.Name = "Column3";
            Column3.Width = 181;
            // 
            // Column4
            // 
            Column4.HeaderText = "Check-In Date";
            Column4.Name = "Column4";
            Column4.Width = 181;
            // 
            // Column5
            // 
            Column5.HeaderText = "Check-In Time";
            Column5.Name = "Column5";
            Column5.Width = 181;
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 181;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 7, 45);
            ClientSize = new Size(1325, 702);
            Controls.Add(roundedButtonVer23);
            Controls.Add(roundedButtonVer22);
            Controls.Add(roundedButtonVer21);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(roundedPanel1);
            Name = "Form1";
            Text = "Form1";
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HOTELMANAGE.Customs.RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private HOTELMANAGE.Customs.RoundedButtonVer2 roundedButtonVer21;
        private DataGridView dataGridView1;
        private HOTELMANAGE.Customs.RoundedButtonVer2 roundedButtonVer22;
        private HOTELMANAGE.Customs.RoundedButtonVer2 roundedButtonVer23;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewComboBoxColumn Column6;
    }
}
