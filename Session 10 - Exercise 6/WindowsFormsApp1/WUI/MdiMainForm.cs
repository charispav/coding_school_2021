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


        private const string _LogFile = "Log.txt";
        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";

        // ..
        private University CodingSchool; // = new University(); 

        public MdiMainForm() {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {

            MainForm f = new MainForm();

            f.MdiParent = this;

            f.Show();

        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) {

            AddStudent();


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
                    // messagge  ?
                    break;
            }
        }


        private void AddCourse() {
            Course course = new Course();

            CourseForm form = new CourseForm();
            form.NewCourse = course;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Courses.Add(course);
                    break;

                default:
                    // messagge  ?
                    break;
            }
        }


        private void AddEntity() { 
        
            //TODO: OPEN FORM BY ENTITY TYPE (COURSE, STUDENT, PROFESSOR) 
        
        }

        private void MdiMainForm_Load(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // TODO: SERIALIZE UNIVERSITY OBJECT INSTEAD OF STUDENTS!
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

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;


            viewForm.ViewData = GetStudentList();

            viewForm.Show();
        }


        private List<string> GetStudentList() {

            List<string> studentList = new List<string>(); 

            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {

       
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


                //MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return studentList;
        }


        private List<string> GetCoursesList() {

            List<string> coursesList = new List<string>();

            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {


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


                //MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return coursesList;
        }

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e) {
            AddCourse();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;


            viewForm.ViewData = GetCoursesList();

            viewForm.Show();
        }
    }
}
