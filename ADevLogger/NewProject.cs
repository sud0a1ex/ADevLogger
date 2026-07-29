namespace ADevLogger
{
    public partial class NewProject : Form
    {
        private string? DirectoryPath, MarkdownPath;
        public NewProject()
        {
            InitializeComponent();
        }

        // Update info label
        void UpdateInfoLabel()
        {
            LabelInfo.Text = "Project Info:\n";
            if (!string.IsNullOrEmpty(DirectoryPath))
                LabelInfo.Text += $"Directory Path: {DirectoryPath}\n";
            if (!string.IsNullOrEmpty(MarkdownPath))
                LabelInfo.Text += $"Markdown Path: {MarkdownPath}";
        }

        // Selecting a directory
        private void ButtonDirectory_Click(object sender, EventArgs e)
        {
            // Open folder browser
            FolderBrowserDialog FolderBrowser = new()
            {
                UseDescriptionForTitle = true,
                Description = "Select a folder for ADevLogger project."
            };
            FolderBrowser.ShowDialog();
            DirectoryPath = FolderBrowser.SelectedPath; // Set selected folder
            UpdateInfoLabel(); // Update the labels
        }

        // Selecting a markdown file
        private void ButtonMarkdown_Click(object sender, EventArgs e)
        {
            // Open file browser
            OpenFileDialog FileBrowser = new()
            {
                Title = "Select a Markdown file for ADevLogger to update.",
                Filter = "Markdown (*.md)|*.md"
            };
            FileBrowser.ShowDialog();
            MarkdownPath = FileBrowser.FileName; // Set selected markdown file
            UpdateInfoLabel(); // Update the labels
        }

        // Create project
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Project loader's path
            string ProjectLoaderFile = @$"{DirectoryPath}\{BoxProjectName.Text}.dlog";

            // Create project loader
            StreamWriter ProjectLoader = new(ProjectLoaderFile);
            ProjectLoader.Write($"log:0\nmarkdown:{MarkdownPath}"); // Write log count and markdown path
            ProjectLoader.Close();
            MessageBox.Show("Project created!\nYou can now open the project in the editor.", "ADevLogger");
        }
    }
}
