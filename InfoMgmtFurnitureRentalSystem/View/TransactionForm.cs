using System.Globalization;
using InfoMgmtFurnitureRentalSystem.Controller;
using InfoMgmtFurnitureRentalSystem.Model;
using Microsoft.VisualBasic;

namespace InfoMgmtFurnitureRentalSystem.View;

public partial class TransactionForm : Form
{
    #region Data members

    private readonly RentalTransactionController rentalTransactionConroller;
    private readonly EventHandler itemAdded;
    private readonly EventHandler itemRemoved;

    #endregion

    #region Constructors

    public TransactionForm(RentalTransactionController rentalTransactionController)
    {
        this.InitializeComponent();
        this.centerForm();
        this.itemAdded += this.updateTotalCost!;
        this.itemRemoved += this.updateTotalCost!;
        this.rentalTransactionConroller = rentalTransactionController;
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
            this.rentalTransactionConroller.Checkout(this.DueDatePicker.Value);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        Hide();
    }

    public void AddItemToCart(Furniture furniture)
    {
        if (this.rentalTransactionConroller.AddItemToCart(furniture))
        {
            var item = new ListViewItem(furniture.FurnitureId.ToString());
            item.SubItems.Add(furniture.Style);
            item.SubItems.Add(furniture.Category);
            item.SubItems.Add(furniture.Quantity.ToString());
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
        var item = this.CartListView.SelectedItems[0];
        var furnitureId = int.Parse(item.SubItems[0].Text);
        var furniture = this.rentalTransactionConroller.GetFurniture(furnitureId);
        var quantity =
            int.Parse(Interaction.InputBox("Enter the new quantity", "Change Quantity", furniture.Quantity.ToString()));
        furniture.Quantity = quantity;
        item.SubItems[2].Text = quantity.ToString();
    }

    #endregion

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
}