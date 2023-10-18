namespace InfoMgmtFurnitureRentalSystem.Model;

/// <summary>
///     A class that represents an instance of an employee from the database.
/// </summary>
public class Employee
{
    #region Properties

    /// <summary>
    ///     Gets or sets the employee identifier.
    /// </summary>
    /// <value>
    ///     The employee identifier.
    /// </value>
    public int EmployeeId { get; init; }

    /// <summary>
    ///     Gets or sets the name of the employee.
    /// </summary>
    /// <value>
    ///     The name of the employee with first and last name separated by a space.
    /// </value>
    public string? EmployeeName { get; init; }

    /// <summary>
    ///     Gets or sets the value indicating whether this instance is admin.
    /// </summary>
    /// <value>
    ///     <c>true</c> if this instance is admin; otherwise, <c>false</c>.
    /// </value>
    public bool IsAdmin { get; set; }

    /// <summary>
    ///     Gets or sets the Username.
    /// </summary>
    /// <value>
    ///     The Username.
    /// </value>
    public string? Username { get; set; }

    #endregion
}