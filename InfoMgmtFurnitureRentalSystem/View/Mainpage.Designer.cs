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
            FurnitureListView = new ListView();
            MembersListView = new ListView();
            MemberIdColumn = new ColumnHeader();
            FirstnameColumn = new ColumnHeader();
            LastnameColumn = new ColumnHeader();
            Phonecolumn = new ColumnHeader();
            memberSearchComboBox = new ComboBox();
            memberSearchButton = new Button();
            multiSearchBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            multiSearchLabel = new Label();
            label1 = new Label();
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
            // FurnitureListView
            // 
            FurnitureListView.Location = new Point(108, 34);
            FurnitureListView.Name = "FurnitureListView";
            FurnitureListView.Size = new Size(321, 394);
            FurnitureListView.TabIndex = 5;
            FurnitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // MembersListView
            // 
            MembersListView.Columns.AddRange(new ColumnHeader[] { MemberIdColumn, FirstnameColumn, LastnameColumn, Phonecolumn });
            MembersListView.Location = new Point(435, 34);
            MembersListView.Name = "MembersListView";
            MembersListView.Size = new Size(311, 394);
            MembersListView.TabIndex = 6;
            MembersListView.UseCompatibleStateImageBehavior = false;
            MembersListView.View = System.Windows.Forms.View.Details;
            // 
            // MemberIdColumn
            // 
            MemberIdColumn.Text = "ID";
            // 
            // FirstnameColumn
            // 
            FirstnameColumn.Text = "First name";
            FirstnameColumn.Width = 80;
            // 
            // LastnameColumn
            // 
            LastnameColumn.Text = "Last name";
            LastnameColumn.Width = 80;
            // 
            // Phonecolumn
            // 
            Phonecolumn.Text = "Phone";
            Phonecolumn.Width = 88;
            // 
            // memberSearchComboBox
            // 
            memberSearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberSearchComboBox.FormattingEnabled = true;
            memberSearchComboBox.Location = new Point(752, 376);
            memberSearchComboBox.Name = "memberSearchComboBox";
            memberSearchComboBox.Size = new Size(107, 23);
            memberSearchComboBox.TabIndex = 7;
            memberSearchComboBox.SelectedIndexChanged += memberSearchComboBox_SelectedIndexChanged;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(752, 405);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(107, 23);
            memberSearchButton.TabIndex = 8;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // multiSearchBox
            // 
            multiSearchBox.Location = new Point(752, 331);
            multiSearchBox.Name = "multiSearchBox";
            multiSearchBox.Size = new Size(107, 23);
            multiSearchBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(752, 287);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(107, 23);
            firstNameTextBox.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(752, 269);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(65, 15);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First name:";
            // 
            // multiSearchLabel
            // 
            multiSearchLabel.AutoSize = true;
            multiSearchLabel.Location = new Point(753, 313);
            multiSearchLabel.Name = "multiSearchLabel";
            multiSearchLabel.Size = new Size(64, 15);
            multiSearchLabel.TabIndex = 12;
            multiSearchLabel.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 358);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 13;
            label1.Text = "Search by:";
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(label1);
            Controls.Add(multiSearchLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(multiSearchBox);
            Controls.Add(memberSearchButton);
            Controls.Add(memberSearchComboBox);
            Controls.Add(MembersListView);
            Controls.Add(FurnitureListView);
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
        private ListView FurnitureListView;
        private ListView MembersListView;
        private ColumnHeader FirstnameColumn;
        private ColumnHeader LastnameColumn;
        private ColumnHeader Phonecolumn;
        private ColumnHeader MemberIdColumn;
        private ComboBox memberSearchComboBox;
        private Button memberSearchButton;
        private TextBox multiSearchBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label multiSearchLabel;
        private Label label1;
    }
}