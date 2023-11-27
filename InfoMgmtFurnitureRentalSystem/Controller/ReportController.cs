using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller;

public class ReportController
{
    #region Methods

    public static string GenerateRentalReport(DateTime startDate, DateTime endDate)
    {
        return RentalDal.GetRentalDateReport(startDate, endDate);
    }

    public static string GenerateReturnReport(DateTime startDate, DateTime endDate)
    {
        return RentalReturnsDal.GetReturnDateReport(startDate, endDate);
    }

    #endregion
}