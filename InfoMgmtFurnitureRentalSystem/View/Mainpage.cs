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

    private TransactionForm? transactionForm;

    private ActiveTransactionsForm? ActiveTransactionsForm;

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

        foreach (var style in mainpageController.GetStyles())
        {
            this.funitureStyleComboBox.Items.Add(style);
        }

        foreach (var category in MainpageController.GetCategories())
        {
            this.furnitureCategoryComboBox.Items.Add(category);
        }

        this.memberSearchComboBox.SelectedIndex = 0;
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
        this.mainpageController.RefreshMembers();
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
                this.mainpageController.SearchByName(this.firstNameTextBox.Text, this.multiSearchBox.Text);
                break;
            case 1:
                this.mainpageController.SearchById(this.multiSearchBox.Text);
                break;
            case 2:
                this.mainpageController.SearchByPhone(this.multiSearchBox.Text);
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
        this.mainpageController.SearchFurniture(this.furnitureIdTextBox.Text, this.furnitureCategoryComboBox.Text,
            this.funitureStyleComboBox.Text);
        this.reloadFurnitureList();
    }

    #endregion

    private void StartTransactionButton_Click(object sender, EventArgs e)
    {
        string? selectedMemberId;
        try
        {
            selectedMemberId = this.MembersListView.SelectedItems[0].Text;
        }
        catch (Exception)
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
        this.mainpageController.RefreshFurnitures();
        this.reloadFurnitureList();
        this.AddItemButton.Visible = false;
    }

    private void AddItemButton_Click(object sender, EventArgs e)
    {
        this.transactionForm?.AddItemToCart(this.mainpageController.Furnitures[this.FurnitureListView.SelectedIndices[0]]);
    }

    private void ActiveRentalsButton_Click(object sender, EventArgs e)
    {
        string? selectedMemberId;
        try
        {
            selectedMemberId = this.MembersListView.SelectedItems[0].Text;
        }
        catch (Exception)
        {
            MessageBox.Show("Please select a member");
            return;
        }

        if (selectedMemberId == null)
        {
            MessageBox.Show("Please select a member");
            return;
        }

        var activeTransactionsController = new ActiveTransactionsController(int.Parse(selectedMemberId),
            this.mainpageController.CurrentEmployee!.EmployeeId);

        this.ActiveTransactionsForm = new ActiveTransactionsForm(activeTransactionsController);
        this.ActiveTransactionsForm.Show();
    }

    private void clearFurnitureSearchButton_Click(object sender, EventArgs e)
    {
        this.furnitureIdTextBox.Text = string.Empty;
        this.funitureStyleComboBox.SelectedIndex = -1;
        this.furnitureCategoryComboBox.SelectedIndex = -1;
    }

    private void ClearMemberSearchButton_Click(object sender, EventArgs e)
    {
        this.firstNameTextBox.Text = string.Empty;
        this.multiSearchBox.Text = string.Empty;
    }
}