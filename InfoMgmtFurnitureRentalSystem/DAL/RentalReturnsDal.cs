using System.Diagnostics.CodeAnalysis;
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

    private static void enableForeignKeyRestraints(MySqlConnection connection)
    {
        var foreignKeysQuery = "SET FOREIGN_KEY_CHECKS=1";
        using var fkCommand = new MySqlCommand(foreignKeysQuery, connection);
        connection.Open();
        fkCommand.ExecuteReader();
        fkCommand.Dispose();
        connection.Close();
    }

    private static void removeForeignKeyRestraints(MySqlConnection connection)
    {
        var noForeignKeysQuery = "SET FOREIGN_KEY_CHECKS=0";
        using var noFkCommand = new MySqlCommand(noForeignKeysQuery, connection);
        connection.Open();
        noFkCommand.ExecuteReader();
        noFkCommand.Dispose();
        connection.Close();
    }

    #endregion
}