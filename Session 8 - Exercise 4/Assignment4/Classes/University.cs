using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    class University : Institute {
        //Properties 

        public List<Student> Students = new List<Student>();
        public List<Professor> Professors = new List<Professor>();
        public List<Grade> Grades = new List<Grade>();
        public List<Schedule> Scheduledcourses = new List<Schedule>();
        public List<Course> Courses = new List<Course>();
        public University() {
            InstitudeID = Guid.NewGuid();
        }


        //Methods
        public void AddStudents(Student student) {
            Students.Add(student);
        }
        public void AddCourses(Course course) {
            Courses.Add(course);
        }
        public void AddGrades(Grade grade) {
            Grades.Add(grade);
        }
        public void AddProfessors(Professor professor) {
            Professors.Add(professor);
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