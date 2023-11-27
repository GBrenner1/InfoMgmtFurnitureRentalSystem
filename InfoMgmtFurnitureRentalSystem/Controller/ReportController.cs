using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.DAL;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class ReportController
    {
        public static string GenerateRentalReport(DateTime startDate, DateTime endDate)
        {
            return RentalDal.GetRentalDateReport(startDate, endDate);
        }
    }
}
