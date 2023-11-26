using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     The admin query page
/// </summary>
public partial class AdminQueryPage : Form
{
    #region Data members

    private readonly AdminQueryController controller;

    private AdminQueryResultPage? resultPage;

    #endregion

    #region Constructors

    /// <summary>
    ///     Builds a new admin query page
    /// </summary>
    /// <param name="controller"></param>
    public AdminQueryPage(AdminQueryController controller)
    {
        this.InitializeComponent();

        this.centerForm();

        this.controller = controller;
    }

    #endregion

    #region Methods

    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void QueryButton_Click(object sender, EventArgs e)
    {
        var queryString = this.QueryTextArea.Text;
        var result = this.controller.RunQuery(queryString);

        this.resultPage = new AdminQueryResultPage(result);
        this.resultPage.Show();
    }

    #endregion
}