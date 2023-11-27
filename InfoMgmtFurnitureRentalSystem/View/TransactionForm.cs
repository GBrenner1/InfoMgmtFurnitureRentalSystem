using System.Globalization;
using InfoMgmtFurnitureRentalSystem.Controller;
using InfoMgmtFurnitureRentalSystem.Model;
using Microsoft.VisualBasic;

namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     A form for handling transactions.
///     Implements the <see cref="System.Windows.Forms.Form" />
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class TransactionForm : Form
{
    #region Data members

    private readonly RentalTransactionController rentalTransactionConroller;
    private readonly EventHandler itemAdded;
    private readonly EventHandler itemRemoved;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionForm" /> class.
    /// </summary>
    /// <param name="rentalTransactionController">The rental transaction controller.</param>
    public TransactionForm(RentalTransactionController rentalTransactionController)
    {
        this.InitializeComponent();
        this.centerForm();
        this.itemAdded += this.updateTotalCost!;
        this.itemRemoved += this.updateTotalCost!;
        this.rentalTransactionConroller = rentalTransactionController;
        this.rentalTransactionConroller.UpdateDueDate(this.DueDatePicker.Value);
        this.rentalTransactionConroller.UpdateRentalDate(DateTime.Now);
    }

    #endregion

    #region Methods

    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = this.CartListView.SelectedItems[0];
            this.CartListView.Items.Remove(item);
            var furnitureId = int.Parse(item.SubItems[0].Text);
            this.rentalTransactionConroller.RemoveItemFromCart(furnitureId);
            this.itemRemoved.Invoke(this, EventArgs.Empty);
        }
        catch (Exception)
        {
            MessageBox.Show("No item selected.");
        }
    }

    private void updateTotalCost(object sender, EventArgs e)
    {
        var totalCost = this.rentalTransactionConroller.CalculateTotalCost();
        this.TotalCostTextBox.Text = totalCost.ToString("C", CultureInfo.CurrentCulture);
    }

    private void CheckoutButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.CartListView.Items.Count == 0)
            {
                MessageBox.Show("No items in cart.");
                return;
            }

            if (!confirmCheckout())
            {
                return;
            }

            this.rentalTransactionConroller.Checkout(this.DueDatePicker.Value);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        Hide();
    }

    private static bool confirmCheckout()
    {
        var dialogResult = MessageBox.Show("Are you sure you want to checkout?", "Checkout",
            MessageBoxButtons.YesNo);
        return dialogResult == DialogResult.Yes;
    }

    /// <summary>
    ///     Adds the item to cart.
    /// </summary>
    /// <param name="furniture">The furniture.</param>
    public void AddItemToCart(Furniture furniture)
    {
        if (furniture.Quantity <= 0)
        {
            MessageBox.Show("No more items in stock.");
            return;
        }

        furniture.Quantity = 1;
        if (this.rentalTransactionConroller.AddItemToCart(furniture))
        {
            var item = new ListViewItem(furniture.FurnitureId.ToString());
            item.SubItems.Add(furniture.Style);
            item.SubItems.Add(furniture.Category);
            item.SubItems.Add(furniture.Quantity.ToString());
            item.SubItems.Add(furniture.RentalRate.ToString(CultureInfo.CurrentCulture));
            this.CartListView.Items.Add(item);
            this.itemAdded.Invoke(this, EventArgs.Empty);
        }
        else
        {
            MessageBox.Show("Item already in cart");
        }
    }

    private void chngQtyButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = this.CartListView.SelectedItems[0];
            var furnitureId = int.Parse(item.SubItems[0].Text);
            var furniture = this.rentalTransactionConroller.GetFurniture(furnitureId);
            var quantity =
                int.Parse(Interaction.InputBox("Enter the new quantity", "Change Quantity",
                    furniture.Quantity.ToString()));
            furniture.Quantity = quantity;
            item.SubItems[3].Text = quantity.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("No item selected.");
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void DueDatePicker_ValueChanged(object sender, EventArgs e)
    {
        this.rentalTransactionConroller.UpdateDueDate(this.DueDatePicker.Value);
        this.updateTotalCost(this, EventArgs.Empty);
    }

    #endregion
}