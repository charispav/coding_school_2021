using DevExpress.XtraEditors;
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

namespace WindowsFormsApp1 {

    public partial class StudentForm : Form {

        // PROPERTIES ????
        public Student NewStudent { get; set; }

        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {
           
        }

        private void ctrlOKButton_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewStudent.Name = Convert.ToString(ctrlName.EditValue);

                NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
            DialogResult = DialogResult.OK;
            Close();

        }

        private void ctrlCancelButton_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!
            
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e) {

            // Example on Edit Value Changed -> triggering another event
            TextEdit textEdit = (sender as TextEdit);
            if (textEdit.EditValue.ToString().Length == 0) {
                ctrlSurname.EditValue = string.Empty;
            }

        }



    }
}
