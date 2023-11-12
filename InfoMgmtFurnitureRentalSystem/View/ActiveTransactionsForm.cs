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
    /// class to define the active transactions form
    /// </summary>
    public partial class ActiveTransactionsForm : Form
    {
        private ActiveTransactionsController ActiveTransactionsController { get; }
        /// <summary>
        /// Created a new active transactions form
        /// </summary>
        /// <param name="activeTransactionsController"></param>
        public ActiveTransactionsForm(ActiveTransactionsController activeTransactionsController)
        {
            this.InitializeComponent();
            this.ActiveTransactionsController = activeTransactionsController;
            reloadFurnitureList();
        }

        private void BackButton_Click(object sender, EventArgs e)
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

        private void returnButton_Click(object sender, EventArgs e)
        {

        }

        private void reloadFurnitureList()
        {
            foreach (var currFurniture in this.ActiveTransactionsController.Furniture!)
            {
                var newItem = new ListViewItem(currFurniture.FurnitureId.ToString());
                newItem.SubItems.Add(currFurniture.Style);
                newItem.SubItems.Add(currFurniture.Category);
                this.ActiveRentedFurnitureList.Items.Add(newItem);
            }
        }
    }
}
