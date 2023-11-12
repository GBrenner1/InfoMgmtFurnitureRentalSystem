namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class ReturnFurniturePage
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
            furnitureList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            CancelButton = new Button();
            ReturnButton = new Button();
            qtyChangeButton = new Button();
            FeesTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // furnitureList
            // 
            furnitureList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            furnitureList.FullRowSelect = true;
            furnitureList.Location = new Point(100, 12);
            furnitureList.Name = "furnitureList";
            furnitureList.Size = new Size(375, 426);
            furnitureList.TabIndex = 0;
            furnitureList.UseCompatibleStateImageBehavior = false;
            furnitureList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Style";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Rate";
            columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Qty";
            columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Due Date";
            columnHeader6.Width = 85;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 12);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(481, 393);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(91, 45);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Confirm Return";
            ReturnButton.UseVisualStyleBackColor = true;
            // 
            // qtyChangeButton
            // 
            qtyChangeButton.Location = new Point(481, 12);
            qtyChangeButton.Name = "qtyChangeButton";
            qtyChangeButton.Size = new Size(91, 47);
            qtyChangeButton.TabIndex = 3;
            qtyChangeButton.Text = "Change Quantity";
            qtyChangeButton.UseVisualStyleBackColor = true;
            qtyChangeButton.Click += qtyChangeButton_Click;
            // 
            // FeesTextBox
            // 
            FeesTextBox.Location = new Point(481, 364);
            FeesTextBox.Name = "FeesTextBox";
            FeesTextBox.ReadOnly = true;
            FeesTextBox.Size = new Size(91, 23);
            FeesTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 346);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Fees:";
            // 
            // ReturnFurniturePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(label1);
            Controls.Add(FeesTextBox);
            Controls.Add(qtyChangeButton);
            Controls.Add(ReturnButton);
            Controls.Add(CancelButton);
            Controls.Add(furnitureList);
            Name = "ReturnFurniturePage";
            Text = "ReturnFurniturePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView furnitureList;
        private Button CancelButton;
        private Button ReturnButton;
        private Button qtyChangeButton;
        private TextBox FeesTextBox;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}