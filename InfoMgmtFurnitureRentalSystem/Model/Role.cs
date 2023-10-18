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
            switch (role)
            {
                case 'E':
                    return Role.Employee;
                case 'A':
                    return Role.Admin;
                case 'M':
                    return Role.Member;
                default:
                    throw new ArgumentException("Invalid role character");
            }
        }
    }
}
