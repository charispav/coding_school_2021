using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public class Grade {
        //Properties
        public Guid GradeID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }
        //Constructor
        public Grade() {
            GradeID = Guid.NewGuid();
        }
        //Methods

        //--------EMPTY---------
    }
}
