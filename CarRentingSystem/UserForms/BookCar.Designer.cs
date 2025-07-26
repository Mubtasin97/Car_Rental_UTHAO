namespace CarRentingSystem.UserForms
{
    partial class BookCar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProceedBtn = new CustomControls.RJControls.CusButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarRentingSystem.Properties.Resources.BookCar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi,";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameText.Location = new System.Drawing.Point(329, 11);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(96, 21);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "NameLevel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(431, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book a car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(351, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pick a date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(351, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Car type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(351, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Duration :";
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.ProceedBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.ProceedBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.ProceedBtn.BorderRadius = 15;
            this.ProceedBtn.BorderSize = 0;
            this.ProceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProceedBtn.FlatAppearance.BorderSize = 0;
            this.ProceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedBtn.ForeColor = System.Drawing.Color.Black;
            this.ProceedBtn.Location = new System.Drawing.Point(459, 300);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(88, 35);
            this.ProceedBtn.TabIndex = 11;
            this.ProceedBtn.Text = "Proceed";
            this.ProceedBtn.TextColor = System.Drawing.Color.Black;
            this.ProceedBtn.UseVisualStyleBackColor = false;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dhaka",
            "Faridpur",
            "Gazipur",
            "Gopalganj",
            "Jamalpur",
            "Kishoreganj",
            "Madaripur",
            "Manikganj",
            "Munshiganj",
            "Mymensingh",
            "Narayanganj",
            "Narsingdi",
            "Netrokona",
            "Rajbari",
            "Shariatpur",
            "Sherpur",
            "Tangail                         ",
            "Bogra                              ",
            "Joypurhat                         ",
            "Naogaon                      ",
            "Natore                             ",
            "Nawabganj                          ",
            "Pabna                              ",
            "Rajshahi                         ",
            "Sirajgonj                           ",
            "Dinajpur                           ",
            "Gaibandha                          ",
            "Kurigram                           ",
            "Lalmonirhat                        ",
            "Nilphamari                         ",
            "Panchagarh                         ",
            "Rangpur                            ",
            "Thakurgaon                         ",
            "Barguna                       ",
            "Barisal                       ",
            "Bhola                              ",
            "Jhalokati                          ",
            "Patuakhali                         ",
            "Pirojpur                          ",
            "Bandarban                          ",
            "Brahmanbaria                       ",
            "Chandpur                           ",
            "Chittagong                         ",
            "Comilla                            ",
            "Cox\'\'s Bazar                       ",
            "Feni                               ",
            "Khagrachari                        ",
            "Lakshmipur                         ",
            "Noakhali                           ",
            "Rangamati                          ",
            "Habiganj                           ",
            "Maulvibazar                        ",
            "Sunamganj                          ",
            "Sylhet                             ",
            "Bagerhat                           ",
            "Chuadanga                          ",
            "Jessore                            ",
            "Jhenaidah                          ",
            "Khulna                             ",
            "Kushtia                             ",
            "Magura                             ",
            "Meherpur                           ",
            "Narail                             ",
            "Satkhira"});
            this.comboBox1.Location = new System.Drawing.Point(432, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dhaka",
            "Faridpur",
            "Gazipur",
            "Gopalganj",
            "Jamalpur",
            "Kishoreganj",
            "Madaripur",
            "Manikganj",
            "Munshiganj",
            "Mymensingh",
            "Narayanganj",
            "Narsingdi",
            "Netrokona",
            "Rajbari",
            "Shariatpur",
            "Sherpur",
            "Tangail                         ",
            "Bogra                              ",
            "Joypurhat                         ",
            "Naogaon                      ",
            "Natore                             ",
            "Nawabganj                          ",
            "Pabna                              ",
            "Rajshahi                         ",
            "Sirajgonj                           ",
            "Dinajpur                           ",
            "Gaibandha                          ",
            "Kurigram                           ",
            "Lalmonirhat                        ",
            "Nilphamari                         ",
            "Panchagarh                         ",
            "Rangpur                            ",
            "Thakurgaon                         ",
            "Barguna                       ",
            "Barisal                       ",
            "Bhola                              ",
            "Jhalokati                          ",
            "Patuakhali                         ",
            "Pirojpur                          ",
            "Bandarban                          ",
            "Brahmanbaria                       ",
            "Chandpur                           ",
            "Chittagong                         ",
            "Comilla                            ",
            "Cox\'\'s Bazar                       ",
            "Feni                               ",
            "Khagrachari                        ",
            "Lakshmipur                         ",
            "Noakhali                           ",
            "Rangamati                          ",
            "Habiganj                           ",
            "Maulvibazar                        ",
            "Sunamganj                          ",
            "Sylhet                             ",
            "Bagerhat                           ",
            "Chuadanga                          ",
            "Jessore                            ",
            "Jhenaidah                          ",
            "Khulna                             ",
            "Kushtia                             ",
            "Magura                             ",
            "Meherpur                           ",
            "Narail                             ",
            "Satkhira"});
            this.comboBox2.Location = new System.Drawing.Point(432, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2024, 9, 25, 21, 38, 49, 0);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hiace",
            "Private Car",
            "Mini Hiace"});
            this.comboBox3.Location = new System.Drawing.Point(432, 213);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(171, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days",
            "4 Days",
            "5 Days",
            "6 Days",
            "7 Days",
            "8 Days",
            "9 Days",
            "10 Days"});
            this.comboBox4.Location = new System.Drawing.Point(432, 253);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(171, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "<";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // BookCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.CusButton ProceedBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}