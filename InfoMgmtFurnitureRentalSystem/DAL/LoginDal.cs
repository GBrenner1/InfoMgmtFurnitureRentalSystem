using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     A class that handles all database access to the login table.
/// </summary>
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
            "call `checkLogin`(@username, @password);";
        var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@username", MySqlDbType.VarChar);
        command.Parameters["@username"].Value = username;

        command.Parameters.Add("@password", MySqlDbType.VarChar);
        command.Parameters["@password"].Value = HashPassword(password);

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

    private static string HashPassword(string password)
    {
        var md5 = HashAlgorithm.Create("MD5")!;
        md5.ComputeHash(Encoding.ASCII.GetBytes(password));
        var result = md5.Hash!;
        var strBuilder = new StringBuilder();
        foreach (var t in result)
        {
            strBuilder.Append(t.ToString("x2"));
        }

        return strBuilder.ToString();
    }

    #endregion
}