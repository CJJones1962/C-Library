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
        private IEnumerable<object> enrollment;

        public IEnumerable<object> Grade { get; private set; }

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
                resultLabel.Text += String.Format("<br />Course: {0} - {1} ", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br />Student: {0} - {1} ", student.StudentId, student.Name);
                }
            }
        }
            
        protected void assignmentButton2_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId = 1, Name = "Algebra 3" };
            Course course2 = new Course() { CourseId = 2, Name = "Accounting" };
            Course course3 = new Course() { CourseId = 3, Name = "Psychology" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student { StudentId = 1, Name = "CJ Carr", Courses = new List<Course> {course1, course2, course3 }}},
                {2, new Student { StudentId = 2, Name = "David Jones", Courses = new List<Course> {course1, course3 }}},
                {3, new Student { StudentId = 8, Name = "Sam Elliot", Courses = new List<Course> {course2, course3 }}}
            };
            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br />Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br />Course:  {0} - {1}", course.CourseId, course.Name);
                }
            }
                
        }


        protected void assignmentButton3_Click(object sender, EventArgs e)
        {

            Student student = new Student();
            student.StudentId = 10;
            student.Name = "CJ Carr";
            student.Enrollment = new List<Enrollment>() {
                new Enrollment {Grade = 100, Course = new Course {CourseId = 1, Name = "Physical Science 101" }},
                new Enrollment {Grade = 97, Course = new Course {CourseId = 2, Name = "Health 101" }}
            };

            resultLabel.Text += String.Format("<br /> Student: {0} - {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollment)
                
                
            {
                resultLabel.Text += String.Format("<br /> Enrolled In: {0} - Grade:  {1}", enrollment.Course.Name, enrollment.Grade);
            }
            
        }
    }
}