using EFApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFApp.WUI {
    public partial class EditForm : Form {

        public object EditObject { get; set; }
        public string _TypeOfClass { get; set; }
        public EditForm() {

            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {
            switch (_TypeOfClass) {
                case nameof(Student):
                    Student student = EditObject as Student;
                    this.Text = "New Student Form";
                    label5.Text = "Add New Student";
                    label1.Text = "Name:";
                    label2.Text = "Surname:";
                    label3.Text = "Date of Birth:";
                    label4.Text = "Address";
                    break;

                case nameof(Course):
                    Course course = EditObject as Course;
                    this.Text = "New Course Form";
                    label5.Text = "Add New Course";
                    label1.Text = "Title:";
                    label2.Text = "Category:";
                    label3.Text = "Date:";
                    label4.Text = "Duration:";
                    break;
                default:
                    break;
            }

        }

        private void btnOK_Click(object sender, EventArgs e) {
            switch (_TypeOfClass) {
                case nameof(Student):
                    Student student = EditObject as Student;
                    student.Name = textBox1.Text;
                    student.Surname = textBox2.Text;
                    student.BirthDate = Convert.ToDateTime(dateTimePicker1.Value);
                    student.Address = textBox4.Text;
                    break;

                case nameof(Course):
                    Course course = EditObject as Course;
                    course.Title = textBox1.Text;
                    course.Category = textBox2.Text;
                    course.Date = Convert.ToDateTime(dateTimePicker1.Value);
                    course.Duration = Convert.ToInt32(textBox4.Text);

                    break;
                default:
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
