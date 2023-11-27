using InfoMgmtFurnitureRentalSystem.Controller;

namespace InfoMgmtFurnitureRentalSystem.View;

public partial class ReportForm : Form
{
    #region Constructors

    public ReportForm()
    {
        this.InitializeComponent();
        this.centerForm();
    }

    #endregion

    #region Methods

    private void centerForm()
    {
        CenterToScreen();
    }

    private void generateReturnReportButton_Click(object sender, EventArgs e)
    {
        if (this.startDatePicker.Value > this.endDatePicker.Value)
        {
            MessageBox.Show("Start date must be before end date");
            return;
        }

        this.reportBox.Text =
            ReportController.GenerateReturnReport(this.startDatePicker.Value, this.endDatePicker.Value);
    }

    private void generateRentalReportButton_Click(object sender, EventArgs e)
    {
        if (this.startDatePicker.Value > this.endDatePicker.Value)
        {
            MessageBox.Show("Start date must be before end date");
            return;
        }

        this.reportBox.Text =
            ReportController.GenerateRentalReport(this.startDatePicker.Value, this.endDatePicker.Value);
    }

    #endregion
}