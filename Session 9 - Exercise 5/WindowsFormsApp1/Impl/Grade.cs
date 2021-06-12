using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Grade : Entity {
        //Properties
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }

        public Grade() : base() {

        }
    }

}
