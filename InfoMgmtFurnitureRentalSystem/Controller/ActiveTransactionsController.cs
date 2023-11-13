using InfoMgmtFurnitureRentalSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    /// <summary>
    /// Controller for the active transactions form
    /// </summary>
    public class ActiveTransactionsController
    {
        /// <summary>
        /// The member who's current rentals will be shown
        /// </summary>
        public int currMember { get; }
        /// <summary>
        /// The employee looking at past customer transactions
        /// </summary>
        public int currEmployee { get; } 
        /// <summary>
        ///     all furniture that can be rented
        /// </summary>
        public IList<Furniture>? Furniture { get; set; }

        /// <summary>
        /// creates a new active transactions controller
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="employeeId"></param>
        public ActiveTransactionsController(int memberId, int employeeId)
        {
            this.currMember = memberId;
            this.currEmployee = employeeId;
            this.Furniture = FurnitureDal.GetMembersCurrentRentedFurniture(memberId);
        }
    }
}
