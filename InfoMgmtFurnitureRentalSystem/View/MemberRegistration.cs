using System.Collections;
using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
/// The member registration form
/// </summary>
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

        this.genderComboBox.Items.Add("M");
        this.genderComboBox.Items.Add("F");
        this.genderComboBox.Items.Add("O");

        var stateAbbreviations = new List<string>
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
        };

        foreach (var abbreviation in stateAbbreviations)
        {
            this.stateComboBox.Items.Add(abbreviation);
        }
    }

    #endregion

    #region Methods

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        MemberRegistrationController.AddMember(this.firstNameTextBox.Text, this.lastNameTextBox.Text,
            this.genderComboBox.Text, this.phoneNumberTextBox.Text, this.addressTextBox.Text, this.cityTextBox.Text,
            this.stateComboBox.Text, this.zipTextBox.Text, this.birthdayDateTimePicker.Value);
    }
    private void LogoutButton_Click(object sender, EventArgs e)
    {
        var loginScreen = new LoginScreen();
        loginScreen.Show();
        loginScreen.Closed += (s, args) => Close();
        Hide();
    }

    #endregion

    private void zipTextBox_keyPressed(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar);
    }

    private void phoneNumberTextBox_keyPressed(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar);
    }
}