using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public class Professor : Person {

        //Properties
        public string Rank { get; set; }
        List<Course> professorCourses = new List<Course>();

        //Constructor
        public Professor() {
            PersonID = Guid.NewGuid();
        }

        //Methods
        public void Teach(Course course, DateTime datetime) {

        }
        public Grade SetGrade(Grade gradeObj, Guid studentID, Guid courseID, int gradeValue) {
            gradeObj.StudentID = studentID;
            gradeObj.CourseID = courseID;
            gradeObj.GradeValue = gradeValue;
            return gradeObj;
        }
        public override string GetName() {
            return "Dr." + Name;

        }

    }
}
