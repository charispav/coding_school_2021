using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;


namespace WindowsFormsApp1.Impl {

    public class Schedule : Entity {


        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // CONSTRUCTOR
        public Schedule()
            : base() {

        }
    }
}
