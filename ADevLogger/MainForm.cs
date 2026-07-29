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

        // Open "New Project" window
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            new NewProject().ShowDialog();
        }

        // Update log count(variable and label)
        void UpdateLogCount()
        {
            LogCount += 1;
            LabelLogCount.Text = $"Log Count: {LogCount}";
        }

        // Update info labels(log count, dlog path, and markdown path)
        void UpdateInfoLabels()
        {
            LabelLogCount.Text = $"Log Count: {LogCount}";
            LabelPathLog.Text = $"File Path(.dlog): {ProjectPath}";
            LabelPathMarkdown.Text = $"File Path(.md): {MarkdownPath}";
        }

        // Check project loader(.dlog file)
        void CheckProjectLoader(string FilePath)
        {
            // Read text inside project loader
            StreamReader ReadProject = new(FilePath);
            string[] ProjectLoader = ReadProject.ReadToEnd().Split("\n");
            ReadProject.Close();

            // Check project loader format
            if (!ProjectLoader[0].StartsWith("log:") || !ProjectLoader[1].StartsWith("markdown:") || !char.IsDigit(ProjectLoader[0].Remove(0, 4)[0]))
                MessageBox.Show("Invalid project loader.", "ADevLogger", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // If format is correct, continue
            // Parse info from project loader
            LogCount = int.Parse(ProjectLoader[0].Remove(0, 4)); // Get latest log count
            MarkdownPath = ProjectLoader[1].Remove(0, 9); // Get markdown path
            UpdateInfoLabels(); // Update to labels
            splitContainer1.Enabled = true; // Enable editor

            // Read markdown
            StreamReader ReadMarkdown = new(MarkdownPath);
            string Markdown = ReadMarkdown.ReadToEnd();
            ReadMarkdown.Close();
            BoxCurrentLog.Text = Markdown; // Set current log textbox to text from markdown
        }

        // Open a project
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            // Open file browser
            OpenFileDialog FileBrowser = new()
            {
                Title = "Select ADevLogger project loader.",
                Filter = "ADevLogger (*.dlog)|*.dlog"
            };
            FileBrowser.ShowDialog();

            // Check if file is not null
            if (!string.IsNullOrEmpty(FileBrowser.FileName))
            {
                ProjectPath = FileBrowser.FileName; // Set project path to selected file
                CheckProjectLoader(ProjectPath); // Send file to check if valid
            }
        }

        // Add log to current log textbox
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            UpdateLogCount();
            DateTime CurrentTime = DateTime.UtcNow;
            BoxCurrentLog.Text += $"Log {LogCount} - [ @{CurrentTime.Hour}:{CurrentTime.Minute}:{CurrentTime.Second} {CurrentTime.Month}/{CurrentTime.Day}/{CurrentTime.Year}]\r\nTopic: {BoxTopic.Text}\r\n\r\n{BoxContent.Text}\r\n\r\n";
            BoxTopic.Text = BoxContent.Text = "";
        }

        // Save updated log
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Check if a project is opened
            if(!string.IsNullOrEmpty(ProjectPath) && !string.IsNullOrEmpty(MarkdownPath))
            {
                // Rewrite project loader with new log count
                StreamWriter RewriteLoader = new(ProjectPath);
                RewriteLoader.Write($"log:{LogCount}\nmarkdown:{MarkdownPath}");
                RewriteLoader.Close();

                // Rewrite markdown with new log
                StreamWriter RewriteMarkdown = new(MarkdownPath);
                RewriteMarkdown.Write(BoxCurrentLog.Text);
                RewriteMarkdown.Close();

                MessageBox.Show("Project saved successfully!", "ADevLogger");
            }
        }
    }
}
