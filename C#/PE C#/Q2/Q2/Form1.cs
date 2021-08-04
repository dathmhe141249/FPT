using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            txtID.Text = "HE141249";
        }

        ColorDialog color = new ColorDialog();
        private void btnChoose_Click(object sender, EventArgs e)
        {
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = txtColor.BackColor;
            if(color.ShowDialog() == DialogResult.OK)
            {
                txtColor.BackColor = color.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.BackColor = txtColor.BackColor;
            string name = txtname.Text.Trim();
            if(name.Length <= 0)
            {
                MessageBox.Show("Label cannot be empty");
            }
            else
            {
                btn.Text = txtname.Text;
                panelBtn.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Text +"\nColor:RBG("+ b.BackColor.R+"," + b.BackColor.B+"," + b.BackColor.G+")");
        }
    }
}
