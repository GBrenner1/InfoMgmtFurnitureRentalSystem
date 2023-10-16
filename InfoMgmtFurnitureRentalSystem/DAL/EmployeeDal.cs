using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     A class that handles all database access to the employee table
/// </summary>
public class EmployeeDal
{
    #region Methods

    /// <summary>
    ///     Takes in login credentials and checks if they are valid. If they are, returns the employee object
    ///     representing the employee that logged in. If not, returns null.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="password">The password.</param>
    /// <returns>An employee object representing who logged in if valid, null otherwise.</returns>
    public static Employee? CheckLogin(string username, string password)
    {
        using var connection = DalConnection.CreateConnection();
        connection.Open();
        const string query =
            "select e_id, fname, lname, role from employee where username = @username and password = @password";
        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@username", MySqlDbType.VarChar);
        command.Parameters["@username"].Value = username;

        command.Parameters.Add("@password", MySqlDbType.VarChar);
        command.Parameters["@password"].Value = password;

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            var isAdmin = false;
            if (!reader.IsDBNull(3))
            {
                isAdmin = reader.GetString(3).Equals("A");
            }

            var employee = new Employee
            {
                EmployeeId = reader.GetInt32(0),
                EmployeeName = reader.GetString(1) + " " + reader.GetString(2),
                IsAdmin = isAdmin
            };
            return employee;
        }

        return null;
    }

    #endregion
}