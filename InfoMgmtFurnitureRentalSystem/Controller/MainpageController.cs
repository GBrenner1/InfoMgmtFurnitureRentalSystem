using InfoMgmtFurnitureRentalSystem.Model;
using System.Collections;
using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class MainpageController
    {
        public Employee? CurrentEmployee { get; set; }
        public IList<Member> Members { get; set; }

        public MainpageController()
        {
            this.Members = MainpageDAL.GetMembers();
        }

        public void searchByName(string fname, string lname)
        {
            this.Members = MainpageDAL.searchByName(fname, lname);
        }

        public void searchById(string id)
        {
            this.Members = MainpageDAL.searchById(id);
        }

        public void searchByPhone(string phone)
        {
            this.Members = MainpageDAL.searchByPhone(phone);
        }
    }
}
