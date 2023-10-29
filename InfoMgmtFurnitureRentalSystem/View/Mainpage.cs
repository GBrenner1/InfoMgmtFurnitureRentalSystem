using InfoMgmtFurnitureRentalSystem.Controller;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.View;

public partial class Mainpage : Form
{
    #region Constructors

    public Mainpage(MainpageController mainpageController)
    {
        this.InitializeComponent();
        if (mainpageController.CurrentEmployee != null)
        {
            var employee = mainpageController.CurrentEmployee;
            this.EmployeeLabel.Text = employee.EmployeeName + Environment.NewLine + employee.Username + " " +
                                      employee.EmployeeId;
        }

        foreach (Member currMember in mainpageController.Members)
        {
            ListViewItem newItem = new ListViewItem(currMember.id);
            newItem.SubItems.Add(currMember.Fname);
            newItem.SubItems.Add(currMember.Lname);
            newItem.SubItems.Add(currMember.Phone);
            this.MembersListView.Items.Add(newItem);
        }
    }

    #endregion

    #region Methods

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        var loginScreen = new LoginScreen();
        loginScreen.Show();
        loginScreen.Closed += (s, args) => Close();
        Hide();
    }

    private void AddMemberButton_Click(object sender, EventArgs e)
    {
        var memberRegistrationController = new MemberRegistrationController();
        var memberRegistration = new MemberRegistration(memberRegistrationController);
        memberRegistration.Show();
        memberRegistration.Closed += (s, args) => Close();
    }

    #endregion
}