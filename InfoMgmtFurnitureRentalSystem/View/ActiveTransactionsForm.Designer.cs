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
            idColumn = new ColumnHeader();
            styleColumn = new ColumnHeader();
            categoryColumn = new ColumnHeader();
            rentalRateColumn = new ColumnHeader();
            qtyColumn = new ColumnHeader();
            dueDateColumn = new ColumnHeader();
            rentalIdColumn = new ColumnHeader();
            returnButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ActiveRentedFurnitureList
            // 
            ActiveRentedFurnitureList.CheckBoxes = true;
            ActiveRentedFurnitureList.Columns.AddRange(new ColumnHeader[] { idColumn, styleColumn, categoryColumn, rentalRateColumn, qtyColumn, dueDateColumn, rentalIdColumn });
            ActiveRentedFurnitureList.Location = new Point(12, 12);
            ActiveRentedFurnitureList.Name = "ActiveRentedFurnitureList";
            ActiveRentedFurnitureList.Size = new Size(463, 426);
            ActiveRentedFurnitureList.TabIndex = 0;
            ActiveRentedFurnitureList.UseCompatibleStateImageBehavior = false;
            ActiveRentedFurnitureList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            idColumn.Text = "ID";
            idColumn.Width = 45;
            // 
            // styleColumn
            // 
            styleColumn.Text = "Style";
            styleColumn.Width = 75;
            // 
            // categoryColumn
            // 
            categoryColumn.Text = "Category";
            categoryColumn.Width = 75;
            // 
            // rentalRateColumn
            // 
            rentalRateColumn.Text = "Rate";
            rentalRateColumn.Width = 65;
            // 
            // qtyColumn
            // 
            qtyColumn.Text = "Qty";
            qtyColumn.Width = 40;
            // 
            // dueDateColumn
            // 
            dueDateColumn.Text = "Due date";
            dueDateColumn.Width = 85;
            // 
            // rentalIdColumn
            // 
            rentalIdColumn.Text = "Rental ID";
            rentalIdColumn.Width = 75;
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
            BackButton.Location = new Point(481, 78);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(91, 23);
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
        private ColumnHeader idColumn;
        private ColumnHeader styleColumn;
        private ColumnHeader categoryColumn;
        private Button returnButton;
        private Button BackButton;
        private ColumnHeader qtyColumn;
        private ColumnHeader dueDateColumn;
        private ColumnHeader rentalRateColumn;
        private ColumnHeader rentalIdColumn;
    }
}