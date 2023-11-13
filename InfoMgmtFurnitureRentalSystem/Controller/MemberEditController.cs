using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

public class MemberEditController
{
    #region Data members

    public Member Member;

    #endregion

    #region Constructors

    public MemberEditController(Member member)
    {
        this.Member = member;
    }

    #endregion

    #region Methods

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
            MessageBox.Show("Member added successfully!", "Member added", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        return true;
    }

    #endregion
}