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
            furnitureIdTextBox = new TextBox();
            label2 = new Label();
            funitureStyleComboBox = new ComboBox();
            furnitureCategoryComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            furnitureIdSeachButton = new Button();
            funitureId = new ColumnHeader();
            styleColumn = new ColumnHeader();
            categoryColumn = new ColumnHeader();
            FurnitureListView = new ListView();
            qtyColumn = new ColumnHeader();
            rateColumn = new ColumnHeader();
            StartTransactionButton = new Button();
            AddItemButton = new Button();
            ActiveRentalsButton = new Button();
            ClearMemberSearchButton = new Button();
            clearFurnitureSearchButton = new Button();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(141, 7);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(77, 31);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // EmployeeLabel
            // 
            EmployeeLabel.AutoSize = true;
            EmployeeLabel.Location = new Point(14, 12);
            EmployeeLabel.Name = "EmployeeLabel";
            EmployeeLabel.Size = new Size(50, 20);
            EmployeeLabel.TabIndex = 1;
            EmployeeLabel.Text = "label1";
            // 
            // AddMemberButton
            // 
            AddMemberButton.Location = new Point(877, 45);
            AddMemberButton.Margin = new Padding(3, 4, 3, 4);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(122, 31);
            AddMemberButton.TabIndex = 2;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // MembersListView
            // 
            MembersListView.Columns.AddRange(new ColumnHeader[] { MemberIdColumn, FirstnameColumn, LastnameColumn, Phonecolumn });
            MembersListView.FullRowSelect = true;
            MembersListView.Location = new Point(514, 45);
            MembersListView.Margin = new Padding(3, 4, 3, 4);
            MembersListView.Name = "MembersListView";
            MembersListView.Size = new Size(355, 524);
            MembersListView.TabIndex = 6;
            MembersListView.UseCompatibleStateImageBehavior = false;
            MembersListView.View = System.Windows.Forms.View.Details;
            MembersListView.MouseDoubleClick += MembersListView_MouseDoubleClick;
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
            memberSearchComboBox.Location = new Point(877, 467);
            memberSearchComboBox.Margin = new Padding(3, 4, 3, 4);
            memberSearchComboBox.Name = "memberSearchComboBox";
            memberSearchComboBox.Size = new Size(122, 28);
            memberSearchComboBox.TabIndex = 7;
            memberSearchComboBox.SelectedIndexChanged += memberSearchComboBox_SelectedIndexChanged;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(877, 505);
            memberSearchButton.Margin = new Padding(3, 4, 3, 4);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(122, 31);
            memberSearchButton.TabIndex = 8;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // multiSearchBox
            // 
            multiSearchBox.Location = new Point(877, 407);
            multiSearchBox.Margin = new Padding(3, 4, 3, 4);
            multiSearchBox.Name = "multiSearchBox";
            multiSearchBox.Size = new Size(122, 27);
            multiSearchBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(877, 348);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(122, 27);
            firstNameTextBox.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(877, 324);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First name:";
            // 
            // multiSearchLabel
            // 
            multiSearchLabel.AutoSize = true;
            multiSearchLabel.Location = new Point(877, 383);
            multiSearchLabel.Name = "multiSearchLabel";
            multiSearchLabel.Size = new Size(79, 20);
            multiSearchLabel.TabIndex = 12;
            multiSearchLabel.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(877, 441);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 13;
            label1.Text = "Search by:";
            // 
            // furnitureIdTextBox
            // 
            furnitureIdTextBox.Location = new Point(14, 348);
            furnitureIdTextBox.Margin = new Padding(3, 4, 3, 4);
            furnitureIdTextBox.Name = "furnitureIdTextBox";
            furnitureIdTextBox.Size = new Size(114, 27);
            furnitureIdTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 324);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 15;
            label2.Text = "Id:";
            // 
            // funitureStyleComboBox
            // 
            funitureStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            funitureStyleComboBox.FormattingEnabled = true;
            funitureStyleComboBox.Location = new Point(14, 407);
            funitureStyleComboBox.Margin = new Padding(3, 4, 3, 4);
            funitureStyleComboBox.Name = "funitureStyleComboBox";
            funitureStyleComboBox.Size = new Size(114, 28);
            funitureStyleComboBox.TabIndex = 16;
            // 
            // furnitureCategoryComboBox
            // 
            furnitureCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoryComboBox.FormattingEnabled = true;
            furnitureCategoryComboBox.Location = new Point(14, 465);
            furnitureCategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            furnitureCategoryComboBox.Name = "furnitureCategoryComboBox";
            furnitureCategoryComboBox.Size = new Size(114, 28);
            furnitureCategoryComboBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 383);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 18;
            label3.Text = "Style:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 441);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 19;
            label4.Text = "Category:";
            // 
            // furnitureIdSeachButton
            // 
            furnitureIdSeachButton.Location = new Point(14, 504);
            furnitureIdSeachButton.Margin = new Padding(3, 4, 3, 4);
            furnitureIdSeachButton.Name = "furnitureIdSeachButton";
            furnitureIdSeachButton.Size = new Size(114, 31);
            furnitureIdSeachButton.TabIndex = 20;
            furnitureIdSeachButton.Text = "Search";
            furnitureIdSeachButton.UseVisualStyleBackColor = true;
            furnitureIdSeachButton.Click += furnitureIdSearchButton_Click;
            // 
            // funitureId
            // 
            funitureId.Text = "ID";
            funitureId.Width = 45;
            // 
            // styleColumn
            // 
            styleColumn.Text = "Style";
            styleColumn.Width = 65;
            // 
            // categoryColumn
            // 
            categoryColumn.Text = "Category";
            categoryColumn.Width = 75;
            // 
            // FurnitureListView
            // 
            FurnitureListView.Columns.AddRange(new ColumnHeader[] { funitureId, styleColumn, categoryColumn, qtyColumn, rateColumn });
            FurnitureListView.FullRowSelect = true;
            FurnitureListView.Location = new Point(141, 45);
            FurnitureListView.Margin = new Padding(3, 4, 3, 4);
            FurnitureListView.Name = "FurnitureListView";
            FurnitureListView.Size = new Size(366, 524);
            FurnitureListView.TabIndex = 5;
            FurnitureListView.UseCompatibleStateImageBehavior = false;
            FurnitureListView.View = System.Windows.Forms.View.Details;
            // 
            // qtyColumn
            // 
            qtyColumn.Text = "Qty";
            qtyColumn.Width = 55;
            // 
            // rateColumn
            // 
            rateColumn.Text = "Rate";
            rateColumn.Width = 65;
            // 
            // StartTransactionButton
            // 
            StartTransactionButton.Location = new Point(14, 71);
            StartTransactionButton.Margin = new Padding(3, 4, 3, 4);
            StartTransactionButton.Name = "StartTransactionButton";
            StartTransactionButton.Size = new Size(94, 59);
            StartTransactionButton.TabIndex = 21;
            StartTransactionButton.Text = "Start Transaction";
            StartTransactionButton.UseVisualStyleBackColor = true;
            StartTransactionButton.Click += StartTransactionButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(14, 153);
            AddItemButton.Margin = new Padding(3, 4, 3, 4);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(86, 31);
            AddItemButton.TabIndex = 22;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Visible = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ActiveRentalsButton
            // 
            ActiveRentalsButton.Location = new Point(877, 84);
            ActiveRentalsButton.Margin = new Padding(3, 4, 3, 4);
            ActiveRentalsButton.Name = "ActiveRentalsButton";
            ActiveRentalsButton.Size = new Size(122, 60);
            ActiveRentalsButton.TabIndex = 23;
            ActiveRentalsButton.Text = "See Active Rentals";
            ActiveRentalsButton.UseVisualStyleBackColor = true;
            ActiveRentalsButton.Click += ActiveRentalsButton_Click;
            // 
            // ClearMemberSearchButton
            // 
            ClearMemberSearchButton.Location = new Point(877, 544);
            ClearMemberSearchButton.Margin = new Padding(3, 4, 3, 4);
            ClearMemberSearchButton.Name = "ClearMemberSearchButton";
            ClearMemberSearchButton.Size = new Size(122, 31);
            ClearMemberSearchButton.TabIndex = 24;
            ClearMemberSearchButton.Text = "Clear search";
            ClearMemberSearchButton.UseVisualStyleBackColor = true;
            ClearMemberSearchButton.Click += ClearMemberSearchButton_Click;
            // 
            // clearFurnitureSearchButton
            // 
            clearFurnitureSearchButton.Location = new Point(14, 544);
            clearFurnitureSearchButton.Margin = new Padding(3, 4, 3, 4);
            clearFurnitureSearchButton.Name = "clearFurnitureSearchButton";
            clearFurnitureSearchButton.Size = new Size(114, 31);
            clearFurnitureSearchButton.TabIndex = 25;
            clearFurnitureSearchButton.Text = "Clear search";
            clearFurnitureSearchButton.UseVisualStyleBackColor = true;
            clearFurnitureSearchButton.Click += clearFurnitureSearchButton_Click;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 600);
            Controls.Add(clearFurnitureSearchButton);
            Controls.Add(ClearMemberSearchButton);
            Controls.Add(ActiveRentalsButton);
            Controls.Add(AddItemButton);
            Controls.Add(StartTransactionButton);
            Controls.Add(furnitureIdSeachButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(furnitureCategoryComboBox);
            Controls.Add(funitureStyleComboBox);
            Controls.Add(label2);
            Controls.Add(furnitureIdTextBox);
            Controls.Add(label1);
            Controls.Add(multiSearchLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(multiSearchBox);
            Controls.Add(memberSearchButton);
            Controls.Add(memberSearchComboBox);
            Controls.Add(MembersListView);
            Controls.Add(FurnitureListView);
            Controls.Add(AddMemberButton);
            Controls.Add(EmployeeLabel);
            Controls.Add(LogoutButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mainpage";
            Text = "Mainpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutButton;
        private Label EmployeeLabel;
        private Button AddMemberButton;
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
        private TextBox furnitureIdTextBox;
        private Label label2;
        private ComboBox funitureStyleComboBox;
        private ComboBox furnitureCategoryComboBox;
        private Label label3;
        private Label label4;
        private Button furnitureIdSeachButton;
        private ColumnHeader funitureId;
        private ColumnHeader styleColumn;
        private ColumnHeader categoryColumn;
        private ListView FurnitureListView;
        private Button StartTransactionButton;
        private Button AddItemButton;
        private Button ActiveRentalsButton;
        private Button ClearMemberSearchButton;
        private Button clearFurnitureSearchButton;
        private ColumnHeader qtyColumn;
        private ColumnHeader rateColumn;
    }
}