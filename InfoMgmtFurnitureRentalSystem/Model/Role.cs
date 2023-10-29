namespace InfoMgmtFurnitureRentalSystem.Model
{
    /// <summary>
    /// The employee rolls enum
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// the employee roll
        /// </summary>
        Employee = 'E',
        /// <summary>
        /// the admin roll
        /// </summary>
        Admin = 'A',
        /// <summary>
        /// the member roll
        /// </summary>
        Member = 'M'
    }
    /// <summary>
    /// The role extensions class
    /// </summary>
    public static class RoleExtensions
    {
        /// <summary>
        /// Gets the roll of the employee
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static Role RoleFromChar(char role)
        {
            return role switch
            {
                'E' => Role.Employee,
                'A' => Role.Admin,
                'M' => Role.Member,
                _ => throw new ArgumentException("Invalid role character"),
            };
        }
    }
}
