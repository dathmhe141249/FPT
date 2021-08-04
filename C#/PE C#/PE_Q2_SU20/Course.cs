using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_Q2_SU20
{
    class Course
    {
        int courseID;
        string courseCode;
        string courseDes;
        int subjectID;
        int instructorID;
        int termID;
        int campusID;

        public Course()
        {
        }

        public Course(int courseID, string courseCode, string courseDes, int subjectID, int instructorID, int termID, int campusID)
        {
            this.CourseID = courseID;
            this.CourseCode = courseCode;
            this.CourseDes = courseDes;
            this.SubjectID = subjectID;
            this.InstructorID = instructorID;
            this.TermID = termID;
            this.CampusID = campusID;
        }

        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseDes { get => courseDes; set => courseDes = value; }
        public int SubjectID { get => subjectID; set => subjectID = value; }
        public int InstructorID { get => instructorID; set => instructorID = value; }
        public int TermID { get => termID; set => termID = value; }
        public int CampusID { get => campusID; set => campusID = value; }
    }
}
