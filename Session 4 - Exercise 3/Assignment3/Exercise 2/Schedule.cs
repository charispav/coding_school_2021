using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    class Schedule {
        //Properties
        public Guid ScheduleID { get; set; }
        public Guid ScheduledCourseID { get; set; }
        public Guid ScheduledCourseProfessorID { get; set; }
        public DateTime calendar { get; set; }

        //Constructor
        public Schedule() {
            ScheduleID = Guid.NewGuid();
        }
        //Methods
        //------EMPTY------
    }
}
