using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     The login screen form.
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class LoginScreen : Form
{
    #region Data members

    private const string InvalidLoginMessage = "Invalid Username or password";
    private readonly LoginController controller;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="LoginScreen" /> class.
    /// </summary>
    public LoginScreen()
    {
        this.InitializeComponent();
        this.centerForm();
        this.controller = new LoginController();
    }

    #endregion

    #region Methods

    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        this.controller.CurrentEmployee =
            LoginController.CheckLogin(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
        if (this.controller.CurrentEmployee != null)
        {
            var MainpageContgroller = new MainpageController
            {
                CurrentEmployee = this.controller.CurrentEmployee
            };
            var Mainpage = new Mainpage(MainpageContgroller);
            Mainpage.Show();
            Mainpage.Closed += (_, _) => Close();
            Hide();
        }
        else
        {
            MessageBox.Show(InvalidLoginMessage);
        }
    }

    #endregion
}