
namespace Assignment4 {
    partial class Form3 {
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
            this.components = new System.ComponentModel.Container();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ctrlExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlButtonSecretariat = new System.Windows.Forms.RadioButton();
            this.ctrlButtonProfessor = new System.Windows.Forms.RadioButton();
            this.ctrlButtonStudent = new System.Windows.Forms.RadioButton();
            this.ctrlOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(700, 39);
            this.toolbarFormControl1.TabIndex = 0;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 39);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 411);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 39);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 411);
            // 
            // ctrlExit
            // 
            this.ctrlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlExit.Location = new System.Drawing.Point(496, 398);
            this.ctrlExit.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(191, 39);
            this.ctrlExit.TabIndex = 5;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(123, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome! Please select your role:";
            // 
            // ctrlButtonSecretariat
            // 
            this.ctrlButtonSecretariat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlButtonSecretariat.AutoSize = true;
            this.ctrlButtonSecretariat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlButtonSecretariat.Location = new System.Drawing.Point(161, 179);
            this.ctrlButtonSecretariat.Name = "ctrlButtonSecretariat";
            this.ctrlButtonSecretariat.Size = new System.Drawing.Size(112, 25);
            this.ctrlButtonSecretariat.TabIndex = 8;
            this.ctrlButtonSecretariat.TabStop = true;
            this.ctrlButtonSecretariat.Text = "Secretariat";
            this.ctrlButtonSecretariat.UseVisualStyleBackColor = true;
            this.ctrlButtonSecretariat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlButtonSecretariat_MouseClick);
            // 
            // ctrlButtonProfessor
            // 
            this.ctrlButtonProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlButtonProfessor.AutoSize = true;
            this.ctrlButtonProfessor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlButtonProfessor.Location = new System.Drawing.Point(161, 221);
            this.ctrlButtonProfessor.Name = "ctrlButtonProfessor";
            this.ctrlButtonProfessor.Size = new System.Drawing.Size(100, 25);
            this.ctrlButtonProfessor.TabIndex = 9;
            this.ctrlButtonProfessor.TabStop = true;
            this.ctrlButtonProfessor.Text = "Professor";
            this.ctrlButtonProfessor.UseVisualStyleBackColor = true;
            this.ctrlButtonProfessor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlButtonProfessor_MouseClick);
            // 
            // ctrlButtonStudent
            // 
            this.ctrlButtonStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlButtonStudent.AutoSize = true;
            this.ctrlButtonStudent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlButtonStudent.Location = new System.Drawing.Point(161, 263);
            this.ctrlButtonStudent.Name = "ctrlButtonStudent";
            this.ctrlButtonStudent.Size = new System.Drawing.Size(88, 25);
            this.ctrlButtonStudent.TabIndex = 10;
            this.ctrlButtonStudent.TabStop = true;
            this.ctrlButtonStudent.Text = "Student";
            this.ctrlButtonStudent.UseVisualStyleBackColor = true;
            this.ctrlButtonStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlButtonStudent_MouseClick);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlOK.Location = new System.Drawing.Point(297, 398);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(191, 39);
            this.ctrlOK.TabIndex = 11;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlButtonStudent);
            this.Controls.Add(this.ctrlButtonProfessor);
            this.Controls.Add(this.ctrlButtonSecretariat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.RadioButton ctrlButtonStudent;
        private System.Windows.Forms.RadioButton ctrlButtonProfessor;
        private System.Windows.Forms.RadioButton ctrlButtonSecretariat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctrlOK;
    }
}