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
    public partial class AdminQueryPage : Form
    {
        private AdminQueryController controller;

        private AdminQueryResultPage resultPage;
        public AdminQueryPage(AdminQueryController controller)
        {
            this.InitializeComponent();

            this.centerForm();

            this.controller = controller;
        }

        private void centerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            var queryString = this.QueryTextArea.Text;
            var result = this.controller.runQuery(queryString);

            this.resultPage = new AdminQueryResultPage(result);
            this.resultPage.Show();
        }
    }
}
