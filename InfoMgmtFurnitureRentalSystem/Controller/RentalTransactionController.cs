using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class RentalTransactionController
    {
        private RentalTransaction RentalTransaction { get;  set; }

        public RentalTransactionController(int memberId, int employeeId)
        {
            this.RentalTransaction = new RentalTransaction(employeeId, memberId, new List<Furniture>());
        }
        #region Methods

        public bool AddItemToCart(Furniture furniture)
        {
            if (this.RentalTransaction.RentalItems.Any(item => item.FurnitureId == furniture.FurnitureId))
            {
                return false;
            }
            this.RentalTransaction.RentalItems.Add(furniture);
            return true;
        }

        public void RemoveItemFromCart(int furnitureId)
        {
            this.RentalTransaction.RentalItems.Remove(this.RentalTransaction.RentalItems.First(item => item.FurnitureId == furnitureId));
        }

        public void Checkout(DateTime dueDateTime)
        {
            this.RentalTransaction.RentalDate = DateTime.Now;
            this.RentalTransaction.DueDate = dueDateTime;

            if (!RentalDal.AddRentalTransaction(this.RentalTransaction))
            {
                throw new Exception("Failed to add rental transaction");
            }

            if (!FurnitureDal.UpdateQuantities(this.RentalTransaction.RentalItems.ToList()))
            {
                throw new Exception("Failed to update furniture quantities");
            }
        }

        public double CalculateTotalCost()
        {
            return this.RentalTransaction.TotalCost;
        }

        public Furniture GetFurniture(int furnitureId)
        {
            return this.RentalTransaction.RentalItems.First(f => f.FurnitureId == furnitureId);
        }

        public void UpdateDueDate(DateTime dueDate)
        {
            this.RentalTransaction.DueDate = dueDate;
        }

        public void UpdateRentalDate(DateTime rentalDate)
        {
            this.RentalTransaction.RentalDate = rentalDate;
        }

        #endregion
    }
}
