using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    public partial class MdiMainForm : Form {

        //Properties
        private const string _JsonFile = "UniversityData.json";
        University CodingSchool = new University();


        //Constructor
        public MdiMainForm() {
            InitializeComponent();
        }
        //Methods
        private void MdiMainForm_Load(object sender, EventArgs e) {

        }
        private void AddStudent() {

            Student student = new Student();
            StudentForm form = new StudentForm();
            form.NewStudent = student;
            DialogResult result = form.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Students.Add(student);
                    break;

                default:
                    MessageBox.Show("Student has not been added!");
                    break;
            }
        }
        private void AddCourse() {
            Course course = new Course();
            CourseForm courseForm = new CourseForm();
            courseForm.NewCourse = course;
            DialogResult result = courseForm.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Courses.Add(course);
                    break;

                default:
                    MessageBox.Show("Course has not been added!");
                    break;
            }
        }

        private void AddProfessor() {

            Professor professor = new Professor();
            ProfessorForm professorForm = new ProfessorForm();
            professorForm.NewProfessor = professor;
            DialogResult result = professorForm.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Professors.Add(professor);
                    break;

                default:
                    MessageBox.Show("Professor has not been added!");
                    break;
            }
        }
        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = serializer.Serialize(CodingSchool);
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }


        private void DeserializeFromJson() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);

                    CodingSchool = serializer.Deserialize<University>(data);
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }


    }
}
