using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

public class LoginDal
{
    #region Methods

    /// <summary>
    ///     Takes in login credentials and checks if they are valid. If they are returns a LoginResult
    ///     representing the user that logged in. If not, returns null.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="password">The password.</param>
    /// <returns>A LoginResult object representing who logged in if valid, null otherwise.</returns>
    public static LoginResult? CheckLogin(string username, string password)
    {
        var connection = DalConnection.CreateConnection();
        connection.Open();
        const string query =
            "select role, l_id from login where username = @username and password = @password";
        var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@username", MySqlDbType.VarChar);
        command.Parameters["@username"].Value = username;

        command.Parameters.Add("@password", MySqlDbType.VarChar);
        command.Parameters["@password"].Value = password;

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            var loginId = reader.GetInt32("l_id");
            var role = reader.GetChar("role");
            connection.Close();
            return new LoginResult(role, loginId, username);
        }

        return null;
    }

    #endregion
}