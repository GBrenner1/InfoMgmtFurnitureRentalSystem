namespace InfoMgmtFurnitureRentalSystem.View;

/// <summary>
///     the result page for the admins query
/// </summary>
public partial class AdminQueryResultPage : Form
{
    #region Constructors

    /// <summary>
    ///     Builds a new result page
    /// </summary>
    /// <param name="result"></param>
    public AdminQueryResultPage(List<string> result)
    {
        this.InitializeComponent();
        this.centerForm();

        var columnNames = result[0].Split(",");
        foreach (var columnName in columnNames)
        {
            this.resultListView.Columns.Add(columnName);
        }

        for (var i = 1; i < result.Count; i++)
        {
            var splitRow = result[i].Split(",");
            var item = new ListViewItem(splitRow[0]);
            for (var j = 1; j < splitRow.Length; j++)
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

    #endregion

    #region Methods

    private void centerForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    #endregion
}