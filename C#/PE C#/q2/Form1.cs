using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cbbBook.DisplayMember = "Title";
                cbbBook.ValueMember = "ID";
                cbbYear.SelectedIndex = default;
                cbbBook.DataSource = BookDAL.getAllBook();
                
                int id = Convert.ToInt32(cbbBook.SelectedValue.ToString());
                lbAuthor.DataSource = BookDAL.getAllAuthorByBookID(id);
                lbAuthor.DisplayMember = "Name";
                lbAuthor.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cbbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbbBook.SelectedValue);
                cbbYear.DataSource = BookDAL.getAllBookByTitle(id);
                cbbYear.DisplayMember = "Year";
                cbbYear.ValueMember = "Year";

                lbAuthor.DataSource = BookDAL.getAllAuthorByBookID(id);
                lbAuthor.DisplayMember = "Name";
                lbAuthor.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbAuthor.SelectedValue.ToString());
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
    }
}
