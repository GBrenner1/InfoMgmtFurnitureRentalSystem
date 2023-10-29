using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

public partial class Mainpage : Form
{
    #region Data members

    private readonly MainpageController mainpageController;

    #endregion

    #region Constructors

    public Mainpage(MainpageController mainpageController)
    {
        this.InitializeComponent();
        this.mainpageController = mainpageController;
        if (mainpageController.CurrentEmployee != null)
        {
            var employee = mainpageController.CurrentEmployee;
            this.EmployeeLabel.Text = employee.EmployeeName + Environment.NewLine + employee.Username + " " +
                                      employee.EmployeeId;
        }

        this.reloadMembersList();

        this.memberSearchComboBox.Items.Add("Name");
        this.memberSearchComboBox.Items.Add("Id");
        this.memberSearchComboBox.Items.Add("Phone");
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

    private void memberSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.memberSearchComboBox.SelectedIndex != 0)
        {
            this.firstNameLabel.Hide();
            this.firstNameTextBox.Hide();

            if (this.memberSearchComboBox.SelectedIndex == 1)
            {
                this.multiSearchLabel.Text = "Id:";
            }
            else
            {
                this.multiSearchLabel.Text = "Phone:";
            }
        }
        else
        {
            this.firstNameLabel.Show();
            this.firstNameTextBox.Show();
            this.multiSearchLabel.Text = "Last name:";
        }
    }

    private void memberSearchButton_Click(object sender, EventArgs e)
    {
        this.MembersListView.Items.Clear();
        switch (this.memberSearchComboBox.SelectedIndex)
        {
            case 0:
                this.mainpageController.searchByName(this.firstNameTextBox.Text, this.multiSearchBox.Text);
                break;
            case 1:
                this.mainpageController.searchById(this.multiSearchBox.Text);
                break;
            case 2:
                this.mainpageController.searchByPhone(this.multiSearchBox.Text);
                break;
        }

        this.reloadMembersList();
    }

    private void reloadMembersList()
    {
        foreach (var currMember in this.mainpageController.Members)
        {
            var newItem = new ListViewItem(currMember.id);
            newItem.SubItems.Add(currMember.Fname);
            newItem.SubItems.Add(currMember.Lname);
            newItem.SubItems.Add(currMember.Phone);
            this.MembersListView.Items.Add(newItem);
        }
    }

    #endregion
}