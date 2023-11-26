namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class AdminQueryResultPage
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
            resultListView = new ListView();
            okButton = new Button();
            SuspendLayout();
            // 
            // resultListView
            // 
            resultListView.Location = new Point(12, 12);
            resultListView.Name = "resultListView";
            resultListView.Size = new Size(514, 382);
            resultListView.TabIndex = 0;
            resultListView.UseCompatibleStateImageBehavior = false;
            resultListView.View = System.Windows.Forms.View.Details;
            // 
            // okButton
            // 
            okButton.Location = new Point(186, 400);
            okButton.Name = "okButton";
            okButton.Size = new Size(155, 38);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // AdminQueryResultPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(okButton);
            Controls.Add(resultListView);
            Name = "AdminQueryResultPage";
            Text = "AdminQueryResultPage";
            ResumeLayout(false);
        }

        #endregion

        private ListView resultListView;
        private Button okButton;
    }
}