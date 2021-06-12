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
    public partial class ProfessorAddDialog : Form {
        public ProfessorAddDialog() {
            InitializeComponent();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e) {

        }

        private void textEdit2_TextChanged(object sender, EventArgs e) {

        }

        private void textEdit3_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textEdit1.Text != String.Empty && textEdit2.Text != String.Empty && textEdit3.Text != String.Empty) {
                Professor professor = new Professor() {
                    Name = textEdit1.Text,
                    Age = Convert.ToInt32(textEdit2.Text),
                    Rank = textEdit3.Text
                };
                professor.GetName();
                University university = new University();
                university.AddProfessors(professor);
                Close();
            }
            else {
                Close();
            }
        }
    }
}
