using InfoMgmtFurnitureRentalSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class FurnitureDal
    {
        public static IList<Furniture> getFurniture()
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture";

            using var command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IList<Furniture> furnitureList = new List<Furniture>();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var category = reader.GetString(1);
                        var style = reader.GetString(2);
                        var qty = reader.GetInt32(3);
                        var rental_rate = reader.GetDouble(4);
                        Furniture furniture = new Furniture(id,category,style,qty,rental_rate);
                        furnitureList.Add(furniture);
                    }
                    return furnitureList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<Furniture>();
        }
    }
}
