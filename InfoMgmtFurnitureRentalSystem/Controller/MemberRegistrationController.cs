using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class MemberRegistrationController
    {
        public static void AddMember(string fName, string lName, string gender, string phone, string address, string city, string state, string zip, DateTime birthdate)
        {
            Member member = new(fName, lName, gender, phone, address, city, state, zip, birthdate, DateTime.Now);
            MemberDal.InsertMember(member);
        }
    }
}
