using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     The controller for the admin query page
/// </summary>
public class AdminQueryController
{
    #region Methods

    /// <summary>
    ///     Runs a given query
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public List<string> RunQuery(string query)
    {
        if (query.Contains("DELETE") || query.Contains("UPDATE"))
        {
            return new List<string>();
        }

        return QueryDal.RunAdminQuery(query);
    }

    #endregion
}