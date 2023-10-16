using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class MemberRegistrationController
    {
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
        public void addMember(string fName, string lName, string gender, string phone, string address, string city, string state, string zip, DateTime birthdate)
        {
            Member member = new(fName, lName, gender, phone, address, city, state, zip, birthdate, DateTime.Now);
            MemberDal.InsertMember(member);
        }
    }
}
