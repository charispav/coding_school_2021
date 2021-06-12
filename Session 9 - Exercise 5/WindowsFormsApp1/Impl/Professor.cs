using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {

    public class Professor : Person {
        //Properies
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }
        //Constructor
        public Professor() : base() {

        }
        //Methods
        public void Teach(Course course, DateTime datetime) {

        }
        public void SetGrade(Guid studentID, Guid courseID, int gradeValue) {
            Grade grade = new Grade() {
                StudentID = studentID,
                CourseID = courseID,
                GradeValue = gradeValue};  
        }
        public override string GetName() {
            return "Dr." + Name;

        }

    }
}
