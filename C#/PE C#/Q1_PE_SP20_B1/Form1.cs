using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q1_PE_SP20_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbCountry.DisplayMember = "Country";
            lbCountry.ValueMember = "Country";
            dtpDate.Value = new DateTime(2020, 3, 23);
            lbCountry.DataSource = DAO.getAllCountry();
            lbCountry.ClearSelected();
            lbCountry.SelectedValue = "China";

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            dgvCase.DataSource = DAO.GetCountryByDate(date);
        }

        private void lbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd"));
                //ArrayList array = new ArrayList();
                string filter = "";
                if (lbCountry.SelectedItem != null)
                {
                    foreach (DataRowView data in lbCountry.SelectedItems)
                    {
                        if (filter != "")
                        {
                            filter += " or ";
                        }
                        filter += "Country like '%" + data[0].ToString() + "%'";
                    }
                }
                else
                {
                    filter += "Country like '%%'";
                }

                dgvCase.DataSource = DAO.getInfo(filter, date);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
