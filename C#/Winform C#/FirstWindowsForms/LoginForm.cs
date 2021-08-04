using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// khai bao lam viec voi DB
using System.Data.SqlClient;
using System.Configuration;
namespace FirstWindowsForms
{
    public partial class LoginForm : Form
    {
        //phương thức tạo đối tượng kết nối với csdl
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            return new SqlConnection(strCon);
        }

        // phương thức trả về datatable chưa dữ liệu về câu truy vấn

        public DataTable getAccount(string user, string pass)
        {
            //mo hinh: disconnected
            string sql = "select* from Account11 where Username = '"+user+"' and Password = '"+pass+"'";
            // khai bao doi tuong command để thực thi lệnh sql
            SqlCommand cmd = new SqlCommand(sql,GetConnection());
            // doi tuong cầu nối
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // tương đương resultSet
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool ValidAccount()
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPassword.Text.Trim();
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.]+)$");
            if (user == "" || pass == "")
                return false;
                //ktra có sqlinjection ko
          if(!regex.IsMatch(user) || !regex.IsMatch(pass))
                return false;
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //y/c
            //username, pass ko rỗng
            // loại bỏ cú phép sqlinjection
            //ktra  sự tồn tại của account dưới DB
            // điều hướng tới form main, đồng thời đóng form login
            // tbao lỗi 1,2
            string user = txtUserName.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (ValidAccount())
            {
                // ktra su ton tai cua user pass trong DB
                if(getAccount(user,pass).Rows.Count >0 )
                {
                    //điều hướng tới Form Main,đồng thời đóng form login
                    this.Hide(); // ẩn tạm thời, trạng thái vẫn active
                    new FrmMain().ShowDialog();
                    this.Close();//đóng login
                }else
                {
                    MessageBox.Show("Account is not existed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus(); // đưa về vtri ta mong muốn

                }
            }
            else
            {
                MessageBox.Show("Invalid Account!","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUserName.Focus();

            }
        }
    }
}
