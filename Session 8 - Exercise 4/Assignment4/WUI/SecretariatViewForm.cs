using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4 {
    public partial class SecretariatViewForm : Form {
        public SecretariatViewForm() {
            InitializeComponent();
        }

        private void ctrlCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SecretariatViewForm_Load(object sender, EventArgs e) {

        }

        private void ctrlAddCourseButton_Click(object sender, EventArgs e) {
            CourseAddDialog courseAddDialog = new CourseAddDialog();
            courseAddDialog.ShowDialog();
           
        }

        private void ctrlAddProfessorButton_Click(object sender, EventArgs e) {
            ProfessorAddDialog professorAddDialog = new ProfessorAddDialog();
            professorAddDialog.ShowDialog();
        }

        private void ctrlAddStudentButton_Click(object sender, EventArgs e) {
            StudentAddDialog studentAddDialog = new StudentAddDialog();
            studentAddDialog.ShowDialog();
        }

    }
}
