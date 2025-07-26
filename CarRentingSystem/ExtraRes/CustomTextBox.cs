using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentingSystem
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }
        bool isFocused = false;
        private string text = "label";
        private bool pass = false;
        public bool multiline = false;

        private Color backColor = Color.FromArgb(255,125,111,255);
        public Color foreColor = Color.Black;
        public string customText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }
        public bool customMultiline
        {
            get { return multiline; }
            set
            {
                multiline = value;
                this.Invalidate();
            }
        }
        public bool password
        {
            get { return pass; }
            set { pass = value;
                textBox1.UseSystemPasswordChar = pass;
                this.Invalidate();
            }
        }






        public Color customBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                this.Invalidate();
            }
        }
        public Color customForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                this.Invalidate();
            }
        }


        private void CustomTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = customText;

            this.BackColor = customBackColor;
            label1.BackColor = customBackColor;
            textBox1.BackColor = customBackColor;
            if (customMultiline == true)
            {
                textBox1.Multiline = true;  
                textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                textBox1.Height = this.Height;
            }


            label1.ForeColor = customForeColor;

        }
        
        private void CustomTextBox_Load(object sender, EventArgs e)
        {
            if (password == true)
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }


        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;

            if(isFocused== false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if( y<= 2)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segol UI", 7);
                    y = 0;
                    label1.ForeColor = Color.Black;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 18)
                {
                    isFocused = false;
                    labelTimer.Stop();
                    label1.Font = new Font("Segol UI", 9);
                    y = 18;
                    label1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }
        public string TextBox;


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            TextBox = textBox1.Text;
        }
        public void TogglePasswordVisibility(bool showPassword)
        {
            textBox1.UseSystemPasswordChar = !showPassword;
        }
    }
}
