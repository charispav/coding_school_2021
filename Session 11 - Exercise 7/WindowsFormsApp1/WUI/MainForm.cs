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

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {


        private const string _LogFile = "Log.txt";
        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";

        // ..
        private University CodingSchool; // = new University(); 

        //List<Student> Students = new List<Student>();
        //List<Course> Courses = new List<Course>();
        //List<Professor> Professors  = new List<Professor>();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            //MessageBox.Show("Hello World!");
        }

        private void button4_Click(object sender, EventArgs e) {

            // Add student using a form
            //AddStudent();

            // refresh
            RefreshStudentList();
        }

        private void ctrlExit_Click(object sender, EventArgs e) {


            Application.Exit();
        }

        private void ctrlSave_Click(object sender, EventArgs e) {

            // Write ...
            WriteToTxt();
        }

        private void ctrlLoad_Click(object sender, EventArgs e) {

            // Read data
            ReadFromTxt();

            // refresh
            RefreshStudentList();
        }

        //private void AddStudent() {
        //    Student student = new Student();
        //    // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

        //    // TODO: OPEN FORM ...
        //    StudentForm form = new StudentForm();
        //    form.NewStudent = student;

        //    DialogResult result = form.ShowDialog();
        //    switch (result) {
        //        case DialogResult.OK:
        //            CodingSchool.Students.Add(student);
        //            break;

        //        default:
        //            // messagge  ?
        //            break;
        //    }
        //}

        private void WriteToTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string data = string.Empty;
            foreach (Student item in CodingSchool.Students) {

                data += string.Format("{0};{1};{2};{3}", item.Name, item.Surname, item.RegistrationNumber, Environment.NewLine);
            }


            File.WriteAllText(path, data);
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


           

            

            //CodingSchool.Students = Students;

            //Course physics = new Course() {
            //    Subject = "Physics",
            //    Category = CoursesCategoryEnum.Physics,
            //    Hours = 10
            //};

            //Students[0].Courses = new List<Course>();
            //Students[0].Courses.Add(physics);
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

                    CodingSchool.Students.Add(student);

                }
            }
        }

        private void RefreshStudentList() {
            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {

                    ctrlStudentList.Items.Clear();
                    foreach (Student item in CodingSchool.Students) {

                        ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2}", item.Name, item.Surname, item.RegistrationNumber));
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
            
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void ctrlDeserialize_Click(object sender, EventArgs e) {
            DeserializeFromJson();

            RefreshStudentList();
        }

        private void button2_Click(object sender, EventArgs e) {
            CodingSchool = new University(); 
        }
    }
}
