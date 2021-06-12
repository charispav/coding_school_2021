
namespace WindowsFormsApp1.WUI {
    partial class CourseForm {
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCancelButton = new System.Windows.Forms.Button();
            this.ctrlOKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 26);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(214, 31);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Add New Course...";
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(107, 106);
            this.ctrlSubject.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(133, 22);
            this.ctrlSubject.TabIndex = 11;
            this.ctrlSubject.EditValueChanged += new System.EventHandler(this.ctrlSubject_EditValueChanged);
            // 
            // ctrlCode
            // 
            this.ctrlCode.EditValue = "";
            this.ctrlCode.Location = new System.Drawing.Point(107, 74);
            this.ctrlCode.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(133, 22);
            this.ctrlCode.TabIndex = 10;
            this.ctrlCode.EditValueChanged += new System.EventHandler(this.ctrlCode_EditValueChanged);
            // 
            // ctrlCancelButton
            // 
            this.ctrlCancelButton.Location = new System.Drawing.Point(642, 398);
            this.ctrlCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCancelButton.Name = "ctrlCancelButton";
            this.ctrlCancelButton.Size = new System.Drawing.Size(145, 39);
            this.ctrlCancelButton.TabIndex = 14;
            this.ctrlCancelButton.Text = "Cancel";
            this.ctrlCancelButton.UseVisualStyleBackColor = true;
            this.ctrlCancelButton.Click += new System.EventHandler(this.ctrlCancelButton_Click);
            // 
            // ctrlOKButton
            // 
            this.ctrlOKButton.Location = new System.Drawing.Point(489, 398);
            this.ctrlOKButton.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlOKButton.Name = "ctrlOKButton";
            this.ctrlOKButton.Size = new System.Drawing.Size(145, 39);
            this.ctrlOKButton.TabIndex = 13;
            this.ctrlOKButton.Text = "OK";
            this.ctrlOKButton.UseVisualStyleBackColor = true;
            this.ctrlOKButton.Click += new System.EventHandler(this.ctrlOKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subject:";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCancelButton);
            this.Controls.Add(this.ctrlOKButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCode);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private System.Windows.Forms.Button ctrlCancelButton;
        private System.Windows.Forms.Button ctrlOKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}