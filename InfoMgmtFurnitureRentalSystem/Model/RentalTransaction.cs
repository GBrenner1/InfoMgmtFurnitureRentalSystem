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
    public Employee Employee { get; private set; }

    /// <summary>
    ///     Gets the member.
    /// </summary>
    /// <value>The member.</value>
    public Member Member { get; private set; }

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
    /// <param name="employee">The employee.</param>
    /// <param name="member">The member.</param>
    /// <param name="rentalItems">The rental items.</param>
    public RentalTransaction(Employee employee, Member member, ICollection<Furniture> rentalItems)
    {
        this.Employee = employee;
        this.Member = member;
        this.RentalItems = rentalItems;
    }

    #endregion
}