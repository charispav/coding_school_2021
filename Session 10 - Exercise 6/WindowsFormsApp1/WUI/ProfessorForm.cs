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
    public partial class ProfessorForm : Form {

        //Properties
        public Professor NewProfessor { get; set; }


        //Constructor
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ctrlOKButton_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);

                NewProfessor.Age = Convert.ToInt32(ctrlAge.EditValue);

                NewProfessor.Rank = Convert.ToString(ctrlRank.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
        }
        private void ctrlCancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlAge_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlRank_EditValueChanged(object sender, EventArgs e) {

        }

    }
}
