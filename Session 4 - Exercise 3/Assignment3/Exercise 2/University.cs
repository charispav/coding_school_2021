using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    class University : Institute {
        //Properties
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Grade> grades = new List<Grade>();
        List<Schedule> scheduledcourses = new List<Schedule>();

        //Constructor
        public University() {
            InstitudeID = Guid.NewGuid();
        }

        //Methods
        public void GetStudents(Student student) {
            students.Add(student);
        }
        public void GetCourses(Course course) {
            courses.Add(course);
        }
        public void GetGrades(Grade grade) {
            grades.Add(grade);
        }
        public Schedule SetSchedule(Guid courseID, Guid professorID, DateTime datetime) {
            Schedule schedule = new Schedule() {
                ScheduledCourseID = courseID,
                ScheduledCourseProfessorID = professorID,
                calendar = datetime
            };
            return schedule;
        }
    }
}
