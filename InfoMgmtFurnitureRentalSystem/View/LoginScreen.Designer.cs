namespace InfoMgmtFurnitureRentalSystem.View
{
    partial class LoginScreen
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
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(144, 151);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new Size(125, 27);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(144, 208);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(160, 271);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Magneto", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 97);
            label1.Name = "label1";
            label1.Size = new Size(333, 51);
            label1.TabIndex = 3;
            label1.Text = "B&G Furniture";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 380);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Name = "LoginScreen";
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Label label1;
    }
}