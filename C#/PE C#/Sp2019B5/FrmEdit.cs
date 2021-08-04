using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sp2019B5
{
    public partial class FrmEdit : Form
    {
        int id;
        string name;

        public FrmEdit()
        {
            InitializeComponent();
        }

        public FrmEdit(int corpno, string txtName) : this()
        {
            id = corpno;
            name = txtName;
        }
        private void FrmEdit_Load(object sender, EventArgs e)
        {
           
        }
    }
}
