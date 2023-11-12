using InfoMgmtFurnitureRentalSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class ReturnController
    {
        /// <summary>
        /// The member who's current rentals will be shown
        /// </summary>
        public int CurMember { get; }
        /// <summary>
        /// The employee looking at past customer transactions
        /// </summary>
        public int CurEmployee { get; }
        /// <summary>
        ///     Selected furniture to be returned
        /// </summary>
        public IList<Furniture>? Furniture { get; set; }
        public ReturnController(int curMember, int curEmployee, IList<Furniture> selectedFurniture)
        {
            this.CurMember = curMember;
            this.CurEmployee = curEmployee;
            this.Furniture = selectedFurniture;
        }

        /// <summary>
        ///     Gets the furniture.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <returns>The furniture object associated with the given ID</returns>
        public Furniture GetFurniture(int furnitureId)
        {
            return this.Furniture.First(f => f.FurnitureId == furnitureId);
        }

        /// <summary>
        /// Calculates fees on items that are past due
        /// </summary>
        /// <returns>The total fees incurred</returns>
        public Double CalculateFees()
        {
            var fees = 0.0;

            var curDate = DateTime.Now;
            foreach (var curFurniture in this.Furniture)
            {
                var pastDue = (int)(curDate - DateTime.Parse(curFurniture.DueDate)).TotalDays;
                if (pastDue > 0)
                {
                    var incurredFees = curFurniture.RentalRate * pastDue * curFurniture.Quantity;
                    fees += incurredFees;
                }
            }

            return fees;
        }
    }
}
