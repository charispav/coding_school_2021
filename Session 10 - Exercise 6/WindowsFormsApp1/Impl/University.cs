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
        public List<object> Tclass { get;  set; }


        // CONSTRUCTOR
        public University():base() {
           
        }

        //  METHODS

        public Schedule SetSchedule(Guid courseID, Guid professorID, DateTime datetime) {
            Schedule schedule = new Schedule() {
                CourseID = courseID,
                ProfessorID = professorID,
                Calendar = datetime
            };
            return schedule;
        }
        public void AddScheduledCourse(Guid courseID, Guid professorID, DateTime calendar) {

            // Verb (Action) -> Object

            Schedule schedule = new Schedule() {
                Calendar = calendar,
                CourseID = courseID,
                ProfessorID = professorID
               
            };

            ScheduledCourses.Add(schedule);
        }
        public List<Student> GetStudents() {

            return Students;
        }
        public List<Course> GetCourses() {

            return Courses;
        }
        public List<Professor> GetProfessors() {

            return Professors;
        }
        public List<Grade> GetGrades() {

            return Grades;
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

    }
     
    }

