using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View
{
    public partial class MemberRegistration : Form
    {
        private readonly MemberRegistrationController memberRegistrationController;
        public MemberRegistration()
        {
            this.InitializeComponent();
            this.memberRegistrationController = new MemberRegistrationController();
        }

        public MemberRegistration(MemberRegistrationController memberRegistrationController)
        {
            this.InitializeComponent();
            this.memberRegistrationController = memberRegistrationController;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MemberRegistrationController.AddMember(this.firstNameTextBox.Text, this.lastNameTextBox.Text, this.genderTextBox.Text, this.phoneNumberTextBox.Text, this.addressTextBox.Text, this.cityTextBox.Text, this.stateTextBox.Text, this.zipTextBox.Text, this.birthdayDateTimePicker.Value);
        }

    }
}