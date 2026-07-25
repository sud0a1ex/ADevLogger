namespace ADevLogger
{
    public partial class NewProject : Form
    {
        private string? DirectoryPath, MarkdownPath;
        public NewProject()
        {
            InitializeComponent();
        }

        void UpdateInfoLabel()
        {
            LabelInfo.Text = "Project Info:\n";
            if (!string.IsNullOrEmpty(DirectoryPath))
                LabelInfo.Text += $"Directory Path: {DirectoryPath}\n";
            if (!string.IsNullOrEmpty(MarkdownPath))
                LabelInfo.Text += $"Markdown Path: {MarkdownPath}";
        }

        private void ButtonDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new()
            {
                UseDescriptionForTitle = true,
                Description = "Select a folder for ADevLogger project."
            };
            FolderBrowser.ShowDialog();
            DirectoryPath = FolderBrowser.SelectedPath;
            UpdateInfoLabel();
        }

        private void ButtonMarkdown_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileBrowser = new()
            {
                Title = "Select a Markdown file for ADevLogger to update.",
                Filter = "Markdown (*.md)|*.md"
            };
            FileBrowser.ShowDialog();
            MarkdownPath = FileBrowser.FileName;
            UpdateInfoLabel();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string ProjectLoaderFile = @$"{DirectoryPath}\{BoxProjectName.Text}.dlog";
            StreamWriter ProjectLoader = new(ProjectLoaderFile);
            ProjectLoader.Write($"log:0\nmarkdown:{MarkdownPath}");
            ProjectLoader.Close();
            MessageBox.Show("Project created!\nYou can now open the project in the editor.", "ADevLogger");
        }
    }
}
