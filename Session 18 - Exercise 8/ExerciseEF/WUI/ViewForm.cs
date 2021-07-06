using EFApp.EF.Context;
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
    public partial class ViewForm : Form {
        private EFAppContext _eFAppContext;
        public string TypeOfClass { get; set; }

        public ViewForm(EFAppContext eFAppContext) {
            _eFAppContext = eFAppContext;
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {
            FormLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddEntity();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteEntity();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Refresh(TypeOfClass);
        }
       
        private void btnSaveChanges_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private async void SaveChanges() {
            await _eFAppContext.SaveChangesAsync();
        }

        private void FormLoad() {

            switch (TypeOfClass) {
                case nameof(Student):
                    this.Text = "Students View Form";
                    break;
                case nameof(Course):
                    this.Text = "Courses View Form";
                    break;
                default:
                    break;
            }

            Refresh(TypeOfClass);
        }
        private void AddEntity() {

            switch (TypeOfClass) {
                case nameof(Student):

                    Student newStudent = new Student();
                    EditForm editFormStudent = new EditForm();
                    editFormStudent.EditObject = newStudent;
                    editFormStudent._TypeOfClass = TypeOfClass;
                    editFormStudent.ShowDialog();
                    _eFAppContext.Students.Add(newStudent);
                    source.Insert(0, newStudent);
                    break;

                case nameof(Course):

                    Course newCourse = new Course();
                    EditForm editFormCourse = new EditForm();
                    editFormCourse.EditObject = newCourse;
                    editFormCourse._TypeOfClass = TypeOfClass;
                    editFormCourse.ShowDialog();
                    _eFAppContext.Courses.Add(newCourse);
                    source.Insert(0, newCourse);
                    break;
                default:
                    break;
            }

        }
        private void DeleteEntity() {
            
            switch (TypeOfClass) {
                case nameof(Student):

                    var student = source.Current as Student;
                    if (student is null)
                        return;

                    source.RemoveCurrent();
                    _eFAppContext.Students.Remove(student);
                    break;
                    
                case nameof(Course):
                    var course = source.Current as Course;

                    if (course is null)
                        return;

                    source.RemoveCurrent();
                    _eFAppContext.Courses.Remove(course);
                    break;

                default:
                    break;
            }

        }
        private void Refresh(string classtype) {

            switch (classtype) {

                case nameof(Student):

                    source.DataSource = typeof(Student);
                    dataGridView1.DataSource = typeof(Student);

                    source.Clear();
                    _eFAppContext.ChangeTracker.Clear();

                    foreach (var student in _eFAppContext.Students.ToList()) {
                        source.Add(student);
                    }

                    dataGridView1.DataSource = source;
                    break;

                case nameof(Course):

                    source.DataSource = typeof(Course);
                    dataGridView1.DataSource = typeof(Course);

                    source.Clear();
                    _eFAppContext.ChangeTracker.Clear();

                    foreach (var course in _eFAppContext.Courses.ToList()) {
                        source.Add(course);
                    }

                    dataGridView1.DataSource = source;
                    break;

                default:
                    break;
            }

        }
    }
}
