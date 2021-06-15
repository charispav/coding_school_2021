
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
            this.button3 = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ctrlStudentList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(645, 458);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(143, 32);
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
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 89);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Course...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(377, 70);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(113, 89);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(496, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 89);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add Professor...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Location = new System.Drawing.Point(69, 226);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(362, 148);
            this.ctrlStudentList.TabIndex = 10;
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(496, 458);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(143, 32);
            this.ctrlSave.TabIndex = 11;
            this.ctrlSave.Text = "Save...";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ctrlLoad_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(69, 436);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(143, 32);
            this.ctrlSerialize.TabIndex = 13;
            this.ctrlSerialize.Text = "Serialize to Json";
            this.ctrlSerialize.UseVisualStyleBackColor = true;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(69, 398);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(143, 32);
            this.ctrlDeserialize.TabIndex = 14;
            this.ctrlDeserialize.Text = "Deserialize from Json";
            this.ctrlDeserialize.UseVisualStyleBackColor = true;
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 89);
            this.button2.TabIndex = 15;
            this.button2.Text = "Create University";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlExit);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.ListBoxControl ctrlStudentList;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ctrlSerialize;
        private System.Windows.Forms.Button ctrlDeserialize;
        private System.Windows.Forms.Button button2;
    }
}

