namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class MemberRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegisterButton = new Button();
            label1 = new Label();
            firstNameTextBox = new TextBox();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            phoneNumberTextBox = new TextBox();
            addressTextBox = new TextBox();
            cityTextBox = new TextBox();
            zipTextBox = new TextBox();
            birthdayDateTimePicker = new DateTimePicker();
            CancelButton = new Button();
            genderComboBox = new ComboBox();
            stateComboBox = new ComboBox();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(170, 423);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 53);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "First name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(116, 53);
            firstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(206, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(116, 90);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(206, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 173);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 7;
            label5.Text = "Phone number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 213);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 253);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 293);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 10;
            label7.Text = "State:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 333);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 11;
            label8.Text = "Zip:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 374);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 12;
            label9.Text = "Birthday:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(116, 170);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(206, 23);
            phoneNumberTextBox.TabIndex = 14;
            phoneNumberTextBox.KeyPress += phoneNumberTextBox_keyPressed;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(116, 210);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(206, 23);
            addressTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(116, 250);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(206, 23);
            cityTextBox.TabIndex = 16;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(116, 330);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(206, 23);
            zipTextBox.TabIndex = 18;
            zipTextBox.KeyPress += zipTextBox_keyPressed;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new Point(116, 370);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(206, 23);
            birthdayDateTimePicker.TabIndex = 19;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(288, 9);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(116, 130);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(206, 23);
            genderComboBox.TabIndex = 22;
            // 
            // stateComboBox
            // 
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(116, 290);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(206, 23);
            stateComboBox.TabIndex = 23;
            // 
            // MemberRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 472);
            Controls.Add(stateComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(CancelButton);
            Controls.Add(birthdayDateTimePicker);
            Controls.Add(zipTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Name = "MemberRegistration";
            Text = "Member Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Label label1;
        private TextBox firstNameTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox phoneNumberTextBox;
        private TextBox addressTextBox;
        private TextBox cityTextBox;
        private TextBox zipTextBox;
        private DateTimePicker birthdayDateTimePicker;
        private new Button CancelButton;
        private ComboBox genderComboBox;
        private ComboBox stateComboBox;
    }
}