using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2_PE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbAuthor.SelectedItem);
            DialogResult m = MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                int count = BookDAL.DeleteAuthor(id);
                if (count > 0)
                {
                    MessageBox.Show("Delete Successfully");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
            else { }
        }

        private void cbbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbbBook.SelectedValue.ToString());
            cbbYear.DataSource = BookDAL.getAllBookByTitle(id);
            cbbYear.DisplayMember = "Year";
            cbbYear.ValueMember = "Year";

            lbAuthor.DataSource = BookDAL.getAllAuthorByBookID(id);
            lbAuthor.DisplayMember = "Name";
            lbAuthor.ValueMember = "ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbBook.DataSource = BookDAL.getAllBook();
            cbbBook.DisplayMember = "Title";
            cbbBook.ValueMember = "ID";

            List<int> year = new List<int>();
            year.Add(2000);
            year.Add(2001);
            year.Add(2002);
            year.Add(2003);
            year.Add(2004);
            year.Add(2005);
            year.Add(2006);
            year.Add(2007);
            year.Add(2008);
            year.Add(2009);
            year.Add(2010);
            cbbYear.DataSource = year;
        }
    }
}
