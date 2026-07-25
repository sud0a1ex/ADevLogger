namespace ADevLogger
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonNew = new Button();
            ButtonOpen = new Button();
            splitContainer1 = new SplitContainer();
            ButtonAdd = new Button();
            BoxContent = new TextBox();
            LabelContent = new Label();
            BoxTopic = new TextBox();
            LabelTopic = new Label();
            LabelLogCount = new Label();
            BoxCurrentLog = new TextBox();
            LabelCurrentLog = new Label();
            LabelPathLog = new Label();
            LabelPathMarkdown = new Label();
            ButtonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonNew
            // 
            ButtonNew.BackColor = Color.Transparent;
            ButtonNew.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonNew.FlatStyle = FlatStyle.Flat;
            ButtonNew.Location = new Point(12, 12);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(113, 34);
            ButtonNew.TabIndex = 0;
            ButtonNew.Text = "New Project";
            ButtonNew.UseVisualStyleBackColor = false;
            ButtonNew.Click += ButtonNew_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.BackColor = Color.Transparent;
            ButtonOpen.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonOpen.FlatStyle = FlatStyle.Flat;
            ButtonOpen.Location = new Point(12, 52);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(113, 34);
            ButtonOpen.TabIndex = 1;
            ButtonOpen.Text = "Open Project";
            ButtonOpen.UseVisualStyleBackColor = false;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Enabled = false;
            splitContainer1.Location = new Point(131, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ButtonSave);
            splitContainer1.Panel1.Controls.Add(ButtonAdd);
            splitContainer1.Panel1.Controls.Add(BoxContent);
            splitContainer1.Panel1.Controls.Add(LabelContent);
            splitContainer1.Panel1.Controls.Add(BoxTopic);
            splitContainer1.Panel1.Controls.Add(LabelTopic);
            splitContainer1.Panel1.Controls.Add(LabelLogCount);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BoxCurrentLog);
            splitContainer1.Panel2.Controls.Add(LabelCurrentLog);
            splitContainer1.Size = new Size(639, 389);
            splitContainer1.SplitterDistance = 318;
            splitContainer1.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonAdd.BackColor = Color.Transparent;
            ButtonAdd.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Location = new Point(9, 352);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(113, 34);
            ButtonAdd.TabIndex = 5;
            ButtonAdd.Text = "Add Log";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // BoxContent
            // 
            BoxContent.AcceptsReturn = true;
            BoxContent.AcceptsTab = true;
            BoxContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxContent.BackColor = Color.FromArgb(40, 40, 40);
            BoxContent.BorderStyle = BorderStyle.FixedSingle;
            BoxContent.ForeColor = Color.WhiteSmoke;
            BoxContent.Location = new Point(9, 122);
            BoxContent.MaxLength = 0;
            BoxContent.Multiline = true;
            BoxContent.Name = "BoxContent";
            BoxContent.ScrollBars = ScrollBars.Vertical;
            BoxContent.Size = new Size(290, 224);
            BoxContent.TabIndex = 4;
            // 
            // LabelContent
            // 
            LabelContent.AutoSize = true;
            LabelContent.Location = new Point(5, 99);
            LabelContent.Name = "LabelContent";
            LabelContent.Size = new Size(64, 20);
            LabelContent.TabIndex = 3;
            LabelContent.Text = "Content:";
            // 
            // BoxTopic
            // 
            BoxTopic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxTopic.BackColor = Color.FromArgb(40, 40, 40);
            BoxTopic.BorderStyle = BorderStyle.FixedSingle;
            BoxTopic.ForeColor = Color.WhiteSmoke;
            BoxTopic.Location = new Point(9, 69);
            BoxTopic.MaxLength = 128;
            BoxTopic.Name = "BoxTopic";
            BoxTopic.PlaceholderText = "Max 128 characters";
            BoxTopic.Size = new Size(290, 27);
            BoxTopic.TabIndex = 2;
            // 
            // LabelTopic
            // 
            LabelTopic.AutoSize = true;
            LabelTopic.Location = new Point(5, 46);
            LabelTopic.Name = "LabelTopic";
            LabelTopic.Size = new Size(48, 20);
            LabelTopic.TabIndex = 1;
            LabelTopic.Text = "Topic:";
            // 
            // LabelLogCount
            // 
            LabelLogCount.AutoSize = true;
            LabelLogCount.Location = new Point(5, 5);
            LabelLogCount.Name = "LabelLogCount";
            LabelLogCount.Size = new Size(80, 20);
            LabelLogCount.TabIndex = 0;
            LabelLogCount.Text = "Log Count:";
            // 
            // BoxCurrentLog
            // 
            BoxCurrentLog.AcceptsReturn = true;
            BoxCurrentLog.AcceptsTab = true;
            BoxCurrentLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxCurrentLog.BackColor = Color.FromArgb(40, 40, 40);
            BoxCurrentLog.BorderStyle = BorderStyle.FixedSingle;
            BoxCurrentLog.ForeColor = Color.LightGray;
            BoxCurrentLog.Location = new Point(7, 28);
            BoxCurrentLog.MaxLength = 0;
            BoxCurrentLog.Multiline = true;
            BoxCurrentLog.Name = "BoxCurrentLog";
            BoxCurrentLog.ReadOnly = true;
            BoxCurrentLog.ScrollBars = ScrollBars.Vertical;
            BoxCurrentLog.Size = new Size(307, 358);
            BoxCurrentLog.TabIndex = 6;
            // 
            // LabelCurrentLog
            // 
            LabelCurrentLog.AutoSize = true;
            LabelCurrentLog.Location = new Point(3, 5);
            LabelCurrentLog.Name = "LabelCurrentLog";
            LabelCurrentLog.Size = new Size(89, 20);
            LabelCurrentLog.TabIndex = 5;
            LabelCurrentLog.Text = "Current Log:";
            // 
            // LabelPathLog
            // 
            LabelPathLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelPathLog.AutoSize = true;
            LabelPathLog.BackColor = Color.Transparent;
            LabelPathLog.Location = new Point(131, 404);
            LabelPathLog.Name = "LabelPathLog";
            LabelPathLog.Size = new Size(111, 20);
            LabelPathLog.TabIndex = 3;
            LabelPathLog.Text = "File Path(.dlog):";
            // 
            // LabelPathMarkdown
            // 
            LabelPathMarkdown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelPathMarkdown.AutoSize = true;
            LabelPathMarkdown.BackColor = Color.Transparent;
            LabelPathMarkdown.Location = new Point(131, 426);
            LabelPathMarkdown.Name = "LabelPathMarkdown";
            LabelPathMarkdown.Size = new Size(102, 20);
            LabelPathMarkdown.TabIndex = 4;
            LabelPathMarkdown.Text = "File Path(.md):";
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.Transparent;
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Location = new Point(128, 352);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(113, 34);
            ButtonSave.TabIndex = 5;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(782, 453);
            Controls.Add(LabelPathMarkdown);
            Controls.Add(LabelPathLog);
            Controls.Add(splitContainer1);
            Controls.Add(ButtonOpen);
            Controls.Add(ButtonNew);
            ForeColor = Color.WhiteSmoke;
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            Text = "ADevLogger";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonNew;
        private Button ButtonOpen;
        private SplitContainer splitContainer1;
        private Label LabelPathLog;
        private Label LabelLogCount;
        private Label LabelTopic;
        private TextBox BoxTopic;
        private TextBox BoxContent;
        private Label LabelContent;
        private TextBox BoxCurrentLog;
        private Label LabelCurrentLog;
        private Button ButtonAdd;
        private Label LabelPathMarkdown;
        private Button ButtonSave;
    }
}
