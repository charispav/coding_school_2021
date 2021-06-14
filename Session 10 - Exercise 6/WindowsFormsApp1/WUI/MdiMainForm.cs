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
        private const string _LogFile = "Log.json";
        University CodingSchool = new University();


        //Constructor
        public MdiMainForm() {
            InitializeComponent();
        }
        //Methods
        private void MdiMainForm_Load(object sender, EventArgs e) {

        }


        // Insert (New) Entities:
        private void studentToolStripMenuItem_Click(object sender, EventArgs e) {

            AddStudent();  
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e) {

            AddProfessor();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e) {

            AddCourse();
        }


        // View Entities
        private void studentToolStripMenuItem2_Click(object sender, EventArgs e) {

            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;
            viewForm.ViewData = GetStudentList();
            viewForm.Show();
        }
        private void professorToolStripMenuItem2_Click(object sender, EventArgs e) {

            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;
            viewForm.ViewData = GetProfessorList();
            viewForm.Show();
        }

        private void courseToolStripMenuItem2_Click(object sender, EventArgs e) {

            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;
            viewForm.ViewData = GetCoursesList();
            viewForm.Show();
        }

        private List<string> GetStudentList() {

            List<string> studentList = new List<string>();

            try {

                if (CodingSchool?.Students != null) {


                    foreach (Student item in CodingSchool.Students) {

                        studentList.Add(string.Format("Name={0} \t Surname={1} \t RegistrationNumber={2}", item.Name, item.Surname, item.RegistrationNumber));
                    }
                }
                else {
                    MessageBox.Show("No student data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return studentList;
        }
        private List<string> GetProfessorList() {
            List<string> professorlist = new List<string>();

            try {

                if (CodingSchool?.Professors != null) {

                    foreach (Professor item in CodingSchool.Professors) {

                        professorlist.Add(string.Format("Name={0} \t Surname={1} \t Rank={2}", item.Name, item.Surname, item.Rank));
                    }
                }
                else {
                    MessageBox.Show("No professor data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return professorlist;
        }

        private List<string> GetCoursesList() {

            List<string> coursesList = new List<string>();

            try {

                if (CodingSchool?.Courses != null) {

                    foreach (Course item in CodingSchool.Courses) {

                        coursesList.Add(string.Format("Code={0} \t Subject={1} ", item.Code, item.Subject));
                    }
                }
                else {
                    MessageBox.Show("No course data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return coursesList;
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

    }
}


