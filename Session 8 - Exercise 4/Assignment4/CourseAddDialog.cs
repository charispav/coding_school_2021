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
        public CourseAddDialog() {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
           
        }

        private void textEdit2_TextChanged(object sender, EventArgs e) {
         
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textEdit1.Text != String.Empty && textEdit2.Text != String.Empty) { 
            Course course = new Course() {
                CourseName = textEdit1.Text,
                Subject = textEdit2.Text
            };
            University university = new University();
            university.AddCourses(course);
            this.Close();
            }
            else {
                this.Close();
            }
        }

        private void CourseAddDialog_Load(object sender, EventArgs e) {

        }

        private void textEdit1_TextChanged_1(object sender, EventArgs e) {

        }
    }
}
