namespace InfoMgmtFurnitureRentalSystem.Model;

public class Furniture
{
    #region Properties

    public int Id { get; set; }
    public string Category { get; set; }
    public string Style { get; set; }
    public int Quantity { get; set; }
    public double RentalRate { get; set; }

    #endregion

    #region Constructors

    public Furniture(int id, string category, string style, int quantity, double rentalRate)
    {
        this.Id = id;
        this.Category = category;
        this.Style = style;
        this.Quantity = quantity;
        this.RentalRate = rentalRate;
    }

    #endregion
}