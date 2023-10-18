using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class LoginResult
    {
        public Role Role { get; private set; }

        public int Id { get; private set; }

        public string Username { get; private set; }

        public LoginResult(char role, int id, string username)
        {
            this.Role = RoleExtensions.RoleFromChar(role);
            this.Id = id;
            this.Username = username;
        }
    }
}
