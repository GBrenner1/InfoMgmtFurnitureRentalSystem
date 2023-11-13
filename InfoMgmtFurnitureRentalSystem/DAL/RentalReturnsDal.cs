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
        public static int CreateReturnTransaction(int member, int employee, IList<Furniture> furniture, double fees)
        {
            using var connection = DalConnection.CreateConnection();

            removeForeignKeyRestraints(connection);

            connection.Open();
            var transaction = connection.BeginTransaction();
            connection.Close();

            var query = "INSERT INTO rental_returns (member_id, employee_id)" +
                        "VALUES (@member_id, @employee_id)";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@member_id", MySqlDbType.Int32).Value = member;
            command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employee;
            command.Transaction = transaction;

            connection.Open();
            command.ExecuteReader();
            var returnId = (int)command.LastInsertedId;
            command.Dispose();
            connection.Close();

            foreach (var curFurniture in furniture)
            {
                var secondQuery =
                    "INSERT INTO rental_returns_item (return_id, furniture_id, quantity, fees, rental_id)" +
                    "VALUES (@return_id, @furniture_id, @quantity, @fees, @rental_id)";

                using var secondCommand = new MySqlCommand(secondQuery, connection);
                secondCommand.Parameters.Add("@return_id", MySqlDbType.Int32).Value = returnId;
                secondCommand.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = curFurniture.FurnitureId;
                secondCommand.Parameters.Add("@quantity", MySqlDbType.Int32).Value = curFurniture.Quantity;
                secondCommand.Parameters.Add("@fees", MySqlDbType.Double).Value = fees;
                secondCommand.Parameters.Add("@rental_id", MySqlDbType.Int32).Value = curFurniture.RentalId;
                secondCommand.Transaction = transaction;


                connection.Open();
                secondCommand.ExecuteReader();
                secondCommand.Dispose();
                connection.Close();
            }

            connection.Open();
            transaction.Commit();
            connection.Close();

            enableForeignKeyRestraints(connection);

            return returnId;
        }

        private static void enableForeignKeyRestraints(MySqlConnection connection)
        {
            var foreignKeysQuery = "SET FOREIGN_KEY_CHECKS=1";
            using var fkCommand = new MySqlCommand(foreignKeysQuery, connection);
            connection.Open();
            fkCommand.ExecuteReader();
            fkCommand.Dispose();
            connection.Close();
        }

        private static void removeForeignKeyRestraints(MySqlConnection connection)
        {
            var noForeignKeysQuery = "SET FOREIGN_KEY_CHECKS=0";
            using var noFkCommand = new MySqlCommand(noForeignKeysQuery, connection);
            connection.Open();
            noFkCommand.ExecuteReader();
            noFkCommand.Dispose();
            connection.Close();
        }
    }
}
