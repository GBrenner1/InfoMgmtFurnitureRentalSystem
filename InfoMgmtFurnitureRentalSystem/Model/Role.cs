namespace InfoMgmtFurnitureRentalSystem.Model
{
    public enum Role
    {
        Employee = 'E',
        Admin = 'A',
        Member = 'M'
    }

    public static class RoleExtensions
    {
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
