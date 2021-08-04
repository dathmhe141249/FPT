using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q1_SP20_B1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCountry.DisplayMember = "Country";
            cbbCountry.ValueMember = "Country";
            cbbCountry.DataSource = DAO.getAllCountry();
            cbbCountry.SelectedValue = "World";
            string country = cbbCountry.SelectedValue.ToString();
            dtpFrom.Value = DateTime.Parse("01-21-2020");
            DateTime fr = dtpFrom.Value.Date;
            dtpTo.Value = DateTime.Parse("03-23-2020");
            DateTime to = dtpTo.Value.Date;
            dgvShow.DataSource = DAO.getAllDataByCountryAndDate(country,fr,to);
        }

        private void cbbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string country = cbbCountry.SelectedValue.ToString();
                DateTime fr = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                dgvShow.DataSource = DAO.getAllDataByCountryAndDate(country, fr, to);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string country = cbbCountry.SelectedValue.ToString();
                DateTime fr = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                dgvShow.DataSource = DAO.getAllDataByCountryAndDate(country, fr, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string country = cbbCountry.SelectedValue.ToString();
                DateTime fr = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                dgvShow.DataSource = DAO.getAllDataByCountryAndDate(country, fr, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
