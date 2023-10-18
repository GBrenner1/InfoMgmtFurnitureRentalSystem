using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     A class that handles all database access to the employee table
/// </summary>
public class EmployeeDal
{
    #region Methods

    public static Employee? GetEmployeeWith(int loginId)
    {
        using var connection = DalConnection.CreateConnection();
        connection.Open();
        const string query =
            "select e_id, fname, lname from employee where l_id = @loginId";
        var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@loginId", MySqlDbType.Int32);
        command.Parameters["@loginId"].Value = loginId;

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            var employee = new Employee
            {
                EmployeeId = reader.GetInt32("e_id"),
                EmployeeName = reader.GetString("fname") + " " + reader.GetString("lname"),
                IsAdmin = false,
                Username = ""
            };
            return employee;
        }

        return null;
    }

    #endregion
}