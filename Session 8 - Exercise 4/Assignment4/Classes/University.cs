using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    class University : Institute {
        //Properties
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Grade> grades = new List<Grade>();
        List<Schedule> scheduledcourses = new List<Schedule>();
        List<Professor> professors = new List<Professor>();
        //Constructor
        public University() {
            InstitudeID = Guid.NewGuid();
        }

        //Methods
        public void AddStudents(Student student) {
            students.Add(student);
        }
        public void AddCourses(Course course) {
            courses.Add(course);
        }
        public void AddGrades(Grade grade) {
            grades.Add(grade);
        }
        public void AddProfessors(Professor professor) {
            professors.Add(professor);
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
