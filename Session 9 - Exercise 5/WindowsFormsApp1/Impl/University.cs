using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.Impl {


    public class University : Institute {

        // PROPERTIES
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }


        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }
        


        // CONSTRUCTOR
        public University():base() {
           
        }

        //  METHODS

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
                CourseID = courseID,
                ProfessorID = professorID,
                Calendar = datetime
            };
            return schedule;
        }
        public void SetCourse() { 
        
        }


        public void AddScheduledCourse(Guid courseID, Guid professorID, DateTime callendar) {

            // Verb (Action) -> Object

            Schedule schedule = new Schedule() {
                Calendar = callendar,
                CourseID = courseID,
                ProfessorID = professorID
               
            };

            ScheduledCourses.Add(schedule);
        }

        public void UpdateScheduledCourse(Guid scheduleID, DateTime calendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);
            
            UpdateScheduledCourse(scheduleID, Guid.Empty, Guid.Empty, calendar);
        }

        public void UpdateScheduledCourse(Guid scheduleID, Guid courseID, Guid professorID, DateTime calendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);

            // update
            if (courseID != Guid.Empty) {
                schedule.CourseID = courseID;
                // todo ....
            }
            

            if (professorID != Guid.Empty) {
                schedule.ProfessorID = professorID;

                // todo ....
            }

            schedule.Calendar = calendar;

        }


        public List<Schedule> GetScheduledCourses() {


            return ScheduledCourses;
        }

    }
     
    }

