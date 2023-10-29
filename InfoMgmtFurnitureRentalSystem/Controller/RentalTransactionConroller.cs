using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class RentalTransactionConroller
    {
        private RentalTransaction RentalTransaction { get;  set; }

        public RentalTransactionConroller(Member member, Employee employee)
        {
            this.RentalTransaction = new RentalTransaction(employee, member, new List<Furniture>());
        }
        #region Methods

        public void AddItemToCart(Furniture furniture)
        {
            this.RentalTransaction.RentalItems.Add(furniture);
        }

        public void RemoveItemFromCart(Furniture furniture)
        {
            this.RentalTransaction.RentalItems.Remove(furniture);
        }

        public void Checkout(DateTime dueDateTime)
        {
            this.RentalTransaction.RentalDate = DateTime.Now;
            this.RentalTransaction.DueDate = dueDateTime;

            RentalDal.AddRentalTransaction(this.RentalTransaction);
        }

        #endregion
    }
}
