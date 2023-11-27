using System.Diagnostics.CodeAnalysis;
using System.Text;
using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     the rental returns dal
/// </summary>
public class RentalReturnsDal
{
    #region Methods

    /// <summary>
    ///     creates a return transaction
    /// </summary>
    /// <param name="member"></param>
    /// <param name="employee"></param>
    /// <param name="furniture"></param>
    /// <param name="fees"></param>
    /// <returns></returns>
    public static int CreateReturnTransaction(int member, int employee, IList<Furniture> furniture, double fees)
    {
        using var connection = DalConnection.CreateConnection();

        connection.Open();
        var transaction = connection.BeginTransaction();

        var query = "INSERT INTO rental_returns (member_id, employee_id, return_date)" +
                    "VALUES (@member_id, @employee_id, @return_date)";

        try
        {
            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@member_id", MySqlDbType.Int32).Value = member;
            command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee;
            command.Parameters.Add("@return_date", MySqlDbType.Date).Value = DateTime.Now;
            command.Transaction = transaction;

            var reader = command.ExecuteReader();
            var returnId = (int)command.LastInsertedId;
            reader.Close();
            command.Dispose();

            foreach (var curFurniture in furniture)
            {
                var secondQuery =
                    "INSERT INTO rental_returns_item (return_id, furniture_id, quantity, fees, rental_id)" +
                    "VALUES (@return_id, @furniture_id, @quantity, @fees, @rental_id)";

                using var secondCommand = new MySqlCommand(secondQuery, connection);
                secondCommand.Parameters.Add("@return_id", MySqlDbType.Int32).Value = returnId;
                secondCommand.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = curFurniture.FurnitureId;
                secondCommand.Parameters.Add("@quantity", MySqlDbType.Int32).Value = curFurniture.Quantity;
                secondCommand.Parameters.Add("@fees", MySqlDbType.Double).Value = fees;
                secondCommand.Parameters.Add("@rental_id", MySqlDbType.Int32).Value = curFurniture.RentalId;
                secondCommand.Transaction = transaction;

                reader = secondCommand.ExecuteReader();
                secondCommand.Dispose();
                reader.Close();
            }

            transaction.Commit();
            connection.Close();
            return returnId;
        }
        catch (Exception e)
        {
            transaction.Rollback();
            connection.Close();
            MessageBox.Show(e.Message);
            return -1;
        }
    }

    public static string GetReturnDateReport(DateTime startDate, DateTime endDate)
    {
        var query = getReturnDateReportQuery();
        var report = new StringBuilder();
        using var connection = DalConnection.CreateConnection();
        var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
        command.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;

        try
        {
            connection.Open();
            var reader = command.ExecuteReader();
            report.Append("Return ID\tMember ID\tEmployee ID\tReturn Date\tRental ID\tFurniture ID\tQuantity\n");
            while (reader.Read())
            {
                report.Append($"{reader["return_id"]}\t{reader["member_id"]}\t{reader["employee_id"]}\t{reader["return_date"]}\t{reader["rental_id"]}\t{reader["furniture_id"]}\t{reader["quantity"]}\n");
            }

            reader.Close();
            connection.Close();
            return report.ToString();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Return Report Generation Failed");
            return "Generation Failed";
        }   
    }

    private static string getReturnDateReportQuery()
    {
        const string query = "call generateReturnDateReport(@startDate, @endDate)";
        return query;
    }

    #endregion
}