using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     Class designed to pass data between the login screen and the database.
/// </summary>
public class LoginController
{
    #region Properties

    /// <summary>
    ///     Gets or sets the current employee.
    /// </summary>
    /// <value>
    ///     The current employee or null if no employee is logged in.
    /// </value>
    public Employee? CurrentEmployee { get; set; }

    #endregion

    #region Methods

    /// <summary>
    ///     Checks the login credentials against the database.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="password">The password.</param>
    /// <returns>The employee as an object if their information is valid, null otherwise.</returns>
    public static Employee? CheckLogin(string username, string password)
    {
        return EmployeeDal.CheckLogin(username, password);
    }

    #endregion
}