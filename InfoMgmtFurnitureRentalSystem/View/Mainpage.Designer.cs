namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class Mainpage
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
            LogoutButton = new Button();
            EmployeeLabel = new Label();
            AddMemberButton = new Button();
            RemoveMemberButton = new Button();
            MembersListView = new ListView();
            FurnitureListView = new ListView();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(108, 5);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(67, 23);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // EmployeeLabel
            // 
            EmployeeLabel.AutoSize = true;
            EmployeeLabel.Location = new Point(12, 9);
            EmployeeLabel.Name = "EmployeeLabel";
            EmployeeLabel.Size = new Size(38, 15);
            EmployeeLabel.TabIndex = 1;
            EmployeeLabel.Text = "label1";
            // 
            // AddMemberButton
            // 
            AddMemberButton.Location = new Point(752, 183);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(107, 23);
            AddMemberButton.TabIndex = 2;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // RemoveMemberButton
            // 
            RemoveMemberButton.Location = new Point(752, 212);
            RemoveMemberButton.Name = "RemoveMemberButton";
            RemoveMemberButton.Size = new Size(107, 23);
            RemoveMemberButton.TabIndex = 3;
            RemoveMemberButton.Text = "Remove Member";
            RemoveMemberButton.UseVisualStyleBackColor = true;
            // 
            // MembersListView
            // 
            MembersListView.Location = new Point(435, 34);
            MembersListView.Name = "MembersListView";
            MembersListView.Size = new Size(311, 404);
            MembersListView.TabIndex = 4;
            MembersListView.UseCompatibleStateImageBehavior = false;
            // 
            // FurnitureListView
            // 
            FurnitureListView.Location = new Point(108, 34);
            FurnitureListView.Name = "FurnitureListView";
            FurnitureListView.Size = new Size(321, 404);
            FurnitureListView.TabIndex = 5;
            FurnitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(FurnitureListView);
            Controls.Add(MembersListView);
            Controls.Add(RemoveMemberButton);
            Controls.Add(AddMemberButton);
            Controls.Add(EmployeeLabel);
            Controls.Add(LogoutButton);
            Name = "Mainpage";
            Text = "Mainpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutButton;
        private Label EmployeeLabel;
        private Button AddMemberButton;
        private Button RemoveMemberButton;
        private ListView MembersListView;
        private ListView FurnitureListView;
    }
}