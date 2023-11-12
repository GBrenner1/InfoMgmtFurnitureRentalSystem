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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            returnButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ActiveRentedFurnitureList
            // 
            ActiveRentedFurnitureList.CheckBoxes = true;
            ActiveRentedFurnitureList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ActiveRentedFurnitureList.Location = new Point(100, 12);
            ActiveRentedFurnitureList.Name = "ActiveRentedFurnitureList";
            ActiveRentedFurnitureList.Size = new Size(375, 426);
            ActiveRentedFurnitureList.TabIndex = 0;
            ActiveRentedFurnitureList.UseCompatibleStateImageBehavior = false;
            ActiveRentedFurnitureList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Style";
            columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 125;
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button returnButton;
        private Button BackButton;
    }
}