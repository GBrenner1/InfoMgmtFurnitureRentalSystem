using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     A class that handles generating reports for the rental service.
/// </summary>
public class ReportController
{
    #region Methods

    /// <summary>
    ///     Generates a rental report for a given date range.
    /// </summary>
    /// <param name="startDate">The start date for the report.</param>
    /// <param name="endDate">The end date for the report.</param>
    /// <returns>A string formatted with all the information for the report.</returns>
    public static string GenerateRentalReport(DateTime startDate, DateTime endDate)
    {
        return RentalDal.GetRentalDateReport(startDate, endDate);
    }

    /// <summary>
    ///     Generates a return report for a given date range.
    /// </summary>
    /// <param name="startDate">The start date for the report.</param>
    /// <param name="endDate">The end date for the report</param>
    /// <returns>A string formatted with all the information for the report.</returns>
    public static string GenerateReturnReport(DateTime startDate, DateTime endDate)
    {
        return RentalReturnsDal.GetReturnDateReport(startDate, endDate);
    }

    #endregion
}