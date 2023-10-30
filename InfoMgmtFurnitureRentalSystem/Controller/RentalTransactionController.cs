using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     The controller for the Transaction form.
/// </summary>
public class RentalTransactionController
{
    #region Properties

    private RentalTransaction RentalTransaction { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="RentalTransactionController" /> class.
    /// </summary>
    /// <param name="memberId">The member identifier.</param>
    /// <param name="employeeId">The employee identifier.</param>
    public RentalTransactionController(int memberId, int employeeId)
    {
        this.RentalTransaction = new RentalTransaction(employeeId, memberId, new List<Furniture>());
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Adds the item to cart.
    /// </summary>
    /// <param name="furniture">The furniture.</param>
    /// <returns><c>true</c> if the furniture isn't in the cart, <c>false</c> otherwise.</returns>
    public bool AddItemToCart(Furniture furniture)
    {
        if (this.RentalTransaction.RentalItems.Any(item => item.FurnitureId == furniture.FurnitureId))
        {
            return false;
        }

        this.RentalTransaction.RentalItems.Add(furniture);
        return true;
    }

    /// <summary>
    ///     Removes the item from cart.
    /// </summary>
    /// <param name="furnitureId">The furniture identifier.</param>
    public void RemoveItemFromCart(int furnitureId)
    {
        this.RentalTransaction.RentalItems.Remove(
            this.RentalTransaction.RentalItems.First(item => item.FurnitureId == furnitureId));
    }

    /// <summary>
    ///     Checkouts with the specified due date time.
    /// </summary>
    /// <param name="dueDateTime">The due date time.</param>
    /// <exception cref="System.Exception">Failed to add rental transaction</exception>
    /// <exception cref="System.Exception">Failed to update furniture quantities</exception>
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

    /// <summary>
    ///     Calculates the total cost.
    /// </summary>
    /// <returns>The total cost as calculated by the RentalTransaction</returns>
    public double CalculateTotalCost()
    {
        return this.RentalTransaction.TotalCost;
    }

    /// <summary>
    ///     Gets the furniture.
    /// </summary>
    /// <param name="furnitureId">The furniture identifier.</param>
    /// <returns>The furniture object associated with the given ID</returns>
    public Furniture GetFurniture(int furnitureId)
    {
        return this.RentalTransaction.RentalItems.First(f => f.FurnitureId == furnitureId);
    }

    /// <summary>
    ///     Updates the due date.
    /// </summary>
    /// <param name="dueDate">The due date.</param>
    public void UpdateDueDate(DateTime dueDate)
    {
        this.RentalTransaction.DueDate = dueDate;
    }

    /// <summary>
    ///     Updates the rental date.
    /// </summary>
    /// <param name="rentalDate">The rental date.</param>
    public void UpdateRentalDate(DateTime rentalDate)
    {
        this.RentalTransaction.RentalDate = rentalDate;
    }

    #endregion
}