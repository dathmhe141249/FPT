using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
namespace WindowsFormsApp1
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            RefreshDvgProduct();
        }
        private void RefreshDvgProduct()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = Product.GetProducts();

            // thay đổi tên cột cho datagridview
           
        }
    }
}
