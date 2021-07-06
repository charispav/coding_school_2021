using EFApp.EF.Context;
using EFApp.Model;
using EFApp.WUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExerciseEF {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        private EFAppContext eFAppContext;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var optionsBuilder = new DbContextOptionsBuilder<EFAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFApp;Integrated Security=True;");

            eFAppContext = new EFAppContext(optionsBuilder.Options);

            eFAppContext.ChangeTracker.Clear();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            eFAppContext.Dispose();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e) {
           
            ViewForm viewForm = new ViewForm(eFAppContext);
            viewForm.TypeOfClass = nameof(Student);
            viewForm.MdiParent = this;
            viewForm.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e) {
            
            ViewForm viewForm = new ViewForm(eFAppContext);
            viewForm.TypeOfClass = nameof(Course);
            viewForm.MdiParent = this;
            viewForm.Show();
        }
    }
}
