namespace CarRentingSystem
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CrossBtn = new System.Windows.Forms.PictureBox();
            this.hidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.hidePanel.Controls.Add(this.progressPanel);
            this.hidePanel.Controls.Add(this.label2);
            this.hidePanel.Location = new System.Drawing.Point(0, 278);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(600, 22);
            this.hidePanel.TabIndex = 0;
            this.hidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(242)))));
            this.progressPanel.Location = new System.Drawing.Point(0, 0);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(122, 22);
            this.progressPanel.TabIndex = 1;
            this.progressPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 5.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(224, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created By  Team  Ro@r";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CrossBtn
            // 
            this.CrossBtn.BackColor = System.Drawing.Color.Transparent;
            this.CrossBtn.BackgroundImage = global::CarRentingSystem.Properties.Resources.logo2;
            this.CrossBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrossBtn.Location = new System.Drawing.Point(579, 1);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(20, 20);
            this.CrossBtn.TabIndex = 4;
            this.CrossBtn.TabStop = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::CarRentingSystem.Properties.Resources.load;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.hidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.hidePanel.ResumeLayout(false);
            this.hidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CrossBtn;
        private System.Windows.Forms.Timer timer1;
    }
}