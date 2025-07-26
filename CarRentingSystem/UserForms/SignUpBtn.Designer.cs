namespace CarRentingSystem.UserForms
{
    partial class SignUpBtn
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
            this.cusButton1 = new CustomControls.RJControls.CusButton();
            this.cusButton2 = new CustomControls.RJControls.CusButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cusButton1
            // 
            this.cusButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton1.BorderRadius = 10;
            this.cusButton1.BorderSize = 0;
            this.cusButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusButton1.FlatAppearance.BorderSize = 0;
            this.cusButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusButton1.ForeColor = System.Drawing.Color.Black;
            this.cusButton1.Location = new System.Drawing.Point(76, 130);
            this.cusButton1.Name = "cusButton1";
            this.cusButton1.Size = new System.Drawing.Size(100, 100);
            this.cusButton1.TabIndex = 0;
            this.cusButton1.Text = "Customer";
            this.cusButton1.TextColor = System.Drawing.Color.Black;
            this.cusButton1.UseVisualStyleBackColor = false;
            this.cusButton1.Click += new System.EventHandler(this.cusButton1_Click);
            // 
            // cusButton2
            // 
            this.cusButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(212)))));
            this.cusButton2.BorderRadius = 10;
            this.cusButton2.BorderSize = 0;
            this.cusButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusButton2.FlatAppearance.BorderSize = 0;
            this.cusButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusButton2.ForeColor = System.Drawing.Color.Black;
            this.cusButton2.Location = new System.Drawing.Point(223, 130);
            this.cusButton2.Name = "cusButton2";
            this.cusButton2.Size = new System.Drawing.Size(100, 100);
            this.cusButton2.TabIndex = 1;
            this.cusButton2.Text = "Driver";
            this.cusButton2.TextColor = System.Drawing.Color.Black;
            this.cusButton2.UseVisualStyleBackColor = false;
            this.cusButton2.Click += new System.EventHandler(this.cusButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you a..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CarRentingSystem.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(376, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "<<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SignUpBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentingSystem.Properties.Resources.SignUpBtn;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusButton2);
            this.Controls.Add(this.cusButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpBtn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpBtn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.CusButton cusButton1;
        private CustomControls.RJControls.CusButton cusButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}