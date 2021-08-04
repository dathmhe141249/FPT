using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2_SU20
{
    public partial class TeachingSchedule : Form
    {
        public TeachingSchedule()
        {
            InitializeComponent();
        }

        private void TeachingSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                cbbCourseCode.DataSource = DAO.getAllCourse();
                cbbCourseCode.DisplayMember = "CourseCode";
                cbbCourseCode.ValueMember = "CourseId";
                cbbCourseCode.SelectedIndex = 0;
                lbRoom.DataSource = DAO.getAllRoom();
                lbRoom.DisplayMember = "RoomCode";
                lbRoom.ValueMember = "RoomId";
                lbRoom.SelectedIndex = 0;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(cbbCourseCode.SelectedValue.ToString());
                int slot = Convert.ToInt32(nUDSlot.Value.ToString());
                int roomID = Convert.ToInt32(lbRoom.SelectedValue.ToString());
                string des = txtDes.Text.ToString();
                DateTime date = DateTime.Parse(dtpDate.Value.ToString());
                if(!(des.Trim().Length == 0))
                {
                    ArrayList list = new ArrayList
                    {
                        courseID,date,slot,roomID,des
                    };
                    int count = 0;
                    count = DAO.AddCourseSchedule(list);
                    if(count > 0)
                    {
                        MessageBox.Show("Add successfully");
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Add Failed");
                    }
                }
                else { MessageBox.Show("Description Can not be blank"); }
               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        public void Refresh()
        {
            cbbCourseCode.SelectedIndex = 0;
            lbRoom.SelectedIndex = 0;
            nUDSlot.Value = 1;
            txtDes.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }
    }
}
