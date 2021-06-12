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

        }

        private void ctrlCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void ctrlCode_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlSubject_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
