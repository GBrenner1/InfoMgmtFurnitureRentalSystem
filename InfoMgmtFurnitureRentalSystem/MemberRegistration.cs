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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            memberRegistrationController.addMember(firstNameTextBox.Text, lastNameTextBox.Text, genderTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipTextBox.Text, birthdayDateTimePicker.Value);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}