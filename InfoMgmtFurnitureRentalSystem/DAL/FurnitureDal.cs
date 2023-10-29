using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

public class FurnitureDal
{
    #region Methods

    public static IList<Furniture> getFurniture()
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture";

        using var command = new MySqlCommand(query, connection);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
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
                    var furniture = new Furniture(id, category, style, qty, rental_rate);
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

    public static IList<string> getStyles()
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM style";

        using var command = new MySqlCommand(query, connection);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                IList<string> styleList = new List<string>();
                while (reader.Read())
                {
                    styleList.Add(reader.GetString(0));
                }

                return styleList;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return new List<string>();
    }

    public static IList<string> getCategories()
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM category";

        using var command = new MySqlCommand(query, connection);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                IList<string> CategoriesList = new List<string>();
                while (reader.Read())
                {
                    CategoriesList.Add(reader.GetString(0));
                }

                return CategoriesList;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return new List<string>();
    }

    public static IList<Furniture> searchFurniture(string furnitureId, string furnitureCategory, string furnitureStyle)
    {
        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle) &&
            string.IsNullOrWhiteSpace(furnitureCategory))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture";

            using var command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                var reader = command.ExecuteReader();
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureCategory))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE style_name = @style_name";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE category_name = @cat_name";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureCategory) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureStyle))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id AND category_name = @cat_name";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;
            command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureCategory))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id AND style_name = @style_name";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;
            command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        if (string.IsNullOrWhiteSpace(furnitureId))
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM furniture WHERE category_name = @cat_name AND style_name = @style_name";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;
            command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            try
            {
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
                        var furniture = new Furniture(id, category, style, qty, rental_rate);
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

        return new List<Furniture>();
    }

    #endregion
}