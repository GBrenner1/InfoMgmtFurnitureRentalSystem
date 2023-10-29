﻿namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class TransactionForm
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
            CartListView = new ListView();
            CartLabel = new Label();
            RemoveButton = new Button();
            TotalCostLabel = new Label();
            TotalCostTextBox = new TextBox();
            CheckoutButton = new Button();
            CancelButton = new Button();
            DueDateLabel = new Label();
            DueDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // CartListView
            // 
            CartListView.FullRowSelect = true;
            CartListView.Location = new Point(12, 24);
            CartListView.Name = "CartListView";
            CartListView.Size = new Size(421, 277);
            CartListView.TabIndex = 0;
            CartListView.UseCompatibleStateImageBehavior = false;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(12, 6);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(29, 15);
            CartLabel.TabIndex = 1;
            CartLabel.Text = "Cart";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(12, 307);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(340, 369);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(62, 15);
            TotalCostLabel.TabIndex = 3;
            TotalCostLabel.Text = "Total Cost:";
            // 
            // TotalCostTextBox
            // 
            TotalCostTextBox.Location = new Point(340, 393);
            TotalCostTextBox.Name = "TotalCostTextBox";
            TotalCostTextBox.PlaceholderText = "$0.00";
            TotalCostTextBox.ReadOnly = true;
            TotalCostTextBox.Size = new Size(100, 23);
            TotalCostTextBox.TabIndex = 4;
            // 
            // CheckoutButton
            // 
            CheckoutButton.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckoutButton.Location = new Point(12, 443);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(211, 91);
            CheckoutButton.TabIndex = 5;
            CheckoutButton.Text = "Checkout";
            CheckoutButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(229, 443);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(211, 91);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Location = new Point(12, 372);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new Size(58, 15);
            DueDateLabel.TabIndex = 7;
            DueDateLabel.Text = "Due Date:";
            // 
            // DueDatePicker
            // 
            DueDatePicker.Location = new Point(23, 390);
            DueDatePicker.Name = "DueDatePicker";
            DueDatePicker.Size = new Size(200, 23);
            DueDatePicker.TabIndex = 8;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 547);
            Controls.Add(DueDatePicker);
            Controls.Add(DueDateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CheckoutButton);
            Controls.Add(TotalCostTextBox);
            Controls.Add(TotalCostLabel);
            Controls.Add(RemoveButton);
            Controls.Add(CartLabel);
            Controls.Add(CartListView);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView CartListView;
        private Label CartLabel;
        private Button RemoveButton;
        private Label TotalCostLabel;
        private TextBox TotalCostTextBox;
        private Button CheckoutButton;
        private Button CancelButton;
        private Label DueDateLabel;
        private DateTimePicker DueDatePicker;
    }
}