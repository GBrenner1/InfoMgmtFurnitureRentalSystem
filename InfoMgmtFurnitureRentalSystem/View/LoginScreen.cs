using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     The login screen form.
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class LoginScreen : Form
{
    #region Data members

    private const string InvalidLoginMessage = "Invalid username or password";
    private readonly LoginController controller;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="LoginScreen" /> class.
    /// </summary>
    public LoginScreen()
    {
        this.InitializeComponent();
        this.controller = new LoginController();
    }

    #endregion

    #region Methods

    private void LoginButton_Click(object sender, EventArgs e)
    {
        this.controller.CurrentEmployee =
            LoginController.CheckLogin(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
        if (this.controller.CurrentEmployee != null)
        {
            var memberRegistrationController = new MemberRegistrationController
            {
                CurrentEmployee = this.controller.CurrentEmployee
            };
            var memberRegistration = new MemberRegistration(memberRegistrationController);
            memberRegistration.Show();
            memberRegistration.Closed += (s, args) => Close();
            Hide();
        }
        else
        {
            MessageBox.Show(InvalidLoginMessage);
        }
    }

    #endregion
}