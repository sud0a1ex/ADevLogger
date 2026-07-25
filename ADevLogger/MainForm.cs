namespace ADevLogger
{
    public partial class MainForm : Form
    {
        private int LogCount;
        private string? MarkdownPath, ProjectPath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            new NewProject().ShowDialog();
        }

        void UpdateLogCount()
        {
            LogCount += 1;
            LabelLogCount.Text = $"Log Count: {LogCount}";
        }

        void UpdateInfoLabels()
        {
            LabelLogCount.Text = $"Log Count: {LogCount}";
            LabelPathLog.Text = $"File Path(.dlog): {ProjectPath}";
            LabelPathMarkdown.Text = $"File Path(.md): {MarkdownPath}";
        }

        void CheckProjectLoader(string FilePath)
        {
            StreamReader ReadProject = new(FilePath);
            string[] ProjectLoader = ReadProject.ReadToEnd().Split("\n");
            ReadProject.Close();
            if (!ProjectLoader[0].StartsWith("log:") || !ProjectLoader[1].StartsWith("markdown:") || !char.IsDigit(ProjectLoader[0].Remove(0, 4)[0]))
                MessageBox.Show("Invalid project loader.", "ADevLogger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogCount = int.Parse(ProjectLoader[0].Remove(0, 4));
            MarkdownPath = ProjectLoader[1].Remove(0, 9);
            UpdateInfoLabels();
            splitContainer1.Enabled = true;
            StreamReader ReadMarkdown = new(MarkdownPath);
            string Markdown = ReadMarkdown.ReadToEnd();
            ReadMarkdown.Close();
            BoxCurrentLog.Text = Markdown;
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileBrowser = new()
            {
                Title = "Select ADevLogger project loader.",
                Filter = "ADevLogger (*.dlog)|*.dlog"
            };
            FileBrowser.ShowDialog();
            if (!string.IsNullOrEmpty(FileBrowser.FileName))
            {
                ProjectPath = FileBrowser.FileName;
                CheckProjectLoader(ProjectPath);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            UpdateLogCount();
            DateTime CurrentTime = DateTime.UtcNow;
            BoxCurrentLog.Text += $"Log {LogCount} - [ @{CurrentTime.Hour}:{CurrentTime.Minute}:{CurrentTime.Second} {CurrentTime.Month}/{CurrentTime.Day}/{CurrentTime.Year}]\r\nTopic: {BoxTopic.Text}\r\n\r\n{BoxContent.Text}\r\n\r\n";
            BoxTopic.Text = BoxContent.Text = "";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ProjectPath) && !string.IsNullOrEmpty(MarkdownPath))
            {
                StreamWriter RewriteLoader = new(ProjectPath);
                RewriteLoader.Write($"log:{LogCount}\nmarkdown:{MarkdownPath}");
                RewriteLoader.Close();

                StreamWriter RewriteMarkdown = new(MarkdownPath);
                RewriteMarkdown.Write(BoxCurrentLog.Text);
                RewriteMarkdown.Close();
            }
        }
    }
}
