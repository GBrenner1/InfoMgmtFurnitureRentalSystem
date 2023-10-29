namespace InfoMgmtFurnitureRentalSystem.Model;

public class RentalTransaction
{
    #region Properties

    public Employee Employee { get; private set; }

    public Member Member { get; private set; }

    public ICollection<Furniture> RentalItems { get; }

    public DateTime RentalDate { get; private set; }

    public DateTime DueDate { get; private set; }

    private int DaysBetween => (this.DueDate - this.RentalDate).Days;

    public double TotalCost => this.RentalItems.Sum(item => item.RentalRate * this.DaysBetween);

    #endregion

    #region Constructors

    public RentalTransaction(Employee employee, Member member, ICollection<Furniture> rentalItems)
    {
        this.Employee = employee;
        this.Member = member;
        this.RentalItems = rentalItems;
    }

    #endregion
}