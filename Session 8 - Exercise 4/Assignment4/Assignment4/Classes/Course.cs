using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public class Course {
        //Properties
        public Guid CourseID { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }

        //Constructor
        public Course() {
            CourseID = Guid.NewGuid();
        }

        //Methods

        //--------EMPTY---------
    }
}
