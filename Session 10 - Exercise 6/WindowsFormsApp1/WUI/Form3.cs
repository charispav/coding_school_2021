using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form3 : DevExpress.XtraEditors.XtraForm {
        public Form3() {
            InitializeComponent();
        }

       
        

        private void tabFormControl1_Click(object sender, EventArgs e) {

        }

        private void Form3_Load(object sender, EventArgs e) {
            InitControls();
        }



        private void InitControls() {
            
            //textEdit1.Text = "Fotis";
            //textEdit1.BackColor = Color.Red;



        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e) {

            DateTime dateValue = (DateTime)dateEdit1.EditValue;

            int years = (DateTime.Now - dateValue).Days / 365;

            spinEdit1.EditValue = years;

            //DateTime? dateValue2 = dateEdit1.EditValue as DateTime?;

            //string dateValue3 = dateEdit1.EditValue as string;

            //if (dateValue3 != null) { 
            
            //    // ...
            //}
        }
    }
}
