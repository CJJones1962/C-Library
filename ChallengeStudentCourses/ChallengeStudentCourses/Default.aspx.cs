using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignmentButton1_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>() {
                new Course() {CourseId = 1, Name = "English 101", Students = new List<Student>() {
                    new Student () { StudentId = 1, Name = "CJ Carr"},
                    new Student () { StudentId = 2, Name = "David Jones"},
                    new Student () { StudentId = 3, Name = "Chris Jones" }}},
                new Course() {CourseId = 2, Name = "Math 200", Students = new List<Student>() {
                    new Student () { StudentId = 4, Name = "Frank James"},
                    new Student () { StudentId = 5, Name = "Vanessa Harvey" },
                    new Student () { StudentId = 6, Name = "Andrew Pine"}}},
                new Course() {CourseId = 3, Name = "Art 102", Students = new List<Student>()  {
                    new Student () { StudentId = 7, Name = "Pam Williams"},
                    new Student () { StudentId = 8, Name = "Sam Elliot"},
                    new Student () { StudentId = 9, Name = "Dwayne Johnson"}}}

            };

            foreach (var course in courses)
            {
                resultLabel.Text += string.Format("<br />Course: {0} - {1} - {2}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format("<br />Student: {0} - {1} - {2}", student.StudentId, student.Name);
                }
            }
        }
            
        protected void assignmentButton2_Click(object sender, EventArgs e)
        {

        }

        protected void assignmentButton3_Click(object sender, EventArgs e)
        {

        }
    }
}