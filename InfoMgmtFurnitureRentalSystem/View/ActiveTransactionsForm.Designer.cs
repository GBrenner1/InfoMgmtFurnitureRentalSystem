namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class ActiveTransactionsForm
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
            ActiveRentedFurnitureList = new ListView();
            Id = new ColumnHeader();
            Style = new ColumnHeader();
            Category = new ColumnHeader();
            rentalRate = new ColumnHeader();
            Qty = new ColumnHeader();
            dueDate = new ColumnHeader();
            returnButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ActiveRentedFurnitureList
            // 
            ActiveRentedFurnitureList.CheckBoxes = true;
            ActiveRentedFurnitureList.Columns.AddRange(new ColumnHeader[] { Id, Style, Category, rentalRate, Qty, dueDate });
            ActiveRentedFurnitureList.Location = new Point(93, 12);
            ActiveRentedFurnitureList.Name = "ActiveRentedFurnitureList";
            ActiveRentedFurnitureList.Size = new Size(375, 426);
            ActiveRentedFurnitureList.TabIndex = 0;
            ActiveRentedFurnitureList.UseCompatibleStateImageBehavior = false;
            ActiveRentedFurnitureList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            Id.Width = 45;
            // 
            // Style
            // 
            Style.Text = "Style";
            Style.Width = 75;
            // 
            // Category
            // 
            Category.Text = "Category";
            Category.Width = 75;
            // 
            // rentalRate
            // 
            rentalRate.Text = "Rate";
            rentalRate.Width = 65;
            // 
            // Qty
            // 
            Qty.Text = "Qty";
            Qty.Width = 40;
            // 
            // dueDate
            // 
            dueDate.Text = "Due date";
            dueDate.Width = 85;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(481, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(91, 48);
            returnButton.TabIndex = 1;
            returnButton.Text = "Return Selected Items";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ActiveTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(BackButton);
            Controls.Add(returnButton);
            Controls.Add(ActiveRentedFurnitureList);
            Name = "ActiveTransactionsForm";
            Text = "ActiveTransactionsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView ActiveRentedFurnitureList;
        private ColumnHeader Id;
        private ColumnHeader Style;
        private ColumnHeader Category;
        private Button returnButton;
        private Button BackButton;
        private ColumnHeader Qty;
        private ColumnHeader dueDate;
        private ColumnHeader rentalRate;
    }
}