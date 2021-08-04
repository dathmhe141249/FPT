using Sp2019B5.DAL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshDvgCorporation()
        {
            dgvCorporation.DataSource = null;
            dgvCorporation.DataSource = CorDAL.getAllCorp(); // select * from

            // thay đổi tên cột cho datagridview
            dgvCorporation.Columns[1].HeaderText = "Corp No";
            dgvCorporation.Columns[2].HeaderText = "Corp Name";
            dgvCorporation.Columns[3].HeaderText = "Street";
            dgvCorporation.Columns[4].HeaderText = "Region Name";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "Select Column";
            select.HeaderText = "Select";
            select.ValueType = typeof(bool);
            dgvCorporation.Columns.Add(select);
            RefreshDvgCorporation();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Edit Colum";
            btn.HeaderText = "Edit";
            btn.Text = "Edit";
            dgvCorporation.Columns.Add(btn);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvCorporation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[5] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                this.Hide();
                string name = dgvCorporation.DataMember[2].ToString();
                FrmEdit fe = new FrmEdit();
                this.Close();
            }
        }
    }
}
