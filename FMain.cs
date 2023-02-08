using System.Diagnostics;

namespace OneDriveSuspender
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            lblConfirm.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectAppToActivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Application (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            { tBoxAppToActivate.Text = openFileDialog1.FileName; }
            else
            { tBoxAppToActivate.Text = ""; }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tBoxAppToActivate.Text != "")
                CreateBatFile(tBoxAppToActivate.Text);
        }

        private void CreateBatFile(string filePath)
        {
            string cd = System.IO.Directory.GetCurrentDirectory();
            string appName = filePath.Split(@"\").Last();

            StreamWriter w = new StreamWriter($@"{cd}\{appName}.bat");

            w.WriteLine("@ECHO OFF");
            w.WriteLine("pssuspend onedrive");
            w.WriteLine($"START /W \"\" \"{filePath}\"");
            w.WriteLine("ECHO Resuming OneDrive...");
            w.WriteLine("pssuspend -r onedrive");
            w.WriteLine("TIMEOUT /T 3");
            w.Close();

            lblConfirm.Text = ".bat Created!";
        }
    }
}