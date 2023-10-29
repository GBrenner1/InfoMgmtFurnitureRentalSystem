using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    /// <summary>
    /// The member registration controller class
    /// </summary>
    public class MemberRegistrationController
    {
        public Employee? CurrentEmployee { get; set; }
        /// <summary>
        /// Adds a member to the SQL server
        /// </summary>
        /// <param name="fName">the first name of the member</param>
        /// <param name="lName">the last name of the member</param>
        /// <param name="gender">the gender of the member</param>
        /// <param name="phone">the phone number of the member</param>
        /// <param name="address"> the street address of the member</param>
        /// <param name="city">The city the member lives in</param>
        /// <param name="state">The state the member lives in</param>
        /// <param name="zip">The zip code of the member</param>
        /// <param name="birthdate">the members birthday</param>
        public static bool AddMember(string fName, string lName, string gender, string phone, string address, string city, string state, string zip, DateTime birthdate)
        {
            if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) 
                || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(state) || string.IsNullOrWhiteSpace(zip))
            {
                MessageBox.Show("Please fill out all information", "More info needed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Member member = new(fName, lName, gender, phone, address, city, state, zip, birthdate, DateTime.Now);
            if (MemberDal.InsertMember(member))
            {
                MessageBox.Show("Member added successfully!", "Member added", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return true;
        }
    }
}
