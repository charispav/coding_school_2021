
namespace WindowsFormsApp1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlAddCourse = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.ctrlAddProfessor = new System.Windows.Forms.Button();
            this.ctrlStudentList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(860, 564);
            this.ctrlExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(191, 39);
            this.ctrlExit.TabIndex = 2;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // ctrlAddCourse
            // 
            this.ctrlAddCourse.Location = new System.Drawing.Point(92, 86);
            this.ctrlAddCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlAddCourse.Name = "ctrlAddCourse";
            this.ctrlAddCourse.Size = new System.Drawing.Size(145, 110);
            this.ctrlAddCourse.TabIndex = 7;
            this.ctrlAddCourse.Text = "Add Course...";
            this.ctrlAddCourse.UseVisualStyleBackColor = true;
            this.ctrlAddCourse.Click += new System.EventHandler(this.ctrlAddCourse_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(289, 86);
            this.ctrlAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(151, 110);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.ctrlAddStudent_Click);
            // 
            // ctrlAddProfessor
            // 
            this.ctrlAddProfessor.Location = new System.Drawing.Point(484, 86);
            this.ctrlAddProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlAddProfessor.Name = "ctrlAddProfessor";
            this.ctrlAddProfessor.Size = new System.Drawing.Size(156, 110);
            this.ctrlAddProfessor.TabIndex = 9;
            this.ctrlAddProfessor.Text = "Add Professor...";
            this.ctrlAddProfessor.UseVisualStyleBackColor = true;
            this.ctrlAddProfessor.Click += new System.EventHandler(this.ctrlAddProfessor_Click);
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Location = new System.Drawing.Point(92, 278);
            this.ctrlStudentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(483, 182);
            this.ctrlStudentList.TabIndex = 10;
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(661, 564);
            this.ctrlSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(191, 39);
            this.ctrlSave.TabIndex = 11;
            this.ctrlSave.Text = "Save...";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ctrlLoad_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(92, 537);
            this.ctrlSerialize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(191, 39);
            this.ctrlSerialize.TabIndex = 13;
            this.ctrlSerialize.Text = "Serialize to Json";
            this.ctrlSerialize.UseVisualStyleBackColor = true;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(92, 490);
            this.ctrlDeserialize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(191, 39);
            this.ctrlDeserialize.TabIndex = 14;
            this.ctrlDeserialize.Text = "Deserialize from Json";
            this.ctrlDeserialize.UseVisualStyleBackColor = true;
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 618);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.ctrlAddProfessor);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlExit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctrlAddCourse;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button ctrlAddProfessor;
        private DevExpress.XtraEditors.ListBoxControl ctrlStudentList;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ctrlSerialize;
        private System.Windows.Forms.Button ctrlDeserialize;
    }
}

