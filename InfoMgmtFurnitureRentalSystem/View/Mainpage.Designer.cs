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
            queryButton = new Button();
            reportButton = new Button();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(123, 5);
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
            AddMemberButton.Location = new Point(767, 34);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(107, 23);
            AddMemberButton.TabIndex = 2;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // MembersListView
            // 
            MembersListView.Columns.AddRange(new ColumnHeader[] { MemberIdColumn, FirstnameColumn, LastnameColumn, Phonecolumn });
            MembersListView.FullRowSelect = true;
            MembersListView.Location = new Point(450, 34);
            MembersListView.Name = "MembersListView";
            MembersListView.Size = new Size(311, 394);
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
            memberSearchComboBox.Location = new Point(767, 350);
            memberSearchComboBox.Name = "memberSearchComboBox";
            memberSearchComboBox.Size = new Size(107, 23);
            memberSearchComboBox.TabIndex = 7;
            memberSearchComboBox.SelectedIndexChanged += memberSearchComboBox_SelectedIndexChanged;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(767, 379);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(107, 23);
            memberSearchButton.TabIndex = 8;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // multiSearchBox
            // 
            multiSearchBox.Location = new Point(767, 305);
            multiSearchBox.Name = "multiSearchBox";
            multiSearchBox.Size = new Size(107, 23);
            multiSearchBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(767, 261);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(107, 23);
            firstNameTextBox.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(767, 243);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(65, 15);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First name:";
            // 
            // multiSearchLabel
            // 
            multiSearchLabel.AutoSize = true;
            multiSearchLabel.Location = new Point(767, 287);
            multiSearchLabel.Name = "multiSearchLabel";
            multiSearchLabel.Size = new Size(64, 15);
            multiSearchLabel.TabIndex = 12;
            multiSearchLabel.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(767, 331);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 13;
            label1.Text = "Search by:";
            // 
            // furnitureIdTextBox
            // 
            furnitureIdTextBox.Location = new Point(12, 261);
            furnitureIdTextBox.Name = "furnitureIdTextBox";
            furnitureIdTextBox.Size = new Size(100, 23);
            furnitureIdTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 15;
            label2.Text = "Id:";
            // 
            // funitureStyleComboBox
            // 
            funitureStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            funitureStyleComboBox.FormattingEnabled = true;
            funitureStyleComboBox.Location = new Point(12, 305);
            funitureStyleComboBox.Name = "funitureStyleComboBox";
            funitureStyleComboBox.Size = new Size(100, 23);
            funitureStyleComboBox.TabIndex = 16;
            // 
            // furnitureCategoryComboBox
            // 
            furnitureCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoryComboBox.FormattingEnabled = true;
            furnitureCategoryComboBox.Location = new Point(12, 349);
            furnitureCategoryComboBox.Name = "furnitureCategoryComboBox";
            furnitureCategoryComboBox.Size = new Size(100, 23);
            furnitureCategoryComboBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 287);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 18;
            label3.Text = "Style:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 331);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 19;
            label4.Text = "Category:";
            // 
            // furnitureIdSeachButton
            // 
            furnitureIdSeachButton.Location = new Point(12, 378);
            furnitureIdSeachButton.Name = "furnitureIdSeachButton";
            furnitureIdSeachButton.Size = new Size(100, 23);
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
            FurnitureListView.Location = new Point(123, 34);
            FurnitureListView.Name = "FurnitureListView";
            FurnitureListView.Size = new Size(321, 394);
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
            StartTransactionButton.Location = new Point(12, 53);
            StartTransactionButton.Name = "StartTransactionButton";
            StartTransactionButton.Size = new Size(82, 44);
            StartTransactionButton.TabIndex = 21;
            StartTransactionButton.Text = "Start Transaction";
            StartTransactionButton.UseVisualStyleBackColor = true;
            StartTransactionButton.Click += StartTransactionButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(12, 115);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 23);
            AddItemButton.TabIndex = 22;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Visible = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ActiveRentalsButton
            // 
            ActiveRentalsButton.Location = new Point(767, 63);
            ActiveRentalsButton.Name = "ActiveRentalsButton";
            ActiveRentalsButton.Size = new Size(107, 45);
            ActiveRentalsButton.TabIndex = 23;
            ActiveRentalsButton.Text = "See Active Rentals";
            ActiveRentalsButton.UseVisualStyleBackColor = true;
            ActiveRentalsButton.Click += ActiveRentalsButton_Click;
            // 
            // ClearMemberSearchButton
            // 
            ClearMemberSearchButton.Location = new Point(767, 408);
            ClearMemberSearchButton.Name = "ClearMemberSearchButton";
            ClearMemberSearchButton.Size = new Size(107, 23);
            ClearMemberSearchButton.TabIndex = 24;
            ClearMemberSearchButton.Text = "Clear search";
            ClearMemberSearchButton.UseVisualStyleBackColor = true;
            ClearMemberSearchButton.Click += ClearMemberSearchButton_Click;
            // 
            // clearFurnitureSearchButton
            // 
            clearFurnitureSearchButton.Location = new Point(12, 408);
            clearFurnitureSearchButton.Name = "clearFurnitureSearchButton";
            clearFurnitureSearchButton.Size = new Size(100, 23);
            clearFurnitureSearchButton.TabIndex = 25;
            clearFurnitureSearchButton.Text = "Clear search";
            clearFurnitureSearchButton.UseVisualStyleBackColor = true;
            clearFurnitureSearchButton.Click += clearFurnitureSearchButton_Click;
            // 
            // queryButton
            // 
            queryButton.Location = new Point(196, 5);
            queryButton.Name = "queryButton";
            queryButton.Size = new Size(75, 23);
            queryButton.TabIndex = 26;
            queryButton.Text = "Query";
            queryButton.UseVisualStyleBackColor = true;
            queryButton.Click += queryButton_Click;
            // 
            // reportButton
            // 
            reportButton.Location = new Point(277, 5);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(82, 23);
            reportButton.TabIndex = 27;
            reportButton.Text = "Run Reports";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += reportButton_Click;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 450);
            Controls.Add(reportButton);
            Controls.Add(queryButton);
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
        private Button queryButton;
        private Button reportButton;
    }
}