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
        public University CodingSchool; // = new University(); 

        public MdiMainForm() {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {

            MainForm f = new MainForm();

            f.MdiParent = this;

            f.Show();

        }

        private void MdiMainForm_Load(object sender, EventArgs e) {
            
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




        public List<string> GetStudentList() {

            List<string> studentList = new List<string>(); 

            try {

                if (CodingSchool?.Students != null) { 

       
                    foreach (Student item in CodingSchool.Students) {

                        studentList.Add(string.Format("ID = {0} \t Name = {1} \t Surname = {2} \t RegistrationNumber = {3}",
                            item.ID, item.Name, item.Surname, item.RegistrationNumber));
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


        public List<string> GetCoursesList() {

            List<string> coursesList = new List<string>();

            try {

                if (CodingSchool?.Courses != null) { 


                    foreach (Course item in CodingSchool.Courses) {

                        coursesList.Add(string.Format("ID = {0} \t Code = {1} \t Subject = {2} ", item.ID,item.Code, item.Subject));
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

        public List<string> GetProfessorsList() {

            List<string> professorsList = new List<string>();

            try {

                if (CodingSchool?.Professors != null) { 


                    foreach (Professor item in CodingSchool.Professors) {

                        professorsList.Add(string.Format("ID = {0} \t Name = {1} \t Surname = {2} \t Rank = {3} ", item.ID, item.Name,item.Surname, item.Rank));
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

            return professorsList;
        }
        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SerializeToJson();
        }


        private void viewToolStripMenuItem3_Click(object sender, EventArgs e) {
           
        }

        private void professorsToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Professor;
            viewForm.MasterData = CodingSchool;
            viewForm.ViewData = GetProfessorsList();

            viewForm.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void coursesToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Course;
            viewForm.MasterData = CodingSchool;
            viewForm.ViewData = GetCoursesList();

            viewForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Student;
            viewForm.MasterData = CodingSchool;

            viewForm.ViewData = GetStudentList();

            viewForm.Show();
        }
    }
}
