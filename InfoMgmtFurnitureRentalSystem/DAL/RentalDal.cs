using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     A class that handles all database access to the Rental table and the Rental_item table
/// </summary>
public class RentalDal
{
    #region Methods

    /// <summary>
    ///     Adds the rental transaction.
    /// </summary>
    /// <param name="transaction">The transaction.</param>
    /// <returns><c>true</c> If the transaction is successfully added. <c>false</c> otherwise.</returns>
    public static bool AddRentalTransaction(RentalTransaction transaction)
    {
        using var connection = DalConnection.CreateConnection();
        var query = insertRentalTransactionQuery();

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@memberId", MySqlDbType.Int32).Value = transaction.Member.MemberId;
        command.Parameters.Add("@employeeId", MySqlDbType.Int32).Value = transaction.Employee.EmployeeId;
        command.Parameters.Add("@start_date", MySqlDbType.Date).Value = transaction.RentalDate;
        command.Parameters.Add("@end_date", MySqlDbType.Date).Value = transaction.DueDate;

        try
        {
            connection.Open();
            command.ExecuteReader();
            transaction.RentalId = (int)command.LastInsertedId;
            addRentalItems(transaction, connection);
            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    private static string insertRentalTransactionQuery()
    {
        var query = "INSERT INTO rental_transactions (employee_id, member_id, rental_date, due_date) ";
        query += "VALUES (@memberId, @employeeId, @start_date, @end_date);";
        return query;
    }

    private static void addRentalItems(RentalTransaction transaction, MySqlConnection connection)
    {
        var query = insertRentalItemQuery();
        foreach (var item in transaction.RentalItems)
        {
            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@rentalId", MySqlDbType.Int32).Value = transaction.RentalId;
            command.Parameters.Add("@furniture_Id", MySqlDbType.Int32).Value = item.FurnitureId;
            command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = item.Quantity;
            command.ExecuteNonQuery();
        }
    }

    private static string insertRentalItemQuery()
    {
        var query = "INSERT INTO rental_item (rental_id, furniture_id, quantity) ";
        query += "VALUES (@rentalId, @furniture_Id, @quantity);";
        return query;
    }

    #endregion
}