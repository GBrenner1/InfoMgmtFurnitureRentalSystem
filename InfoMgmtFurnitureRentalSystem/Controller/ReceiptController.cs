using System.Text;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     The controller for the receipt form
/// </summary>
public class ReceiptController
{
    #region Properties

    private string Fees { get; }

    private int TransactionId { get; }

    private ReturnController ReturnController { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     the constructor for the receipt controller class
    /// </summary>
    /// <param name="fees"></param>
    /// <param name="transactionId"></param>
    /// <param name="returnController"></param>
    public ReceiptController(string fees, int transactionId, ReturnController returnController)
    {
        this.Fees = fees;
        this.TransactionId = transactionId;
        this.ReturnController = returnController;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Generates the receipt.
    /// </summary>
    public void GenerateReceipt()
    {
        MessageBox.Show(this.generateReceiptString(), "Receipt");
    }

    private string generateReceiptString()
    {
        var receipt = new StringBuilder();
        receipt.AppendLine("Transaction ID: " + this.TransactionId);
        receipt.AppendLine();
        receipt.AppendLine("Member ID: " + this.ReturnController.CurMember);
        receipt.AppendLine("Employee ID: " + this.ReturnController.CurEmployee);
        receipt.AppendLine("Date: " + DateTime.Now);
        receipt.AppendLine();
        receipt.AppendLine("Fees: " + this.Fees);
        receipt.AppendLine();
        receipt.AppendLine("Furniture:");
        foreach (var item in this.ReturnController.Furniture!)
        {
            receipt.AppendLine();
            receipt.AppendLine($"Furniture Id: {item.FurnitureId}");
            receipt.AppendLine($"Quantity: {item.Quantity}");
            receipt.AppendLine($"Rental Rate: {item.RentalRate}");
            receipt.AppendLine($"Style: {item.Style}");
            receipt.AppendLine($"Category: {item.Category}");
            receipt.AppendLine();
        }

        return receipt.ToString();
    }

    #endregion
}