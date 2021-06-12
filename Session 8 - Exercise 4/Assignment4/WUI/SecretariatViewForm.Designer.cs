
namespace Assignment4 {
    partial class SecretariatViewForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlAddCourseButton = new System.Windows.Forms.Button();
            this.ctrlAddProfessorButton = new System.Windows.Forms.Button();
            this.ctrlAddStudentButton = new System.Windows.Forms.Button();
            this.ctrlCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secretariat mode";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(185, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select what you want to do:";
            // 
            // ctrlAddCourseButton
            // 
            this.ctrlAddCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlAddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddCourseButton.Location = new System.Drawing.Point(133, 175);
            this.ctrlAddCourseButton.Name = "ctrlAddCourseButton";
            this.ctrlAddCourseButton.Size = new System.Drawing.Size(158, 89);
            this.ctrlAddCourseButton.TabIndex = 2;
            this.ctrlAddCourseButton.Text = "Add Course";
            this.ctrlAddCourseButton.UseVisualStyleBackColor = true;
            this.ctrlAddCourseButton.Click += new System.EventHandler(this.ctrlAddCourseButton_Click);
            // 
            // ctrlAddProfessorButton
            // 
            this.ctrlAddProfessorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlAddProfessorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddProfessorButton.Location = new System.Drawing.Point(315, 175);
            this.ctrlAddProfessorButton.Name = "ctrlAddProfessorButton";
            this.ctrlAddProfessorButton.Size = new System.Drawing.Size(158, 89);
            this.ctrlAddProfessorButton.TabIndex = 3;
            this.ctrlAddProfessorButton.Text = "Add Professor";
            this.ctrlAddProfessorButton.UseVisualStyleBackColor = true;
            this.ctrlAddProfessorButton.Click += new System.EventHandler(this.ctrlAddProfessorButton_Click);
            // 
            // ctrlAddStudentButton
            // 
            this.ctrlAddStudentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlAddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddStudentButton.Location = new System.Drawing.Point(499, 175);
            this.ctrlAddStudentButton.Name = "ctrlAddStudentButton";
            this.ctrlAddStudentButton.Size = new System.Drawing.Size(158, 89);
            this.ctrlAddStudentButton.TabIndex = 4;
            this.ctrlAddStudentButton.Text = "Add Student";
            this.ctrlAddStudentButton.UseVisualStyleBackColor = true;
            this.ctrlAddStudentButton.Click += new System.EventHandler(this.ctrlAddStudentButton_Click);
            // 
            // ctrlCancelButton
            // 
            this.ctrlCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCancelButton.Location = new System.Drawing.Point(596, 398);
            this.ctrlCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCancelButton.Name = "ctrlCancelButton";
            this.ctrlCancelButton.Size = new System.Drawing.Size(191, 39);
            this.ctrlCancelButton.TabIndex = 12;
            this.ctrlCancelButton.Text = "Cancel";
            this.ctrlCancelButton.UseVisualStyleBackColor = true;
            this.ctrlCancelButton.Click += new System.EventHandler(this.ctrlCancelButton_Click);
            // 
            // SecretariatViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCancelButton);
            this.Controls.Add(this.ctrlAddStudentButton);
            this.Controls.Add(this.ctrlAddProfessorButton);
            this.Controls.Add(this.ctrlAddCourseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecretariatViewForm";
            this.Text = "SecretariatViewForm";
            this.Load += new System.EventHandler(this.SecretariatViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ctrlAddCourseButton;
        private System.Windows.Forms.Button ctrlAddProfessorButton;
        private System.Windows.Forms.Button ctrlAddStudentButton;
        private System.Windows.Forms.Button ctrlCancelButton;
    }
}