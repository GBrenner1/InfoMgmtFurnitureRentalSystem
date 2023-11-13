using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
/// A controller for MemberEdit functionality in the MemberRegistration form.
/// </summary>
public class MemberEditController
{
    #region Data members

    /// <summary>
    /// The member
    /// </summary>
    public Member Member;

    #endregion

    #region Constructors

    /// <summary>
    /// Instantiates a new instance of the <see cref="MemberEditController"/> class.
    /// </summary>
    /// <param name="member"></param>
    public MemberEditController(Member member)
    {
        this.Member = member;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Takes in the member information and edits the member
    /// </summary>
    /// <param name="fName"></param>
    /// <param name="lName"></param>
    /// <param name="gender"></param>
    /// <param name="phone"></param>
    /// <param name="address"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="zip"></param>
    /// <param name="birthdate"></param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool EditMember(string fName, string lName, string gender, string phone, string address,
        string city, string state, string zip, DateTime birthdate)
    {
        if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName) || string.IsNullOrWhiteSpace(phone) ||
            string.IsNullOrWhiteSpace(address)
            || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(state) || string.IsNullOrWhiteSpace(zip) ||
            string.IsNullOrWhiteSpace(gender))
        {
            MessageBox.Show("Please fill out all information", "More info needed", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        this.Member.Fname = fName;
        this.Member.Lname = lName;
        this.Member.Gender = gender;
        this.Member.Phone = phone;
        this.Member.StreetAddr = address;
        this.Member.City = city;
        this.Member.State = state;
        this.Member.Zip = zip;
        this.Member.Birthday = birthdate;

        if (MemberDal.EditMember(this.Member))
        {
            MessageBox.Show("Member Edited successfully!", "Member edited", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }

        return false;
    }

    #endregion
}