﻿using System;
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
using Microsoft.VisualBasic;

namespace InfoMgmtFurnitureRentalSystem.View
{
    public partial class ReturnFurniturePage : Form
    {
        private ReturnController ReturnController { get; }

        private receiptForm receiptForm { get; set; }

        private string incurredFees { get; set; }

        /// <summary>
        /// the controller for the return page
        /// </summary>
        /// <param name="returnController"></param>
        public ReturnFurniturePage(ReturnController returnController)
        {
            this.InitializeComponent();
            this.centerForm();
            this.ReturnController = returnController;


            this.reloadFurnitureList();
            this.incurredFees = this.ReturnController.CalculateFees();
            this.FeesTextBox.Text = this.incurredFees;
        }
        private void centerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void qtyChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = this.furnitureList.SelectedItems[0];
                var furnitureId = int.Parse(item.SubItems[0].Text);
                var furniture = this.ReturnController.GetFurniture(furnitureId);
                var quantity =
                    int.Parse(Interaction.InputBox("Enter the new quantity", "Change Quantity",
                        furniture.Quantity.ToString()));
                furniture.Quantity = quantity;
                item.SubItems[4].Text = quantity.ToString();

                this.incurredFees = this.ReturnController.CalculateFees();
                this.FeesTextBox.Text = this.incurredFees;
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

        private void reloadFurnitureList()
        {
            foreach (var curFurniture in this.ReturnController.Furniture!)
            {
                var newItem = new ListViewItem(curFurniture.FurnitureId.ToString());
                newItem.SubItems.Add(curFurniture.Style);
                newItem.SubItems.Add(curFurniture.Category);
                newItem.SubItems.Add(curFurniture.RentalRate.ToString(CultureInfo.CurrentCulture));
                newItem.SubItems.Add(curFurniture.Quantity.ToString());
                newItem.SubItems.Add(curFurniture.DueDate);
                newItem.SubItems.Add(curFurniture.RentalId);

                this.furnitureList.Items.Add(newItem);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to return these items?",
                "Confirm return",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var transactionId = this.ReturnController.compleateReturnTransaction(this.FeesTextBox.Text);
                Hide();

                var receiptController = new ReciptController(this.FeesTextBox.Text, transactionId, this.ReturnController.Furniture);

                this.receiptForm = new receiptForm(receiptController);
                this.receiptForm.Show();
            }
            else
            {
                return;
            }
        }
    }
}
