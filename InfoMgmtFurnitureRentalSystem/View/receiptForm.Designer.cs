namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class receiptForm
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
            transactionIdLabel = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            finesLabel = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // transactionIdLabel
            // 
            transactionIdLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            transactionIdLabel.Location = new Point(32, 9);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new Size(270, 28);
            transactionIdLabel.TabIndex = 0;
            transactionIdLabel.Text = "label1";
            transactionIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(32, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 277);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Rental Transaction Id";
            columnHeader2.Width = 130;
            // 
            // finesLabel
            // 
            finesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            finesLabel.Location = new Point(32, 345);
            finesLabel.Name = "finesLabel";
            finesLabel.Size = new Size(270, 28);
            finesLabel.TabIndex = 2;
            finesLabel.Text = "Total fees: ";
            finesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(114, 386);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(102, 41);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // receiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(confirmButton);
            Controls.Add(finesLabel);
            Controls.Add(listView1);
            Controls.Add(transactionIdLabel);
            Name = "receiptForm";
            Text = "receiptForm";
            ResumeLayout(false);
        }

        #endregion

        private Label transactionIdLabel;
        private ListView listView1;
        private Label finesLabel;
        private Button confirmButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}