using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class RentalDal
    {
        public static bool AddRentalTransaction(RentalTransaction transaction)
        {
            using var connection = DalConnection.CreateConnection();
            var query = insertRentalTransactionQuery(transaction);

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@memberId", MySqlDbType.Int32).Value = transaction.Member.Id;
            command.Parameters.Add("@employeeId", MySqlDbType.Int32).Value = transaction.Employee.EmployeeId;
            command.Parameters.Add("@start_date", MySqlDbType.Date).Value = transaction.RentalDate;
            command.Parameters.Add("@end_date", MySqlDbType.Date).Value = transaction.DueDate;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private static string insertRentalTransactionQuery(RentalTransaction transaction)
        { 
            var query = "INSERT INTO rental_transactions (employee_id, member_id, rental_date, due_date) ";
            query += "VALUES (@memberId, @employeeId, @start_date, @end_date);";
            return query;
        }
    }
}
