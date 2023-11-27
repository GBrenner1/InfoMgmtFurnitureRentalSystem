using InfoMgmtFurnitureRentalSystem.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    /// <summary>
    ///     The controller for the admin query page
    /// </summary>
    public class AdminQueryController
    {
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
    }
}
