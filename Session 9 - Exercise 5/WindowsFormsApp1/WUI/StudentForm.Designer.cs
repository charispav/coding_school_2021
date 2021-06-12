
namespace WindowsFormsApp1 {
    partial class StudentForm {
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
            this.ctrlCancelButton = new System.Windows.Forms.Button();
            this.ctrlOKButton = new System.Windows.Forms.Button();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCancelButton
            // 
            this.ctrlCancelButton.Location = new System.Drawing.Point(796, 501);
            this.ctrlCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlCancelButton.Name = "ctrlCancelButton";
            this.ctrlCancelButton.Size = new System.Drawing.Size(145, 39);
            this.ctrlCancelButton.TabIndex = 4;
            this.ctrlCancelButton.Text = "Cancel";
            this.ctrlCancelButton.UseVisualStyleBackColor = true;
            this.ctrlCancelButton.Click += new System.EventHandler(this.ctrlCancelButton_Click);
            // 
            // ctrlOKButton
            // 
            this.ctrlOKButton.Location = new System.Drawing.Point(643, 501);
            this.ctrlOKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlOKButton.Name = "ctrlOKButton";
            this.ctrlOKButton.Size = new System.Drawing.Size(145, 39);
            this.ctrlOKButton.TabIndex = 3;
            this.ctrlOKButton.Text = "OK";
            this.ctrlOKButton.UseVisualStyleBackColor = true;
            this.ctrlOKButton.Click += new System.EventHandler(this.ctrlOKButton_Click);
            // 
            // ctrlName
            // 
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(137, 63);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(133, 22);
            this.ctrlName.TabIndex = 5;
            this.ctrlName.EditValueChanged += new System.EventHandler(this.ctrlName_EditValueChanged);
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(137, 95);
            this.ctrlSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(133, 22);
            this.ctrlSurname.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(84, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(70, 98);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Surname :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(64, 15);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(224, 31);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Add New Student...";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 555);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.ctrlCancelButton);
            this.Controls.Add(this.ctrlOKButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlCancelButton;
        private System.Windows.Forms.Button ctrlOKButton;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}