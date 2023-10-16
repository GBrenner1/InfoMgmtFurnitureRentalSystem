using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem
{
    public partial class Form1 : Form
    {

        private MemberRegistrationController memberRegistrationController;
        public Form1()
        {
            InitializeComponent();
            memberRegistrationController = new();
        }

        /// <summary>
        /// On click for the register button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            memberRegistrationController.addMember(firstNameTextBox.Text, lastNameTextBox.Text, genderTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipTextBox.Text, birthdayDateTimePicker.Value);
        }
    }
}