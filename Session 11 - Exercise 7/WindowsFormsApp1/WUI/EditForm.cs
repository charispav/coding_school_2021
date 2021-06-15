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
using System.IO;
namespace WindowsFormsApp1.WUI {

    public partial class EditForm : Form {

        // PROPERTIES
        private const string _LogFile = "Log.txt";
        public object EditObject { get; set; }
        public EntityTypeEnum Type { get; set; }

        public EditForm() {

            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {

            switch (Type) {
                case EntityTypeEnum.Course:
                    ctrlTitle.Text = "Add New Course...";

                    lblField1.Text = "Code: ";
                    ctrlEditField1.Width = 150;

                    lblField2.Text = "Subject: ";

                    lblField3.Visible = false;
                    ctrlEditField3.Visible = false;

                    lblField4.Visible = false;
                    ctrlEditField4.Visible = false;

                    // get object -> display existing values
                    Course course = EditObject as Course;

                    ctrlEditField1.EditValue = course.Code;
                    ctrlEditField2.EditValue = course.Subject;

                    break;

                case EntityTypeEnum.Student:
                    ctrlTitle.Text = "Add New Student...";
                    PersonFieldsEdit();

                    lblField3.Text = "Registration number:";

                    lblField4.Visible = false;
                    ctrlEditField4.Visible = false;

                    // get object -> display existing values
                    Student student = EditObject as Student;

                    ctrlEditField1.EditValue = student.Name;
                    ctrlEditField2.EditValue = student.Surname;
                    ctrlEditField3.EditValue = student.RegistrationNumber;

                    break;

                case EntityTypeEnum.Professor:

                    PersonFieldsEdit();
                    ctrlTitle.Text = "Add New Professor...";

                    lblField3.Text = "Rank";
                    
                    lblField4.Visible = false;
                    ctrlEditField4.Visible = false;

                    Professor professor = EditObject as Professor;

                    ctrlEditField1.EditValue = professor.Name;
                    ctrlEditField2.EditValue = professor.Surname;
                    ctrlEditField3.EditValue = professor.Rank;
                    break;

                default:
                    break;
            }


        }

        private void btnOK_Click(object sender, EventArgs e) {
            FormEntry();

        }

        private void FormEntry() {
            switch (Type) {
                case EntityTypeEnum.Course:

                    try {
                        if (ctrlEditField1.EditValue != null) {
                            Course course = EditObject as Course;
                            course.Code = Convert.ToString(ctrlEditField1.EditValue);
                            course.Subject = Convert.ToString(ctrlEditField2.EditValue);

                            DialogResult = DialogResult.OK;
                        }
                        else {
                            MessageBox.Show("Please set course code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }

                    break;
                case EntityTypeEnum.Student:

                    try {
                        if (ctrlEditField1.EditValue != null) {
                            Student student = EditObject as Student;
                            student.Name = Convert.ToString(ctrlEditField1.EditValue);
                            student.Surname = Convert.ToString(ctrlEditField2.EditValue);
                            student.RegistrationNumber = Convert.ToString(ctrlEditField3.EditValue);

                            DialogResult = DialogResult.OK;
                        }
                        else {
                            MessageBox.Show("Please set student name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }

                    break;
                case EntityTypeEnum.Professor:

                    try {
                        if (ctrlEditField1.EditValue.ToString().Length > 0) {
                            Professor professor = EditObject as Professor;
                            professor.Name = Convert.ToString(ctrlEditField1.EditValue);
                            professor.Surname = Convert.ToString(ctrlEditField2.EditValue);
                            professor.Rank = Convert.ToString(ctrlEditField3.EditValue);
                            DialogResult = DialogResult.OK;
                        }
                        else {
                            MessageBox.Show("Please set professor name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        string path = Path.Combine(Environment.CurrentDirectory, _LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }

                    break;
                default:
                    break;
            }
        }

        private void PersonFieldsEdit() {

            lblField1.Text = "Name: ";
            ctrlEditField1.Width = 150;
            lblField2.Text = "Surname: ";
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void ctrlEditField1_KeyDown(object sender, KeyEventArgs e) {
            EnterKey(e);
        }

        private void ctrlEditField2_KeyDown(object sender, KeyEventArgs e) {
            EnterKey(e);
        }

        private void ctrlEditField3_KeyDown(object sender, KeyEventArgs e) {
            EnterKey(e);
        }

        private void ctrlEditField4_KeyDown(object sender, KeyEventArgs e) {
            EnterKey(e);
        }

        private void EnterKey(KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                FormEntry();
                e.Handled = true;
            }
        }
       
    }
}
