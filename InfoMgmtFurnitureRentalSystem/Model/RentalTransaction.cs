namespace InfoMgmtFurnitureRentalSystem.Model;

/// <summary>
///     A class that represents a rental transaction.
/// </summary>
public class RentalTransaction
{
    #region Properties

    /// <summary>
    ///     Gets or sets the rental identifier.
    /// </summary>
    /// <value>The rental identifier.</value>
    public int RentalId { get; set; } = -1;

    /// <summary>
    ///     Gets the employee.
    /// </summary>
    /// <value>The employee.</value>
    public int EmployeeId { get; private set; }

    /// <summary>
    ///     Gets the member.
    /// </summary>
    /// <value>The member.</value>
    public int MemberId { get; private set; }

    /// <summary>
    ///     Gets the rental items.
    /// </summary>
    /// <value>The rental items.</value>
    public ICollection<Furniture> RentalItems { get; }

    /// <summary>
    ///     Gets the rental date.
    /// </summary>
    /// <value>The rental date.</value>
    public DateTime RentalDate { get; set; }

    /// <summary>
    ///     Gets the due date.
    /// </summary>
    /// <value>The due date.</value>
    public DateTime DueDate { get; set; }

    private int DaysBetween => (this.DueDate - this.RentalDate).Days;

    /// <summary>
    ///     Gets the total cost.
    /// </summary>
    /// <value>The total cost.</value>
    public double TotalCost => this.RentalItems.Sum(item => item.RentalRate * this.DaysBetween);

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="RentalTransaction" /> class.
    /// </summary>
    /// <param name="employeeId">The Id associated with the current employee.</param>
    /// <param name="memberId">The member Id for the transaction.</param>
    /// <param name="rentalItems">The rental items.</param>
    public RentalTransaction(int employeeId, int memberId, ICollection<Furniture> rentalItems)
    {
        this.EmployeeId = employeeId;
        this.MemberId = memberId;
        this.RentalItems = rentalItems;
    }

    #endregion
}