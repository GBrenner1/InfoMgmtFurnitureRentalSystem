namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class ReportForm
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
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            reportBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            generateRentalReportButton = new Button();
            generateReturnReportButton = new Button();
            SuspendLayout();
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(12, 12);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(331, 12);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 1;
            // 
            // reportBox
            // 
            reportBox.Location = new Point(82, 124);
            reportBox.Name = "reportBox";
            reportBox.ReadOnly = true;
            reportBox.Size = new Size(375, 269);
            reportBox.TabIndex = 2;
            reportBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 38);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Start Date";
            // 
            // generateRentalReportButton
            // 
            generateRentalReportButton.Location = new Point(70, 81);
            generateRentalReportButton.Name = "generateRentalReportButton";
            generateRentalReportButton.Size = new Size(142, 23);
            generateRentalReportButton.TabIndex = 5;
            generateRentalReportButton.Text = "Generate Rental Report";
            generateRentalReportButton.UseVisualStyleBackColor = true;
            generateRentalReportButton.Click += generateRentalReportButton_Click;
            // 
            // generateReturnReportButton
            // 
            generateReturnReportButton.Location = new Point(331, 80);
            generateReturnReportButton.Name = "generateReturnReportButton";
            generateReturnReportButton.Size = new Size(142, 23);
            generateReturnReportButton.TabIndex = 6;
            generateReturnReportButton.Text = "Generate Return Report";
            generateReturnReportButton.UseVisualStyleBackColor = true;
            generateReturnReportButton.Click += generateReturnReportButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 412);
            Controls.Add(generateReturnReportButton);
            Controls.Add(generateRentalReportButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportBox);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private RichTextBox reportBox;
        private Label label1;
        private Label label2;
        private Button generateRentalReportButton;
        private Button generateReturnReportButton;
    }
}