using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

public partial class MemberRegistration : Form
{
    #region Data members

    private const string Space = " ";

    #endregion

    #region Constructors

    public MemberRegistration()
    {
        this.InitializeComponent();
    }

    public MemberRegistration(MemberRegistrationController memberRegistrationController)
    {
        this.InitializeComponent();
        if (memberRegistrationController.CurrentEmployee != null)
        {
            var employee = memberRegistrationController.CurrentEmployee;
            this.EmployeeLabel.Text = employee.EmployeeName + Environment.NewLine + employee.Username + Space +
                                      employee.EmployeeId;
        }
    }

    #endregion

    #region Methods

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        MemberRegistrationController.AddMember(this.firstNameTextBox.Text, this.lastNameTextBox.Text,
            this.genderTextBox.Text, this.phoneNumberTextBox.Text, this.addressTextBox.Text, this.cityTextBox.Text,
            this.stateTextBox.Text, this.zipTextBox.Text, this.birthdayDateTimePicker.Value);
    }

    #endregion

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        var loginScreen = new LoginScreen();
        loginScreen.Show();
        loginScreen.Closed += (s, args) => Close();
        Hide();
    }
}