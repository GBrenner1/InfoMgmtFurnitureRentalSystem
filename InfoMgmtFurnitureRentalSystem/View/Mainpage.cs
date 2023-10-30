using InfoMgmtFurnitureRentalSystem.Controller;
using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     The mainpage form
/// </summary>
public partial class Mainpage : Form
{
    #region Data members

    private readonly MainpageController mainpageController;

    private TransactionForm transactionForm;

    #endregion

    #region Constructors

    /// <summary>
    ///     the single param constructor for the mainpage
    /// </summary>
    /// <param name="mainpageController"></param>
    public Mainpage(MainpageController mainpageController)
    {
        this.InitializeComponent();
        this.centerForm();
        this.mainpageController = mainpageController;
        if (mainpageController.CurrentEmployee != null)
        {
            var employee = mainpageController.CurrentEmployee;
            this.EmployeeLabel.Text = employee.EmployeeName + Environment.NewLine + employee.Username + " " +
                                      employee.EmployeeId;
        }

        this.reloadMembersList();
        this.reloadFurnitureList();

        this.memberSearchComboBox.Items.Add("Name");
        this.memberSearchComboBox.Items.Add("Id");
        this.memberSearchComboBox.Items.Add("Phone");

        foreach (var style in mainpageController.getStyles())
        {
            this.funitureStyleComboBox.Items.Add(style);
        }

        foreach (var category in mainpageController.getCategories())
        {
            this.furnitureCategoryComboBox.Items.Add(category);
        }
    }

    #endregion

    #region Methods
    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

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
        memberRegistration.VisibleChanged += this.MemberRegistrationOnVisibleChanged;
    }

    private void MemberRegistrationOnVisibleChanged(object? sender, EventArgs e)
    {
        this.MembersListView.Items.Clear();
        this.mainpageController.refreshMembers();
        this.reloadMembersList();
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
            var newItem = new ListViewItem(currMember.MemberId);
            newItem.SubItems.Add(currMember.Fname);
            newItem.SubItems.Add(currMember.Lname);
            newItem.SubItems.Add(currMember.Phone);
            this.MembersListView.Items.Add(newItem);
        }
    }

    private void reloadFurnitureList()
    {
        foreach (var currFurniture in this.mainpageController.Furnitures)
        {
            var newItem = new ListViewItem(currFurniture.FurnitureId.ToString());
            newItem.SubItems.Add(currFurniture.Style);
            newItem.SubItems.Add(currFurniture.Category);
            this.FurnitureListView.Items.Add(newItem);
        }
    }

    private void furnitureIdSearchButton_Click(object sender, EventArgs e)
    {
        this.FurnitureListView.Items.Clear();
        this.mainpageController.searchFurniture(this.furnitureIdTextBox.Text, this.furnitureCategoryComboBox.Text,
            this.funitureStyleComboBox.Text);
        this.reloadFurnitureList();
    }

    #endregion

    private void StartTransactionButton_Click(object sender, EventArgs e)
    {
        string? selectedMemberId = null;
        try
        {
            selectedMemberId = this.MembersListView.SelectedItems[0].Text;
        }
        catch (Exception exception)
        {
            MessageBox.Show("Please select a member");
            return;
        }

        if (selectedMemberId == null)
        {
            MessageBox.Show("Please select a member");
            return;
        }

        var rentalTransactionController = new RentalTransactionController(int.Parse(selectedMemberId), this.mainpageController.CurrentEmployee!.EmployeeId);
        this.AddItemButton.Visible = true;

        this.transactionForm = new TransactionForm(rentalTransactionController);
        this.transactionForm.Show();
        this.transactionForm.Closed += (s, args) => Close();
        this.transactionForm.VisibleChanged += this.TransactionFormOnVisibleChanged;

    }

    private void TransactionFormOnVisibleChanged(object? sender, EventArgs e)
    {
        this.FurnitureListView.Items.Clear();
        this.mainpageController.refreshFurnitures();
        this.reloadFurnitureList();
        this.AddItemButton.Visible = false;
    }

    private void AddItemButton_Click(object sender, EventArgs e)
    {
        this.transactionForm.AddItemToCart(this.mainpageController.Furnitures[this.FurnitureListView.SelectedIndices[0]]);
    }
}