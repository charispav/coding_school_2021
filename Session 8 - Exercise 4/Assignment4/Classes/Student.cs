using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public class Student : Person {

        //Properties
        public int RegistrationNumber { get; set; }
        List<Course> studentrCourses = new List<Course>();

        //Constructor
        public Student() {
            PersonID = Guid.NewGuid();
        }

        //Methods
        public void Attend(Course course, DateTime datetime) {


        }
        public void WriteExam(Course course, DateTime datetime) {


        }
    }
}
