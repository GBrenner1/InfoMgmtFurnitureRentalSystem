using System.Globalization;
using InfoMgmtFurnitureRentalSystem.Controller;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.View
{
    /// <summary>
    /// class to define the active transactions form
    /// </summary>
    public partial class ActiveTransactionsForm : Form
    {
        private ActiveTransactionsController ActiveTransactionsController { get; }

        private ReturnFurniturePage ReturnFurniturePage { get; set; }

        /// <summary>
        /// Created a new active transactions form
        /// </summary>
        /// <param name="activeTransactionsController"></param>
        public ActiveTransactionsForm(ActiveTransactionsController activeTransactionsController)
        {
            this.InitializeComponent();
            this.centerForm();
            this.ActiveTransactionsController = activeTransactionsController;
            this.reloadFurnitureList();
        }

        private void centerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
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
            IList<Furniture> selectedFurnitureList = new List<Furniture>();
            foreach (ListViewItem curFurniture in this.ActiveRentedFurnitureList.Items)
            {
                if (curFurniture.Checked)
                {
                    var furnitureId = int.Parse(curFurniture.Text);
                    var category = curFurniture.SubItems[2].Text;
                    var style = curFurniture.SubItems[1].Text;
                    var quantity = int.Parse(curFurniture.SubItems[4].Text);
                    var rentalRate = double.Parse(curFurniture.SubItems[3].Text);
                    var dueDate = curFurniture.SubItems[5].Text;
                    var rentalId = curFurniture.SubItems[6].Text;
                    selectedFurnitureList.Add(new Furniture(furnitureId, category, style, quantity, rentalRate, dueDate, rentalId));
                }
            }

            if (selectedFurnitureList.Count <= 0)
            {
                MessageBox.Show("No items selected.");
            }
            else
            {
                var returnController = new ReturnController(this.ActiveTransactionsController.currMember,
                    this.ActiveTransactionsController.currEmployee, selectedFurnitureList);

                this.ReturnFurniturePage = new ReturnFurniturePage(returnController);
                this.ReturnFurniturePage.Show();
                this.ReturnFurniturePage.VisibleChanged += this.returnFurniturePageVisibilityChange;
            }
        }

        private void returnFurniturePageVisibilityChange(object? sender, EventArgs e)
        {
            Hide();
        }

        private void reloadFurnitureList()
        {
            foreach (var curFurniture in this.ActiveTransactionsController.Furniture!)
            {
                var newItem = new ListViewItem(curFurniture.FurnitureId.ToString());
                newItem.SubItems.Add(curFurniture.Style);
                newItem.SubItems.Add(curFurniture.Category);
                newItem.SubItems.Add(curFurniture.RentalRate.ToString(CultureInfo.CurrentCulture));
                newItem.SubItems.Add(curFurniture.Quantity.ToString());
                newItem.SubItems.Add(curFurniture.DueDate);
                newItem.SubItems.Add(curFurniture.RentalId);

                this.ActiveRentedFurnitureList.Items.Add(newItem);
            }
        }
    }
}
