namespace NewFileNotfier
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxBody = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxBCC = new System.Windows.Forms.TextBox();
            this.tbxCC = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblBCC = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.cbxEmailFileWithNotification = new System.Windows.Forms.CheckBox();
            this.lblToAddresses = new System.Windows.Forms.Label();
            this.cbxEmailNotification = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.hpMask = new System.Windows.Forms.HelpProvider();
            this.tpSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tabPage1);
            this.tpSettings.Location = new System.Drawing.Point(13, 13);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.SelectedIndex = 0;
            this.tpSettings.Size = new System.Drawing.Size(385, 392);
            this.tpSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxBody);
            this.tabPage1.Controls.Add(this.tbxSubject);
            this.tabPage1.Controls.Add(this.tbxFrom);
            this.tabPage1.Controls.Add(this.tbxBCC);
            this.tabPage1.Controls.Add(this.tbxCC);
            this.tabPage1.Controls.Add(this.tbxTo);
            this.tabPage1.Controls.Add(this.lblSubject);
            this.tabPage1.Controls.Add(this.lblFrom);
            this.tabPage1.Controls.Add(this.lblBCC);
            this.tabPage1.Controls.Add(this.lblCC);
            this.tabPage1.Controls.Add(this.cbxEmailFileWithNotification);
            this.tabPage1.Controls.Add(this.lblToAddresses);
            this.tabPage1.Controls.Add(this.cbxEmailNotification);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbxBody
            // 
            this.hpMask.SetHelpKeyword(this.tbxBody, "Mask");
            this.hpMask.SetHelpString(this.tbxBody, "Using {FILENAME} and {FILEPATH} will populate with appropriate values");
            this.tbxBody.Location = new System.Drawing.Point(6, 167);
            this.tbxBody.Multiline = true;
            this.tbxBody.Name = "tbxBody";
            this.hpMask.SetShowHelp(this.tbxBody, true);
            this.tbxBody.Size = new System.Drawing.Size(365, 170);
            this.tbxBody.TabIndex = 30;
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(52, 141);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(319, 20);
            this.tbxSubject.TabIndex = 25;
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(52, 115);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(158, 20);
            this.tbxFrom.TabIndex = 20;
            // 
            // tbxBCC
            // 
            this.tbxBCC.Location = new System.Drawing.Point(52, 89);
            this.tbxBCC.Name = "tbxBCC";
            this.tbxBCC.Size = new System.Drawing.Size(319, 20);
            this.tbxBCC.TabIndex = 15;
            // 
            // tbxCC
            // 
            this.tbxCC.Location = new System.Drawing.Point(52, 59);
            this.tbxCC.Name = "tbxCC";
            this.tbxCC.Size = new System.Drawing.Size(319, 20);
            this.tbxCC.TabIndex = 10;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(52, 27);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(319, 20);
            this.tbxTo.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.hpMask.SetHelpKeyword(this.lblSubject, "Mask");
            this.hpMask.SetHelpString(this.lblSubject, "Using {FILENAME} and {FILEPATH} will populate with appropriate values");
            this.lblSubject.Location = new System.Drawing.Point(3, 144);
            this.lblSubject.Name = "lblSubject";
            this.hpMask.SetShowHelp(this.lblSubject, true);
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(16, 118);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // lblBCC
            // 
            this.lblBCC.AutoSize = true;
            this.lblBCC.Location = new System.Drawing.Point(18, 92);
            this.lblBCC.Name = "lblBCC";
            this.lblBCC.Size = new System.Drawing.Size(28, 13);
            this.lblBCC.TabIndex = 1;
            this.lblBCC.Text = "BCC";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(25, 62);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(21, 13);
            this.lblCC.TabIndex = 1;
            this.lblCC.Text = "CC";
            // 
            // cbxEmailFileWithNotification
            // 
            this.cbxEmailFileWithNotification.AutoSize = true;
            this.cbxEmailFileWithNotification.Location = new System.Drawing.Point(29, 343);
            this.cbxEmailFileWithNotification.Name = "cbxEmailFileWithNotification";
            this.cbxEmailFileWithNotification.Size = new System.Drawing.Size(143, 17);
            this.cbxEmailFileWithNotification.TabIndex = 35;
            this.cbxEmailFileWithNotification.Text = "Send file with notification";
            this.cbxEmailFileWithNotification.UseVisualStyleBackColor = true;
            // 
            // lblToAddresses
            // 
            this.lblToAddresses.AutoSize = true;
            this.lblToAddresses.Location = new System.Drawing.Point(26, 30);
            this.lblToAddresses.Name = "lblToAddresses";
            this.lblToAddresses.Size = new System.Drawing.Size(20, 13);
            this.lblToAddresses.TabIndex = 1;
            this.lblToAddresses.Text = "To";
            // 
            // cbxEmailNotification
            // 
            this.cbxEmailNotification.AutoSize = true;
            this.cbxEmailNotification.Location = new System.Drawing.Point(29, 6);
            this.cbxEmailNotification.Name = "cbxEmailNotification";
            this.cbxEmailNotification.Size = new System.Drawing.Size(140, 17);
            this.cbxEmailNotification.TabIndex = 0;
            this.cbxEmailNotification.Text = "Send Email Notifications";
            this.cbxEmailNotification.UseVisualStyleBackColor = true;
            this.cbxEmailNotification.CheckedChanged += new System.EventHandler(this.cbxEmailNotification_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(322, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.tpSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxBody;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxBCC;
        private System.Windows.Forms.TextBox tbxCC;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblBCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.CheckBox cbxEmailFileWithNotification;
        private System.Windows.Forms.Label lblToAddresses;
        private System.Windows.Forms.CheckBox cbxEmailNotification;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.HelpProvider hpMask;
    }
}