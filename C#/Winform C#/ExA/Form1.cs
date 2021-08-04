using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "HE141249";
            string a = textBox1.Text + "\n RGB()" + textBox1.BackColor.ToArgb().ToString();
            MessageBox.Show(a);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = textBox1.BackColor;
            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = txtLabel.Text;
            if (btn.Text == String.Empty)
            {
                MessageBox.Show("Label of the button cannot be blank");
            }
            else {
                btn.BackColor = textBox1.BackColor;
                pnlShow.Controls.Add(btn);
                btn.Click +=  myButton_Click;
            }
            
        }
        void myButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "\n RGB(" +textBox1.BackColor.R +","+ textBox1.BackColor.G+"," + textBox1.BackColor.B+")");
            this.Close();
        }
    }
}
