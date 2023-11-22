using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     The controller for the receipt form
/// </summary>
public class ReceiptController
{
    #region Properties

    /// <summary>
    ///     the total fees for the receipt
    /// </summary>
    public string Fees { get; }

    /// <summary>
    ///     the transaction id for the receipt
    /// </summary>
    public int TransactionId { get; }

    /// <summary>
    ///     the returned Furniture
    /// </summary>
    public IList<Furniture> ReturnedFurniture { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     the constructor for the receipt controller class
    /// </summary>
    /// <param name="fees"></param>
    /// <param name="transactionId"></param>
    /// <param name="returnControllerFurniture"></param>
    public ReceiptController(string fees, int transactionId, IList<Furniture> returnControllerFurniture)
    {
        this.Fees = fees;
        this.TransactionId = transactionId;
        this.ReturnedFurniture = returnControllerFurniture;
    }

    #endregion
}