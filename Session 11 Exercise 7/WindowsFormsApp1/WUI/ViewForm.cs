using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    
    public partial class ViewForm : Form {

        public EntityTypeEnum Type { get; set; }
        public University MasterData { get; set; }
        public List<string> ViewData = new List<string>(); 

        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {
            ExportData();

        }

        private void btnEdit_Click(object sender, EventArgs e) {

            EditSelectedRecord();
        }

        private void ctrlViewList_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
        }


        private void EditSelectedRecord() {

            Guid id = GetListID();
            Object editObject = null;

            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:
                    editObject = MasterData.Courses.Find(x => x.ID == id);
                    break;

                case EntityTypeEnum.Student:
                    editObject = MasterData.Students.Find(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    editObject = MasterData.Professors.Find(x => x.ID == id);
                    break;

                default:
                    break;
            }

            // open edit form
            EditForm form = new EditForm();
            form.Type = Type;
            form.EditObject = editObject;
            form.ShowDialog();

        }

        private Guid GetListID() {

            object listSelection = ctrlViewList.SelectedItem;
            List<string> listParse = listSelection.ToString().Split('\t').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(4));
            return id;
        }

        private void btnDelete_Click(object sender, EventArgs e) {


            Guid id = GetListID();
            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:
                    
                    MasterData.Courses.RemoveAll(x => x.ID == id);
                    break;

                case EntityTypeEnum.Student:
                   
                    MasterData.Students.RemoveAll(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    MasterData.Professors.RemoveAll(x => x.ID == id);
                    break;

                default:
                    break;
            }
        }
        private void ExportData() {
            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }
        }
        private void ctrlViewList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        public void btnAdd_Click(object sender, EventArgs e) {
            
            AddEntity(Type);

        }
        public University AddEntity(EntityTypeEnum entityType) {

            switch (entityType) {
                case EntityTypeEnum.Course:

                    Course courseEntity = new Course();

                    EditForm courseForm = new EditForm();
                    courseForm.Type = entityType;
                    courseForm.EditObject = courseEntity;


                    if (courseForm.ShowDialog() == DialogResult.OK) {
                        MasterData.Courses.Add(courseEntity);
                    }
                    break;

                case EntityTypeEnum.Student:
                    Student studentEntity = new Student();

                    EditForm studentForm = new EditForm();
                    studentForm.Type = entityType;
                    studentForm.EditObject = studentEntity;

                    if (studentForm.ShowDialog() == DialogResult.OK) {
                        MasterData.Students.Add(studentEntity);
                    }
                    break;

                case EntityTypeEnum.Professor:
                    Professor professorEntity = new Professor();

                    EditForm professorForm = new EditForm();
                    professorForm.Type = entityType;
                    professorForm.EditObject = professorEntity;

                    if (professorForm.ShowDialog() == DialogResult.OK) {
                        MasterData.Professors.Add(professorEntity);
                    }

                    break;

                default:
                    break;
            }
            MdiMainForm form = new MdiMainForm();
            form.CodingSchool = MasterData;
            return form.CodingSchool;

        }
        private void btnRefresh_Click(object sender, EventArgs e) {

            ctrlViewList.Items.Clear();
            MdiMainForm form = new MdiMainForm();
            form.CodingSchool = MasterData;
            switch (Type) {
                case EntityTypeEnum.Course:
                    
                    ViewData = form.GetCoursesList();
                    ExportData();
                    break;

                case EntityTypeEnum.Student:
                    
                    ViewData = form.GetStudentList();
                    ExportData();
                    break;

                case EntityTypeEnum.Professor:
                    ViewData = form.GetProfessorsList();
                    ExportData();
                    break;

                default:
                    break;
            }
        }

    }
}
