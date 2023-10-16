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
        public void addMember(string fName, string lName, string gender, string phone, string address, string city, string state, string zip, DateTime birthdate)
        {
            Member member = new(fName, lName, gender, phone, address, city, state, zip, birthdate, DateTime.Now);
            MemberDal.InsertMember(member);
        }
    }
}
