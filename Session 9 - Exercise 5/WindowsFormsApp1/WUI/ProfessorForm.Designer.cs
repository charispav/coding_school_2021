
namespace WindowsFormsApp1.WUI {
    partial class ProfessorForm {
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlAge = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlRank = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCancelButton = new System.Windows.Forms.Button();
            this.ctrlOKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(53, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(240, 31);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Add New Professor...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(86, 129);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Age :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 94);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 16);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Name :";
            // 
            // ctrlAge
            // 
            this.ctrlAge.Location = new System.Drawing.Point(128, 123);
            this.ctrlAge.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAge.Name = "ctrlAge";
            this.ctrlAge.Size = new System.Drawing.Size(133, 22);
            this.ctrlAge.TabIndex = 12;
            this.ctrlAge.EditValueChanged += new System.EventHandler(this.ctrlAge_EditValueChanged);
            // 
            // ctrlName
            // 
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(128, 91);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(133, 22);
            this.ctrlName.TabIndex = 11;
            this.ctrlName.EditValueChanged += new System.EventHandler(this.ctrlName_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(80, 165);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Rank :";
            // 
            // ctrlRank
            // 
            this.ctrlRank.Location = new System.Drawing.Point(128, 162);
            this.ctrlRank.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlRank.Name = "ctrlRank";
            this.ctrlRank.Size = new System.Drawing.Size(133, 22);
            this.ctrlRank.TabIndex = 15;
            this.ctrlRank.EditValueChanged += new System.EventHandler(this.ctrlRank_EditValueChanged);
            // 
            // ctrlCancelButton
            // 
            this.ctrlCancelButton.Location = new System.Drawing.Point(642, 398);
            this.ctrlCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCancelButton.Name = "ctrlCancelButton";
            this.ctrlCancelButton.Size = new System.Drawing.Size(145, 39);
            this.ctrlCancelButton.TabIndex = 18;
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
            this.ctrlOKButton.TabIndex = 17;
            this.ctrlOKButton.Text = "OK";
            this.ctrlOKButton.UseVisualStyleBackColor = true;
            this.ctrlOKButton.Click += new System.EventHandler(this.ctrlOKButton_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCancelButton);
            this.Controls.Add(this.ctrlOKButton);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlRank);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlAge);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControl3);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlAge;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlRank;
        private System.Windows.Forms.Button ctrlCancelButton;
        private System.Windows.Forms.Button ctrlOKButton;
    }
}