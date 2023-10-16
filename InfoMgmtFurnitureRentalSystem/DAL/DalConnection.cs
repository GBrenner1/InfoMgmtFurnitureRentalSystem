using MySqlConnector;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public  class DalConnection
    {
        /// <summary>
        /// Creates new connection instance to the database.
        /// </summary>
        /// <returns>A MySqlConnection instance that connects to the DB</returns>
        public static MySqlConnection CreateConnection()
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "160.10.217.6",
                Port = 3306,
                UserID = "cs3230f23b",
                Password = "e[A&+hWa<fPxR;f{Du,_",
                Database = "cs3230f23b"
            };
            return new MySqlConnection(connectionStringBuilder.ToString());
        }
    }
}
