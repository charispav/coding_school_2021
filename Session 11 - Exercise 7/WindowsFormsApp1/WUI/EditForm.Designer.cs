
namespace WindowsFormsApp1.WUI {
    partial class EditForm {
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
            this.ctrlTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblField2 = new DevExpress.XtraEditors.LabelControl();
            this.lblField1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlEditField2 = new DevExpress.XtraEditors.TextEdit();
            this.ctrlEditField1 = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblField4 = new DevExpress.XtraEditors.LabelControl();
            this.lblField3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlEditField4 = new DevExpress.XtraEditors.TextEdit();
            this.ctrlEditField3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle
            // 
            this.ctrlTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTitle.Appearance.Options.UseFont = true;
            this.ctrlTitle.Location = new System.Drawing.Point(46, 30);
            this.ctrlTitle.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlTitle.Name = "ctrlTitle";
            this.ctrlTitle.Size = new System.Drawing.Size(50, 31);
            this.ctrlTitle.TabIndex = 21;
            this.ctrlTitle.Text = "Title";
            // 
            // lblField2
            // 
            this.lblField2.Appearance.Options.UseTextOptions = true;
            this.lblField2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblField2.Location = new System.Drawing.Point(46, 115);
            this.lblField2.Margin = new System.Windows.Forms.Padding(5);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(35, 16);
            this.lblField2.TabIndex = 20;
            this.lblField2.Text = "field 2";
            // 
            // lblField1
            // 
            this.lblField1.Location = new System.Drawing.Point(46, 82);
            this.lblField1.Margin = new System.Windows.Forms.Padding(5);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(40, 16);
            this.lblField1.TabIndex = 19;
            this.lblField1.Text = "field1 :";
            // 
            // ctrlEditField2
            // 
            this.ctrlEditField2.Location = new System.Drawing.Point(181, 112);
            this.ctrlEditField2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlEditField2.Name = "ctrlEditField2";
            this.ctrlEditField2.Size = new System.Drawing.Size(508, 22);
            this.ctrlEditField2.TabIndex = 18;
            this.ctrlEditField2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlEditField2_KeyDown);
            // 
            // ctrlEditField1
            // 
            this.ctrlEditField1.EditValue = "";
            this.ctrlEditField1.Location = new System.Drawing.Point(181, 80);
            this.ctrlEditField1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlEditField1.Name = "ctrlEditField1";
            this.ctrlEditField1.Size = new System.Drawing.Size(508, 22);
            this.ctrlEditField1.TabIndex = 17;
            this.ctrlEditField1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlEditField1_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(709, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 39);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(556, 405);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 39);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblField4
            // 
            this.lblField4.Location = new System.Drawing.Point(46, 180);
            this.lblField4.Margin = new System.Windows.Forms.Padding(5);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(40, 16);
            this.lblField4.TabIndex = 25;
            this.lblField4.Text = "field4 :";
            // 
            // lblField3
            // 
            this.lblField3.Location = new System.Drawing.Point(46, 148);
            this.lblField3.Margin = new System.Windows.Forms.Padding(5);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(40, 16);
            this.lblField3.TabIndex = 24;
            this.lblField3.Text = "field3 :";
            // 
            // ctrlEditField4
            // 
            this.ctrlEditField4.Location = new System.Drawing.Point(181, 177);
            this.ctrlEditField4.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlEditField4.Name = "ctrlEditField4";
            this.ctrlEditField4.Size = new System.Drawing.Size(508, 22);
            this.ctrlEditField4.TabIndex = 23;
            this.ctrlEditField4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlEditField4_KeyDown);
            // 
            // ctrlEditField3
            // 
            this.ctrlEditField3.EditValue = "";
            this.ctrlEditField3.Location = new System.Drawing.Point(181, 145);
            this.ctrlEditField3.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlEditField3.Name = "ctrlEditField3";
            this.ctrlEditField3.Size = new System.Drawing.Size(508, 22);
            this.ctrlEditField3.TabIndex = 22;
            this.ctrlEditField3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlEditField3_KeyDown);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 459);
            this.Controls.Add(this.lblField4);
            this.Controls.Add(this.lblField3);
            this.Controls.Add(this.ctrlEditField4);
            this.Controls.Add(this.ctrlEditField3);
            this.Controls.Add(this.ctrlTitle);
            this.Controls.Add(this.lblField2);
            this.Controls.Add(this.lblField1);
            this.Controls.Add(this.ctrlEditField2);
            this.Controls.Add(this.ctrlEditField1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEditField3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl ctrlTitle;
        private DevExpress.XtraEditors.LabelControl lblField2;
        private DevExpress.XtraEditors.LabelControl lblField1;
        private DevExpress.XtraEditors.TextEdit ctrlEditField2;
        private DevExpress.XtraEditors.TextEdit ctrlEditField1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.LabelControl lblField4;
        private DevExpress.XtraEditors.LabelControl lblField3;
        private DevExpress.XtraEditors.TextEdit ctrlEditField4;
        private DevExpress.XtraEditors.TextEdit ctrlEditField3;
    }
}