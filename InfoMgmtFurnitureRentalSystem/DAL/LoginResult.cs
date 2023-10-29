using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     A class that represents the result of a successful login attempt.
/// </summary>
public class LoginResult
{
    #region Properties

    /// <summary>
    ///     Gets the role.
    /// </summary>
    /// <value>The role.</value>
    public Role Role { get; private set; }

    /// <summary>
    ///     Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public int Id { get; private set; }

    /// <summary>
    ///     Gets the username.
    /// </summary>
    /// <value>The username.</value>
    public string Username { get; private set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="LoginResult" /> class.
    /// </summary>
    /// <param name="role">The role.</param>
    /// <param name="id">The identifier.</param>
    /// <param name="username">The username.</param>
    public LoginResult(char role, int id, string username)
    {
        this.Role = RoleExtensions.RoleFromChar(role);
        this.Id = id;
        this.Username = username;
    }

    #endregion
}