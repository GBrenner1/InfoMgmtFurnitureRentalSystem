using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     The member registration form
/// </summary>
public partial class MemberRegistration : Form
{
    #region Data members

    private readonly bool isEdit;

    private readonly MemberEditController? memberEditController;

    #endregion

    #region Constructors

    /// <summary>
    ///     The default constructor for the member registration class
    /// </summary>
    public MemberRegistration()
    {
        this.InitializeComponent();
    }

    /// <summary>
    ///     The single param constructor for the member registration class
    /// </summary>
    /// <param name="memberRegistrationController"></param>
    public MemberRegistration(MemberRegistrationController memberRegistrationController)
    {
        this.InitializeComponent();
        this.centerForm();
        if (memberRegistrationController.CurrentEmployee != null)
        {
            _ = memberRegistrationController.CurrentEmployee;
        }

        this.setUpComboBoxes();
    }

    private void setUpComboBoxes()
    {
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

    /// <summary>
    /// Initializes a new instance of the <see cref="MemberRegistration"/> class For editing a member.
    /// </summary>
    /// <param name="memberEditController"></param>
    public MemberRegistration(MemberEditController memberEditController)
    {
        this.isEdit = true;
        this.memberEditController = memberEditController;
        this.InitializeComponent();
        this.centerForm();

        this.setUpComboBoxes();

        this.setMemberInfo();
    }

    #endregion

    #region Methods

    private void setMemberInfo()
    {
        this.RegisterButton.Text = "Save";
        this.firstNameTextBox.Text = this.memberEditController?.Member.Fname;
        this.lastNameTextBox.Text = this.memberEditController?.Member.Lname;
        this.genderComboBox.SelectedIndex = this.genderComboBox.Items.IndexOf(this.memberEditController!.Member.Gender);
        this.phoneNumberTextBox.Text = this.memberEditController?.Member.Phone;
        this.addressTextBox.Text = this.memberEditController?.Member.StreetAddr;
        this.cityTextBox.Text = this.memberEditController?.Member.City;
        this.stateComboBox.SelectedIndex = this.stateComboBox.Items.IndexOf(this.memberEditController!.Member.State);
        this.zipTextBox.Text = this.memberEditController?.Member.Zip;
        this.birthdayDateTimePicker.Value = this.memberEditController!.Member.Birthday;
    }

    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        switch (this.isEdit)
        {
            case true:
                this.editMember();
                break;
            case false:
                if (MemberRegistrationController.AddMember(this.firstNameTextBox.Text, this.lastNameTextBox.Text,
                        this.genderComboBox.Text, this.phoneNumberTextBox.Text, this.addressTextBox.Text,
                        this.cityTextBox.Text,
                        this.stateComboBox.Text, this.zipTextBox.Text, this.birthdayDateTimePicker.Value))
                {
                    Hide();
                }

                break;
        }
    }

    private void editMember()
    {
        if (this.memberEditController != null)
        {
            if (this.memberEditController.EditMember(this.firstNameTextBox.Text, this.lastNameTextBox.Text,
                    this.genderComboBox.Text, this.phoneNumberTextBox.Text, this.addressTextBox.Text,
                    this.cityTextBox.Text,
                    this.stateComboBox.Text, this.zipTextBox.Text, this.birthdayDateTimePicker.Value))
            {
                Hide();
            }
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void zipTextBox_keyPressed(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar))
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    private void phoneNumberTextBox_keyPressed(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar))
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    /// <summary>
    ///     Overrides the member registration close button
    /// </summary>
    /// <param name="e"></param>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        e.Cancel = true;
        Hide();
    }

    #endregion
}