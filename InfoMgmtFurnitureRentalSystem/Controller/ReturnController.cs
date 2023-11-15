using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     the returns controller
/// </summary>
public class ReturnController
{
    #region Properties

    /// <summary>
    ///     The member who's current rentals will be shown
    /// </summary>
    public int CurMember { get; }

    /// <summary>
    ///     The employee looking at past customer transactions
    /// </summary>
    public int CurEmployee { get; }

    /// <summary>
    ///     Selected furniture to be returned
    /// </summary>
    public IList<Furniture>? Furniture { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     the constructor for the return controller
    /// </summary>
    /// <param name="curMember"></param>
    /// <param name="curEmployee"></param>
    /// <param name="selectedFurniture"></param>
    public ReturnController(int curMember, int curEmployee, IList<Furniture> selectedFurniture)
    {
        this.CurMember = curMember;
        this.CurEmployee = curEmployee;
        this.Furniture = selectedFurniture;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Gets the furniture.
    /// </summary>
    /// <param name="furnitureId">The furniture identifier.</param>
    /// <returns>The furniture object associated with the given ID</returns>
    public Furniture GetFurniture(int furnitureId)
    {
        return (this.Furniture ?? throw new InvalidOperationException()).First(f => f.FurnitureId == furnitureId);
    }

    /// <summary>
    ///     Calculates fees on items that are past due
    /// </summary>
    /// <returns>The total fees incurred</returns>
    public string CalculateFees()
    {
        var fees = 0.0;

        var curDate = DateTime.Now;
        var curFurnitures = this.Furniture;
        if (curFurnitures != null)
        {
            foreach (var curFurniture in curFurnitures)
            {
                var pastDue = (int)(curDate - DateTime.Parse(curFurniture.DueDate)).TotalDays;
                if (pastDue > 0)
                {
                    var incurredFees = curFurniture.RentalRate * pastDue * curFurniture.Quantity;
                    fees += incurredFees;
                }
            }
        }

        var returnFees = "$" + $"{Convert.ToDecimal(fees):#0.00}";
        return returnFees;
    }

    /// <summary>
    /// </summary>
    /// <param name="fees"></param>
    /// <returns></returns>
    public int CompleteReturnTransaction(string fees)
    {
        var doubleFees = double.Parse(fees.Replace("$", string.Empty));
        var returnId = RentalReturnsDal.CreateReturnTransaction(this.CurMember, this.CurEmployee,
            this.Furniture ?? throw new InvalidOperationException(), doubleFees);

        foreach (var curFurniture in this.Furniture)
        {
            var currentQuantity = FurnitureDal.GetFurnitureQuantity(curFurniture.FurnitureId);
            var newQuantity = currentQuantity + curFurniture.Quantity;
            FurnitureDal.UpdateFurnitureQuantity(curFurniture.FurnitureId, newQuantity);
        }

        return returnId;
    }

    #endregion
}