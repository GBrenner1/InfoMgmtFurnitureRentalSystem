namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class AdminQueryPage
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
            backButton = new Button();
            QueryButton = new Button();
            QueryTextArea = new RichTextBox();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 388);
            backButton.Name = "backButton";
            backButton.Size = new Size(134, 50);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // QueryButton
            // 
            QueryButton.Location = new Point(324, 388);
            QueryButton.Name = "QueryButton";
            QueryButton.Size = new Size(134, 50);
            QueryButton.TabIndex = 1;
            QueryButton.Text = "Run Query";
            QueryButton.UseVisualStyleBackColor = true;
            QueryButton.Click += QueryButton_Click;
            // 
            // QueryTextArea
            // 
            QueryTextArea.AcceptsTab = true;
            QueryTextArea.Location = new Point(12, 12);
            QueryTextArea.Name = "QueryTextArea";
            QueryTextArea.Size = new Size(446, 360);
            QueryTextArea.TabIndex = 2;
            QueryTextArea.Text = "";
            // 
            // AdminQueryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(QueryTextArea);
            Controls.Add(QueryButton);
            Controls.Add(backButton);
            Name = "AdminQueryPage";
            Text = "AdminQueryPage";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button QueryButton;
        private RichTextBox QueryTextArea;
    }
}