using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class QueryDal
    {
        public static List<string> runAdminQuery(string adminQuery)
        {
            using var connection = DalConnection.CreateConnection();

            using var command = new MySqlCommand(adminQuery, connection);

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                List<string> resultList = new List<string>();
                var namesRow = "";

                for (int i = 0; i < reader.FieldCount; i++)
                {
                        namesRow += reader.GetName(i) + ",";
                }

                namesRow = namesRow.Remove(namesRow.Length - 1, 1);
                resultList.Add(namesRow);

                while (reader.Read())
                {
                    var row = "";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(reader[i].ToString()))
                        {
                            row += reader[i].ToString() + ",";
                        }
                    }

                    row = row.Remove(row.Length - 1, 1);
                    resultList.Add(row);
                }

                connection.Close();
                return resultList;
            }

            return new List<string>();
        }
    }
}
