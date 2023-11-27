using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     The query DAL
/// </summary>
public class QueryDal
{
    #region Methods

    /// <summary>
    ///     Runs a given query and returns the results as a list
    /// </summary>
    /// <param name="adminQuery"></param>
    /// <returns></returns>
    public static List<string> RunAdminQuery(string adminQuery)
    {
        using var connection = DalConnection.CreateConnection();

        using var command = new MySqlCommand(adminQuery, connection);

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            var resultList = new List<string>();
            var namesRow = "";

            for (var i = 0; i < reader.FieldCount; i++)
            {
                namesRow += reader.GetName(i) + ",";
            }

            namesRow = namesRow.Remove(namesRow.Length - 1, 1);
            resultList.Add(namesRow);

            while (reader.Read())
            {
                var row = "";

                for (var i = 0; i < reader.FieldCount; i++)
                {
                    if (!string.IsNullOrWhiteSpace(reader[i].ToString()))
                    {
                        row += reader[i] + ",";
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

    #endregion
}