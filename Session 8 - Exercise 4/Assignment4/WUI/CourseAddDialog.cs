using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4 {
    public partial class CourseAddDialog : Form {
        
        
        //Constructor
        public CourseAddDialog() {
            InitializeComponent();
           
        }

        //Methods
        private void CourseAddDialog_Load(object sender, EventArgs e) {

        }
        private void ctrlOKButton_Click(object sender, EventArgs e) {
            if (ctrlCourseCodeEdit.Text != String.Empty && ctrlCourseSubjectEdit.Text != String.Empty) {
                Course course = new Course() {
                    CourseName = ctrlCourseCodeEdit.Text,
                    Subject = ctrlCourseSubjectEdit.Text
                };
                University university  = new University();
                university.AddCourses(course);
                Close();
            }
            else {
                Close();
            }
        }
        private void ctrlCancelButton_Click(object sender, EventArgs e) {
            Close();
        }
       
        private void ctrlCourseCodeEdit_EditValueChanged(object sender, EventArgs e) {

        }
        
        private void ctrlCourseSubjectEdit_EditValueChanged(object sender, EventArgs e) {

        }

    }
}
