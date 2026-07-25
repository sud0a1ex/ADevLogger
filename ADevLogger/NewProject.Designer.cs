namespace ADevLogger
{
    partial class NewProject
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
            LabelProjectName = new Label();
            BoxProjectName = new TextBox();
            ButtonDirectory = new Button();
            ButtonMarkdown = new Button();
            ButtonCreate = new Button();
            LabelInfo = new Label();
            SuspendLayout();
            // 
            // LabelProjectName
            // 
            LabelProjectName.AutoSize = true;
            LabelProjectName.BackColor = Color.Transparent;
            LabelProjectName.Location = new Point(12, 9);
            LabelProjectName.Name = "LabelProjectName";
            LabelProjectName.Size = new Size(102, 20);
            LabelProjectName.TabIndex = 0;
            LabelProjectName.Text = "Project Name:";
            // 
            // BoxProjectName
            // 
            BoxProjectName.BackColor = Color.FromArgb(40, 40, 40);
            BoxProjectName.BorderStyle = BorderStyle.FixedSingle;
            BoxProjectName.ForeColor = Color.WhiteSmoke;
            BoxProjectName.Location = new Point(15, 32);
            BoxProjectName.MaxLength = 128;
            BoxProjectName.Name = "BoxProjectName";
            BoxProjectName.PlaceholderText = "Max 128 characters";
            BoxProjectName.Size = new Size(385, 27);
            BoxProjectName.TabIndex = 1;
            // 
            // ButtonDirectory
            // 
            ButtonDirectory.BackColor = Color.Transparent;
            ButtonDirectory.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonDirectory.FlatStyle = FlatStyle.Flat;
            ButtonDirectory.Location = new Point(15, 65);
            ButtonDirectory.Name = "ButtonDirectory";
            ButtonDirectory.Size = new Size(127, 37);
            ButtonDirectory.TabIndex = 2;
            ButtonDirectory.Text = "Select Directory";
            ButtonDirectory.UseVisualStyleBackColor = false;
            ButtonDirectory.Click += ButtonDirectory_Click;
            // 
            // ButtonMarkdown
            // 
            ButtonMarkdown.BackColor = Color.Transparent;
            ButtonMarkdown.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonMarkdown.FlatStyle = FlatStyle.Flat;
            ButtonMarkdown.Location = new Point(148, 65);
            ButtonMarkdown.Name = "ButtonMarkdown";
            ButtonMarkdown.Size = new Size(150, 37);
            ButtonMarkdown.TabIndex = 3;
            ButtonMarkdown.Text = "Select Markdown";
            ButtonMarkdown.UseVisualStyleBackColor = false;
            ButtonMarkdown.Click += ButtonMarkdown_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.Transparent;
            ButtonCreate.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonCreate.FlatStyle = FlatStyle.Flat;
            ButtonCreate.Location = new Point(15, 406);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(127, 35);
            ButtonCreate.TabIndex = 4;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // LabelInfo
            // 
            LabelInfo.AutoSize = true;
            LabelInfo.BackColor = Color.Transparent;
            LabelInfo.Location = new Point(15, 115);
            LabelInfo.Name = "LabelInfo";
            LabelInfo.Size = new Size(0, 20);
            LabelInfo.TabIndex = 5;
            // 
            // NewProject
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(482, 453);
            Controls.Add(LabelInfo);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonMarkdown);
            Controls.Add(ButtonDirectory);
            Controls.Add(BoxProjectName);
            Controls.Add(LabelProjectName);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "NewProject";
            Text = "ADevLogger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelProjectName;
        private TextBox BoxProjectName;
        private Button ButtonDirectory;
        private Button ButtonMarkdown;
        private Button ButtonCreate;
        private Label LabelInfo;
    }
}