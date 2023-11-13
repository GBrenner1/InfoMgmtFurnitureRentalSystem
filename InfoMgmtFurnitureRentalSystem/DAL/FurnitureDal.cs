using System.Globalization;
using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     the furniture DAL class
/// </summary>
public class FurnitureDal
{
    #region Methods

    /// <summary>
    ///     Updates the quantities.
    /// </summary>
    /// <param name="furnitureList">The furniture list.</param>
    /// <returns><c>true</c> if the quantities are updated, <c>false</c> otherwise.</returns>
    public static bool UpdateQuantities(IList<Furniture> furnitureList)
    {
        try
        {
            var quantitiesRented = furnitureList.Select(f => f.Quantity);
            var quantitiesAvailable = GetFurniture().Select(f => f.Quantity);
            var quantities = quantitiesAvailable.Zip(quantitiesRented, (available, rented) => available - rented)
                .ToArray();
            using var connection = DalConnection.CreateConnection();
            connection.Open();
            const string query = "UPDATE furniture SET quantity = @qty WHERE furniture_id = @furnitureId";
            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@qty", MySqlDbType.Int32);
            command.Parameters.Add("@furnitureId", MySqlDbType.Int32);
            for (var i = 0; i < furnitureList.Count; i++)
            {
                command.Parameters["@qty"].Value = quantities[i];
                command.Parameters["@furnitureId"].Value = furnitureList[i].FurnitureId;
                command.ExecuteNonQuery();
            }

            connection.Close();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    ///     Gets all furniture for initial load
    /// </summary>
    /// <returns></returns>
    public static IList<Furniture> GetFurniture()
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
                    var qty = reader.GetInt32(4);
                    var rentalRate = reader.GetDouble(3);
                    var furniture = new Furniture(id, category, style, qty, rentalRate);
                    furnitureList.Add(furniture);
                }

                connection.Close();
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
    public static IList<string> GetStyles()
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

                connection.Close();
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
    public static IList<string> GetCategories()
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
                IList<string> categoriesList = new List<string>();
                while (reader.Read())
                {
                    categoriesList.Add(reader.GetString(0));
                }

                connection.Close();
                return categoriesList;
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
    public static IList<Furniture> SearchFurniture(string furnitureId, string furnitureCategory, string furnitureStyle)
    {
        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle) &&
            string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return SearchAllValuesEmpty();
        }

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return SearchFurnitureByStyle(furnitureStyle);
        }

        if (string.IsNullOrWhiteSpace(furnitureId) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return SearchFurnitureByCategory(furnitureCategory);
        }

        if (string.IsNullOrWhiteSpace(furnitureCategory) && string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return SearchFurnitureById(furnitureId);
        }

        if (string.IsNullOrWhiteSpace(furnitureStyle))
        {
            return SearchFurnitureByIdAndCategory(furnitureId, furnitureCategory);
        }

        if (string.IsNullOrWhiteSpace(furnitureCategory))
        {
            return SearchFurnitureByIdAndStyle(furnitureId, furnitureStyle);
        }

        if (string.IsNullOrWhiteSpace(furnitureId))
        {
            return SearchFurnitureByStyleAndCategory(furnitureCategory, furnitureStyle);
        }

        return new List<Furniture>();
    }

    private static IList<Furniture> SearchFurnitureByStyleAndCategory(string furnitureCategory, string furnitureStyle)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE category_name = @cat_name AND style_name = @style_name";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;
        command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchFurnitureByIdAndStyle(string furnitureId, string furnitureStyle)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id AND style_name = @style_name";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;
        command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchFurnitureByIdAndCategory(string furnitureId, string furnitureCategory)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id AND category_name = @cat_name";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;
        command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchFurnitureById(string furnitureId)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE furniture_id = @furn_id";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@furn_id", MySqlDbType.VarChar).Value = furnitureId;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchFurnitureByCategory(string furnitureCategory)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE category_name = @cat_name";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = furnitureCategory;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchFurnitureByStyle(string furnitureStyle)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture WHERE style_name = @style_name";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@style_name", MySqlDbType.VarChar).Value = furnitureStyle;

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> SearchAllValuesEmpty()
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM furniture";

        using var command = new MySqlCommand(query, connection);

        return runSearchConnection(connection, command);
    }

    private static IList<Furniture> runSearchConnection(MySqlConnection connection, MySqlCommand command)
    {
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
                    var rentalRate = reader.GetDouble(4);
                    var furniture = new Furniture(id, category, style, qty, rentalRate);
                    furnitureList.Add(furniture);
                }

                connection.Close();
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
    /// gets all active rentals for a member
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns></returns>
    public static IList<Furniture> GetMembersCurrentRentedFurniture(int memberId)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "CALL getMembersCurrentFurniture(@member_id)";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@member_id", MySqlDbType.VarChar).Value = memberId;

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
                    var rentalRate = reader.GetDouble(4);
                    var dueDateWithTime = reader.GetDateTime(5).ToString(CultureInfo.CurrentCulture);
                    var dueDate = dueDateWithTime.Split(' ')[0];
                    var rentalId = reader.GetString(6);
                    var furniture = new Furniture(id, category, style, qty, rentalRate, dueDate, rentalId);
                    furnitureList.Add(furniture);
                }

                connection.Close();
                return furnitureList;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return new List<Furniture>();
    }

    public static int getRentalFurnitureQuantity(int furnitureId, int rentalId)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT quantity FROM rental_item WHERE rental_id = @rental_id AND furniture_id = @furniture_id";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@rental_id", MySqlDbType.VarChar).Value = rentalId;
        command.Parameters.Add("@furniture_id", MySqlDbType.VarChar).Value = furnitureId;

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        reader.Read();
        try
        {
            var quantity = reader.GetInt32(0);

            connection.Close();
            return quantity;
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return 0;
    }

    public static void updateRentalFurnitureQuantity(int furnitureId, int rentalId, int newQuantity)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "UPDATE rental_item SET quantity = @quantity WHERE furniture_id = @furniture_id AND rental_id = @rental_id";

        using var command = new MySqlCommand( query, connection);
        command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = newQuantity;
        command.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = furnitureId;
        command.Parameters.Add("@rental_id", MySqlDbType.Int32).Value = rentalId;

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public static int getFurnitureQuantity(int furnitureId)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT quantity FROM furniture WHERE furniture_id = @furniture_id";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@furniture_id", MySqlDbType.VarChar).Value = furnitureId;

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        reader.Read();
        try
        {
            var quantity = reader.GetInt32(0);

            connection.Close();
            return quantity;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return 0;
    }

    public static void updateFurnitureQuantity(int furnitureId, int newQuantity)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "UPDATE furniture SET quantity = @quantity WHERE furniture_id = @furniture_id";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = newQuantity;
        command.Parameters.Add("@furniture_id", MySqlDbType.Int32).Value = furnitureId;

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    #endregion
}