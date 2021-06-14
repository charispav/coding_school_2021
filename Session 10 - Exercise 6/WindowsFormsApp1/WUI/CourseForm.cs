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
    public partial class CourseForm : Form {

        public Course NewCourse { get; set; }

        public CourseForm() {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e) {

        }

        private void ctrlOKButton_Click(object sender, EventArgs e) {
            if (ctrlCode.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewCourse.Code = Convert.ToString(ctrlCode.EditValue);

                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Code!");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ctrlCancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlCode_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlSubject_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
