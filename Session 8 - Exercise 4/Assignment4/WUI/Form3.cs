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
namespace Assignment4 {
    public partial class Form3 : DevExpress.XtraBars.ToolbarForm.ToolbarForm {

        //Properties
        public int Choice { get; set; }
        
        //Costructor
        public Form3() {
            InitializeComponent();
        }

        //Methods
        private void Form3_Load(object sender, EventArgs e) {
           
        }
        
        private void ctrlExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ctrlButtonProfessor_MouseClick(object sender, MouseEventArgs e) {
            Choice = 2;
        }

        private void ctrlButtonSecretariat_MouseClick(object sender, MouseEventArgs e) {
            Choice = 1;
        }

        private void ctrlButtonStudent_MouseClick(object sender, MouseEventArgs e) {
            Choice = 3;
        }
        private void ctrlOK_Click(object sender, EventArgs e) {
            ModeSelection();
        }

        private void ModeSelection() {
            switch (Choice) {
                case 1:
                    SecretariatViewForm secretariatViewForm = new SecretariatViewForm();
                    secretariatViewForm.ShowDialog();
                    break;
                case 2:
                    ProfessorViewForm professorViewform = new ProfessorViewForm();
                    professorViewform.ShowDialog();
                    break;
                case 3:
                    StudentViewForm studentViewform = new StudentViewForm();
                    studentViewform.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        JavaScriptSerializer serializer = new JavaScriptSerializer();
    }
}
