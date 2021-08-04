using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class FrmCategories : Form
    {
        //xd trạng thái lưu cho thêm mới hay lưu cho update vào Category
        private bool statusAdd = false;

        public FrmCategories()
        {
            InitializeComponent();
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnSave.Enabled = true;
            txtCatid.Enabled = true;
            txtCatid.Text = String.Empty;
            txtCatName.Enabled = true;
            txtCatName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtDescription.Enabled = true;
            statusAdd = true;
            txtCatid.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu từ textbox
            string name = txtCatName.Text.Trim();
            string id = txtCatid.Text.Trim();
            string desc = txtDescription.Text.Trim();
            DataTable checkID = Category.GetCategoriesByID(id);
            ArrayList arrayList = new ArrayList() {
                new Category(){
                CatID1 = id,
                CatName1 = name,
                Desc = desc,
                }
            };
            if(statusAdd == true)
            {
                //thực hiện thêm mới vào category
                if (!ValidCate())
                {
                    return;
                }
                else
                {
                    if (checkID.Rows.Count > 0)
                    {
                        MessageBox.Show("ID existed");
                    }
                    else {
                        Category.AddCateGories(arrayList);
                        MessageBox.Show("ADD SUCCESSFULLY!");
                        dataGridView1.DataSource = Category.GetCategories();
                        txtCatid.Text = string.Empty;
                        txtCatName.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        txtCatid.Focus();
                    }
                }
            }
            else
            {
                // thực hiện update
                /*if (checkID.Rows.Count > 0)
                {
                    MessageBox.Show("ID existed");
                }*/
               /* else
                {*/
                    Category.UpdateCateGories(arrayList);
                    MessageBox.Show("Save SUCCESSFULLY!");
                    dataGridView1.DataSource = Category.GetCategories();
                    txtCatid.Text = String.Empty;
                    txtCatName.Text = String.Empty;
                    txtDescription.Text = String.Empty;
                    txtCatid.Focus();
                /*}*/
            }
        }
        private bool ValidCate()
        {
            string name = txtCatName.Text.Trim();
            string id = txtCatid.Text.Trim();
            Regex regex = new Regex(@"^(C([0-9]){4})$");
            if (name.Length == 0)
            {
                MessageBox.Show("Name must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatName.Focus();
                return false;
            }
            else if (!regex.IsMatch(id))
            {
                MessageBox.Show("Invalid ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatid.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();

            // bổ sung cột checkbox để xóa nhiều
            select.Name = "Select Column";
            select.HeaderText = "Choice";
            select.ValueType = typeof(bool);
            dataGridView1.Columns.Add(select);
            //Load data từ bảng
            RefreshDvgCategory();

            BtnDelete.Enabled = false;
            BtnSave.Enabled = false;
            txtCatid.Enabled = false;
            txtCatName.Enabled = false;
            txtDescription.Enabled = false;
            statusAdd = false;
        }

        private void RefreshDvgCategory()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Category.GetCategories();

            // thay đổi tên cột cho datagridview
            dataGridView1.Columns[1].HeaderText = "Mã danh mục";
            dataGridView1.Columns[2].HeaderText = "Tên danh mục";
            dataGridView1.Columns[3].HeaderText = "Mô tả chi tiết";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length != 0)
            {
                //tìm thấy
                if (Category.GetCategoriesByName(txtSearch.Text.Trim()).Count > 0) {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Category.GetCategoriesByName(txtSearch.Text.Trim());
                }
                else {
                    MessageBox.Show("Not Existed!");
                }
            }
            else
            {
                MessageBox.Show("Enter name!");
                RefreshDvgCategory();
                txtSearch.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusAdd = false;
          if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtCatid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtCatName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                
                txtCatid.Enabled = false;
                txtCatName.Enabled = true;
                txtDescription.Enabled = true;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
            }
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCatid.Text.Trim();
            ArrayList list = new ArrayList();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                bool selected = Convert.ToBoolean(r.Cells[0].Value);
                if (selected)
                {
                    list.Add(Convert.ToString(r.Cells[1].Value));
                }
            }
            DialogResult m = MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                Category.DeleteCateGories(id);
                Category.DeleteListCateGoriesByID(list);
                dataGridView1.DataSource = Category.GetCategories();
                txtCatid.Text = String.Empty;
                txtCatName.Text = String.Empty;
                txtDescription.Text = String.Empty;
                txtCatid.Focus();
            }
            else if (m == DialogResult.Cancel)
            {

            }
           
                RefreshDvgCategory();
        }
    }
}
