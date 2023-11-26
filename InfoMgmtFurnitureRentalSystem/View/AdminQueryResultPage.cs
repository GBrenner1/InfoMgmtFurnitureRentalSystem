using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMgmtFurnitureRentalSystem.View
{
    public partial class AdminQueryResultPage : Form
    {
        public AdminQueryResultPage(List<string> result)
        {
            this.InitializeComponent();
            this.centerForm();

            var columnNames = result[0].Split(",");
            foreach (var columnName in columnNames)
            {
                this.resultListView.Columns.Add(columnName);
            }

            for (int i = 1; i < result.Count; i++)
            {
                var splitRow = result[i].Split(",");
                var item = new ListViewItem(splitRow[0]);
                for (int j = 1; j < splitRow.Length; j++)
                {
                    item.SubItems.Add(splitRow[j]);
                }
                this.resultListView.Items.Add(item);
            }

            foreach (ColumnHeader column in this.resultListView.Columns)
            {
                column.Width = -2;
            }
        }

        private void centerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
