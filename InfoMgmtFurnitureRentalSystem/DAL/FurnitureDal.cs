using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     the furniture DAL class
/// </summary>
public class FurnitureDal
{
    #region Methods

    public static bool UpdateQuantities(IEnumerable<Furniture> furnitures) {
        using var connection = DalConnection.CreateConnection();
        var query = "UPDATE furniture SET quantity = @quantity WHERE furniture_id = @furniture_id";

        using var command = new MySqlCommand(query, connection);
        foreach (var furniture in furnitures)
        {
            command.Parameters.Clear();
            command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = furniture.Quantity;
            command.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = furniture.FurnitureId;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        return true;
    }

    /// <summary>
    ///     Gets all furniture for initial load
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    ///     Gets all furniture styles
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    ///     Gets all furniture categories
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    ///     Searches through furniture based on three parameters
    /// </summary>
    /// <param name="furnitureId"></param>
    /// <param name="furnitureCategory"></param>
    /// <param name="furnitureStyle"></param>
    /// <returns></returns>
    public static IList<Furniture> searchFurniture(string furnitureId, string furnitureCategory, string furnitureStyle)
    {
        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle) &&
            string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return searchFurniture();
        }

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return searchFurnitureS(furnitureStyle);
        }

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return searchFurnitureC(furnitureCategory);
        }

        if (string.IsNullOrWhiteSpace(furnitureCategory) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return searchFurnitureI(furnitureId);
        }

        if (string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return searchFurnitureIC(furnitureId, furnitureCategory);
        }

        if (string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return searchFurnitureIS(furnitureId, furnitureStyle);
        }

        return string.IsNullOrWhiteSpace(furnitureId) ? searchFurnitureSC(furnitureCategory, furnitureStyle) : new List<Furniture>();
    }

    private static IList<Furniture> searchFurniture()
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

    private static IList<Furniture> searchFurnitureS(string furnitureStyle)
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

    private static IList<Furniture> searchFurnitureC(string furnitureCategory)
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

    private static IList<Furniture> searchFurnitureI(string furnitureId)
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

    private static IList<Furniture> searchFurnitureIS(string furnitureId, string furnitureStyle)
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

    private static IList<Furniture> searchFurnitureSC(string furnitureCategory, string furnitureStyle)
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

    private static IList<Furniture> searchFurnitureIC(string furnitureId, string furnitureCategory)
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

    #endregion
}