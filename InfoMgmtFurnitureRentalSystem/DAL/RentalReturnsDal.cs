using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class RentalReturnsDal
    {
        public static int CreateReturnTransaction(int member, int employee)
        {
            using var connection = DalConnection.CreateConnection();
            var query = "INSERT INTO rental_returns (member_id, employee_id)" +
                        "VALUES (@member_id, @employee_id)";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@member_id", MySqlDbType.Int32).Value = member;
            command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee;

            try
            {
                connection.Open();
                command.ExecuteReader();
                var returnId = (int)command.LastInsertedId;
                command.Dispose();
                connection.Close();
                return returnId;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static bool addFurnitureReturn(int returnId, Furniture furniture, double fees)
        {
            using var connection = DalConnection.CreateConnection();
            var query = "INSERT INTO rental_returns_item (return_id, furniture_id, quantity, fees, rental_id)" +
                        "VALUES (@return_id, @furniture_id, @quantity, @fees, @rental_id)";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@return_id", MySqlDbType.Int32).Value = returnId;
            command.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = furniture.FurnitureId;
            command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = furniture.Quantity;
            command.Parameters.Add("@fees", MySqlDbType.Double).Value = fees;
            command.Parameters.Add("@rental_id", MySqlDbType.Int32).Value = furniture.RentalId;
            try
            {
                connection.Open();
                command.ExecuteReader();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
