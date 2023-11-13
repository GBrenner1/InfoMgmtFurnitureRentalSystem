using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View
{
    /// <summary>
    /// the receipt form
    /// </summary>
    public partial class receiptForm : Form
    {
        private readonly ReceiptController recipteController;
        /// <summary>
        /// creates a new receipt form
        /// </summary>
        /// <param name="receiptController"></param>
        public receiptForm(ReceiptController receiptController)
        {
            this.InitializeComponent();
            this.centerForm();

            this.recipteController = receiptController;

            this.loadReceipt();
        }
        private void centerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        ///     Overrides the member registration close button
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void loadReceipt()
        {
            this.transactionIdLabel.Text = "Transaction # " + this.recipteController.TransactionId;

            foreach (var curFurniture in this.recipteController.ReturnedFurniture)
            {
                var newItem = new ListViewItem(curFurniture.FurnitureId.ToString());
                newItem.SubItems.Add(curFurniture.RentalId);
                this.listView1.Items.Add(newItem);
            }

            this.finesLabel.Text = "Total Fines: " + this.recipteController.Fees;
        }
    }
}
