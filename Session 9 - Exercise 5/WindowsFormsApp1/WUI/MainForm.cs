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
using WindowsFormsApp1.WUI;
namespace WindowsFormsApp1 {

    public partial class MainForm : Form {


        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";

        University CodingSchool = new University(); 

        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Professor> Professors  = new List<Professor>();
        List<Grade> Grades = new List<Grade>();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void ctrlAddStudent_Click(object sender, EventArgs e) {

            // Add student using a form
            AddStudent();

            // refresh
            RefreshStudentList();
            CodingSchool.Students = Students;
        }

        private void ctrlAddCourse_Click(object sender, EventArgs e) {

            //Add course using a form
            AddCourse();
            CodingSchool.Courses = Courses;
        }

        private void ctrlAddProfessor_Click(object sender, EventArgs e) {
            AddProfessor();
            CodingSchool.Professors = Professors;
        }
        private void ctrlExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #region Txt Read/Write
        private void ctrlSave_Click(object sender, EventArgs e) {

            // Write ...
            WriteToTxt();
        }
        private void ReadFromTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string s = File.ReadAllText(path);

            string[] parser = new string[] { Environment.NewLine };

            List<string> dataLines = s.Split(parser, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string line in dataLines) {

                string[] parserLine = new string[] { ";" };

                if (line.Length > 0) {

                    List<string> lineData = line.Split(parserLine, StringSplitOptions.None).ToList();

                    Student student = new Student();

                    student.Name = Convert.ToString(lineData[0]);
                    student.Surname = Convert.ToString(lineData[1]);
                    student.RegistrationNumber = Convert.ToInt32(lineData[2]);

                    Students.Add(student);

                }
            }
        }
        private void ctrlLoad_Click(object sender, EventArgs e) {

            // Read data
            ReadFromTxt();

            // refresh
            RefreshStudentList();
        }

        private void WriteToTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string data = string.Empty;
            foreach (Student item in Students) {

                data += string.Format("{0};{1};{2};{3}", item.Name, item.Surname, item.RegistrationNumber, Environment.NewLine);
            }


            File.WriteAllText(path, data);
        }
        #endregion

        private void AddStudent() {
            
            Student student = new Student();
            StudentForm form = new StudentForm();
            form.NewStudent = student;
            DialogResult result = form.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    Students.Add(student);
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
                    Courses.Add(course);
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
                    Professors.Add(professor);
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

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            string data = File.ReadAllText(path);

            CodingSchool = serializer.Deserialize<University>(data);

        }

        

        private void RefreshStudentList() {
            ctrlStudentList.Items.Clear();
            foreach (Student item in Students) {

                ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2}", item.Name, item.Surname, item.RegistrationNumber));
            }
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void ctrlDeserialize_Click(object sender, EventArgs e) {
            DeserializeFromJson();

            //RefreshStudentList();
        }

    }
}
