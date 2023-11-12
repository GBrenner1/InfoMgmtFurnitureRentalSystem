namespace InfoMgmtFurnitureRentalSystem.Model;

/// <summary>
///     A class that represents a piece of furniture.
/// </summary>
public class Furniture
{
    #region Properties

    /// <summary>
    ///     Gets or sets the furniture identifier.
    /// </summary>
    /// <value>The furniture identifier.</value>
    public int FurnitureId { get; set; }

    /// <summary>
    ///     Gets or sets the category.
    /// </summary>
    /// <value>The category.</value>
    public string Category { get; set; }

    /// <summary>
    ///     Gets or sets the style.
    /// </summary>
    /// <value>The style.</value>
    public string Style { get; set; }

    /// <summary>
    ///     Gets or sets the quantity.
    /// </summary>
    /// <value>The quantity.</value>
    public int Quantity { get; set; }

    /// <summary>
    ///     Gets or sets the rental rate.
    /// </summary>
    /// <value>The rental rate.</value>
    public double RentalRate { get; set; }
    /// <summary>
    /// The date a piece of furniture is due
    /// </summary>
    public string DueDate { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Furniture" /> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="category">The category.</param>
    /// <param name="style">The style.</param>
    /// <param name="quantity">The quantity.</param>
    /// <param name="rentalRate">The rental rate.</param>
    /// <param name="dueDate">The date the furniture is due. Left blank in most cases to be used in furniture return process.</param>
    public Furniture(int id, string category, string style, int quantity, double rentalRate, string dueDate = "")
    {
        this.FurnitureId = id;
        this.Category = category;
        this.Style = style;
        this.Quantity = quantity;
        this.RentalRate = rentalRate;
        this.DueDate = dueDate;
    }

    #endregion
}