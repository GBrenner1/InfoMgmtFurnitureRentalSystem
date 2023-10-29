using InfoMgmtFurnitureRentalSystem.Model;
using System.Collections;
using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class MainpageController
    {
        public Employee? CurrentEmployee { get; set; }
        public IList<Member> Members { get; set; }
        public IList<Furniture> Furnitures { get; set; }

        public MainpageController()
        {
            this.Members = MemberDal.GetMembers();
            this.Furnitures = FurnitureDal.getFurniture();
        }

        public void searchByName(string fname, string lname)
        {
            this.Members = MemberDal.searchByName(fname, lname);
        }

        public void searchById(string id)
        {
            this.Members = MemberDal.searchById(id);
        }

        public void searchByPhone(string phone)
        {
            this.Members = MemberDal.searchByPhone(phone);
        }
    }
}
