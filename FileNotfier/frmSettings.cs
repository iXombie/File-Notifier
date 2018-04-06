using System;
using System.Windows.Forms;

namespace NewFileNotfier
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            LoadEmailSettings();
        }

        private void SaveEmailSettings()
        {
            Settings.Default.SendEmailNotification = cbxEmailNotification.Checked;
            Settings.Default.ToAddresses = tbxTo.Text;
            Settings.Default.CCAddresses = tbxCC.Text;
            Settings.Default.BCCAddresses = tbxBCC.Text;
            Settings.Default.EmailFromAddress = tbxFrom.Text;
            Settings.Default.EmailSubject = tbxSubject.Text;
            Settings.Default.EmailBody = tbxBody.Text;
            Settings.Default.EmailSendFile = cbxEmailFileWithNotification.Checked;
            Settings.Default.Save();
        }

        private void LoadEmailSettings()
        {
            cbxEmailNotification.Checked = Settings.Default.SendEmailNotification;
            tbxTo.Text = Settings.Default.ToAddresses;
            tbxCC.Text = Settings.Default.CCAddresses;
            tbxBCC.Text = Settings.Default.BCCAddresses;
            tbxFrom.Text = Settings.Default.EmailFromAddress;
            tbxSubject.Text = Settings.Default.EmailSubject;
            tbxBody.Text = Settings.Default.EmailBody;
            cbxEmailFileWithNotification.Checked = Settings.Default.EmailSendFile;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEmailSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEmailNotification_CheckedChanged(object sender, EventArgs e)
        {
            var status = cbxEmailNotification.Checked;
            tbxTo.Enabled = status;
            tbxCC.Enabled = status;
            tbxBCC.Enabled = status;
            tbxFrom.Enabled = status;
            tbxSubject.Enabled = status;
            tbxBody.Enabled = status;
            cbxEmailFileWithNotification.Enabled = status;
        }
    }
}
