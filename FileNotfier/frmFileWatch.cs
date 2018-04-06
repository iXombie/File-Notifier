using System;
using System.Windows.Forms;
using System.IO;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace NewFileNotfier
{
    public partial class frmFileWatch : Form
    {
        private const int timeOut = 30;
        private const string REPLACE_PATH = "{FILEPATH}";
        private const string REPLACE_FILENAME = "{FILENAME}";
        private FileWatcher _fileWatcher;
        private string _path;
        private string _mask;

        public frmFileWatch()
        {
            InitializeComponent();
            SetFormFields();
        }

        public void SetFormFields()
        {
            tbMask.Text = Settings.Default.Mask;
            tbPath.Text = Settings.Default.Path;
        }

        private bool validReadyState()
        {
            var path = tbPath.Text;
            if (String.IsNullOrWhiteSpace(path))
            {
                showErrorAlert("Enter a path");
                return false;
            }

            if (!Directory.Exists(path))
            {
                showErrorAlert("Enter a valid path");
                return false;
            }
            _path = path;

            var mask = tbMask.Text;
            _mask = mask;

            Settings.Default.Path = _path;
            Settings.Default.Mask = _mask;
            Settings.Default.Save();

            return true;
        }

        private void showErrorAlert(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void notifyMessage(string message)
        {
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(timeOut);
        }

        private void toggleUiState() 
        {
            if (fileWatcherRunning())
            {
                btnStartProcess.Text = "Stop";
                tbMask.Enabled = false;
                tbPath.Enabled = false;
            }
            else
            {
                btnStartProcess.Text = "Start";
                tbMask.Enabled = true;
                tbPath.Enabled = true;
            }
        }

        private void fileWatcher_FileAdded(object sender, FileSystemEventArgs e)
        {
            var message = "New File " + e.Name + " has been added.";
            notifyMessage(message);
            if (Settings.Default.SendEmailNotification)
            {
                sendEmail(e.FullPath, e.Name);
            }
        }

        private void sendEmail(string path, string filename)
        {
            var email = new Email();

#if DEBUG
            email.ToAddresses = "test@gmail.com";
            email.FromAddress = "test@test.net";

#else
            email.ToAddresses = Settings.Default.ToAddresses;
            email.FromAddress = Settings.Default.EmailFromAddress;
            email.CCAddresses = Settings.Default.CCAddresses;
            email.BCCAddresses = Settings.Default.BCCAddresses;
#endif

            email.Subject = Settings.Default.EmailSubject;
            email.Body = Settings.Default.EmailBody;

            email.Subject = email.Subject.Replace(REPLACE_PATH, path);
            email.Subject = email.Subject.Replace(REPLACE_FILENAME, filename);

            email.Body = email.Body.Replace(REPLACE_PATH, path);
            email.Body = email.Body.Replace(REPLACE_FILENAME, filename);

            if (Settings.Default.EmailSendFile)
            {
                email.Attachement = path;
            }
            
            email.Send();
        }

        private bool fileWatcherRunning()
        {
            return (_fileWatcher != null && _fileWatcher.Running);
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            using (var fdb = new FolderBrowserDialog())
            {
                fdb.ShowNewFolderButton = false;
                fdb.RootFolder = Environment.SpecialFolder.Desktop;

                DialogResult result = fdb.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !String.IsNullOrWhiteSpace(fdb.SelectedPath))
                {
                    tbPath.Text = fdb.SelectedPath;
                }
            }
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            if (fileWatcherRunning())
            {
                _fileWatcher.Stop();
                _fileWatcher = null;
                
            }
            else if (validReadyState())
            { 
                _fileWatcher = new FileWatcher(_path, _mask);
                _fileWatcher.NewFileAddedEvent += fileWatcher_FileAdded;
                _fileWatcher.Start();
            }
            toggleUiState();
        }

        private void frmFileWatch_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var settingsForm = new frmSettings();
            settingsForm.Show();
        }

        private void frmFileWatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileWatcherRunning() && MessageBox.Show("Are you sure you want to exit?", "Information", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
                        
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            notifyIcon = null;
        }
    }
}
