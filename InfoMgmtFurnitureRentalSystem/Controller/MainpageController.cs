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
    }
}
