using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PE_Q2_SU20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbSubject.DataSource = DAL.getAllSubject();
            cbbSubject.DisplayMember = "SubjectName";
            cbbSubject.ValueMember = "SubjectId";
            lbInstructor.DataSource = DAL.getAllInstructorWithFullName();
            lbInstructor.DisplayMember = "fullname";
            lbInstructor.ValueMember = "InstructorId";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try {
                Regex regex = new Regex(@"^(a-zA-z0-9-+)$");
                string code = txtCourseCode.Text.ToString();
                string des = txtDes.Text.ToString();
                int subjectID = Convert.ToInt32(cbbSubject.SelectedValue.ToString());
                int instructorID = Convert.ToInt32(lbInstructor.SelectedValue.ToString());
                if (code.Trim().Length != 0 && des.Trim().Length != 0)
                {
                    if (regex.IsMatch(code))
                    {
                        ArrayList arrayList = new ArrayList
                    {
                        code,des,subjectID,instructorID
                    };
                        int count = DAL.CreateCourse(arrayList);
                        if(count > 0)
                        {
                            MessageBox.Show("add succesfully");
                        }
                        else
                        {
                            MessageBox.Show("add failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Code");
                    }
                }
                else
                {
                    MessageBox.Show("Data can not be empty");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
