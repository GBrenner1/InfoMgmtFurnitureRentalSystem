using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View
{
    public partial class TransactionForm : Form
    {
        private RentalTransactionConroller rentalTransactionConroller;
        private EventHandler itemAdded;
        private readonly EventHandler itemRemoved;


        public TransactionForm(RentalTransactionConroller rentalTransactionController)
        {
            this.InitializeComponent();
            this.centerForm();
            this.itemAdded += this.updateTotalCost!;
            this.itemRemoved += this.updateTotalCost!;
            this.rentalTransactionConroller = rentalTransactionController;
        }

        private void centerForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.CartListView.SelectedItems[0].Remove();
            this.itemRemoved.Invoke(this, EventArgs.Empty);
        }

        private void updateTotalCost(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

        }

        public void AddItemToCart(string[] item)
        {
            var newItem = new ListViewItem(item);
            this.CartListView.Items.Add(newItem);
            this.itemAdded.Invoke(this, EventArgs.Empty);
        }


    }
}
