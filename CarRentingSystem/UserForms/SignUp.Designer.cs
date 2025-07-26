namespace CarRentingSystem
{
    partial class SignUp
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
            this.userPass = new CarRentingSystem.CustomTextBox();
            this.PhoneNo = new CarRentingSystem.CustomTextBox();
            this.emailAdd = new CarRentingSystem.CustomTextBox();
            this.FullName = new CarRentingSystem.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SignUpBtn = new CustomControls.RJControls.CusButton();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.backBtn = new CustomControls.RJControls.CusButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.userName = new CarRentingSystem.CustomTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // userPass
            // 
            this.userPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.userPass.customBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.userPass.customForeColor = System.Drawing.Color.Black;
            this.userPass.customMultiline = false;
            this.userPass.customText = "Password";
            this.userPass.Location = new System.Drawing.Point(163, 248);
            this.userPass.Name = "userPass";
            this.userPass.password = true;
            this.userPass.Size = new System.Drawing.Size(185, 35);
            this.userPass.TabIndex = 3;
            // 
            // PhoneNo
            // 
            this.PhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.PhoneNo.customBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.PhoneNo.customForeColor = System.Drawing.Color.Black;
            this.PhoneNo.customMultiline = false;
            this.PhoneNo.customText = "Phone No";
            this.PhoneNo.Location = new System.Drawing.Point(163, 164);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.password = false;
            this.PhoneNo.Size = new System.Drawing.Size(185, 35);
            this.PhoneNo.TabIndex = 2;
            // 
            // emailAdd
            // 
            this.emailAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.emailAdd.customBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.emailAdd.customForeColor = System.Drawing.Color.Black;
            this.emailAdd.customMultiline = false;
            this.emailAdd.customText = "Email Address";
            this.emailAdd.Location = new System.Drawing.Point(163, 124);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.password = false;
            this.emailAdd.Size = new System.Drawing.Size(185, 35);
            this.emailAdd.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.FullName.customBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.FullName.customForeColor = System.Drawing.Color.Black;
            this.FullName.customMultiline = false;
            this.FullName.customText = "Full Name";
            this.FullName.Location = new System.Drawing.Point(163, 84);
            this.FullName.Name = "FullName";
            this.FullName.password = false;
            this.FullName.Size = new System.Drawing.Size(185, 35);
            this.FullName.TabIndex = 0;
            this.FullName.Load += new System.EventHandler(this.FullName_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(172, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox2.Location = new System.Drawing.Point(172, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(172, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox4.Location = new System.Drawing.Point(172, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 1);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.BorderColor = System.Drawing.Color.White;
            this.SignUpBtn.BorderRadius = 15;
            this.SignUpBtn.BorderSize = 1;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Black;
            this.SignUpBtn.Location = new System.Drawing.Point(270, 306);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(105, 30);
            this.SignUpBtn.TabIndex = 8;
            this.SignUpBtn.Text = "Create ->";
            this.SignUpBtn.TextColor = System.Drawing.Color.Black;
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.ShowPass.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.Location = new System.Drawing.Point(269, 290);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(86, 16);
            this.ShowPass.TabIndex = 9;
            this.ShowPass.Text = "Show password";
            this.ShowPass.UseVisualStyleBackColor = false;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BorderColor = System.Drawing.Color.White;
            this.backBtn.BorderRadius = 15;
            this.backBtn.BorderSize = 1;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(152, 306);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 30);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "<- Back";
            this.backBtn.TextColor = System.Drawing.Color.Black;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox5.Location = new System.Drawing.Point(172, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(178, 1);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.userName.customBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.userName.customForeColor = System.Drawing.Color.Black;
            this.userName.customMultiline = false;
            this.userName.customText = "Username";
            this.userName.Location = new System.Drawing.Point(163, 206);
            this.userName.Name = "userName";
            this.userName.password = false;
            this.userName.Size = new System.Drawing.Size(185, 35);
            this.userName.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::CarRentingSystem.Properties.Resources.logo2;
            this.pictureBox6.Location = new System.Drawing.Point(551, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentingSystem.Properties.Resources.signup2;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox FullName;
        private CustomTextBox emailAdd;
        private CustomTextBox PhoneNo;
        private CustomTextBox userPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomControls.RJControls.CusButton SignUpBtn;
        private System.Windows.Forms.CheckBox ShowPass;
        private CustomControls.RJControls.CusButton backBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomTextBox userName;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}