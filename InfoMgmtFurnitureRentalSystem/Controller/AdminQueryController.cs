using InfoMgmtFurnitureRentalSystem.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class AdminQueryController
    {
        public List<string> runQuery(string query)
        {
            if (query.Contains("DELETE") || query.Contains("UPDATE"))
            {
                return new List<string>();
            }

            return QueryDal.runAdminQuery(query);
        }
    }
}
