using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL;

/// <summary>
///     The member DAL class
/// </summary>
public class MemberDal
{
    #region Methods

    /// <summary>
    ///     the function to insert a new member into the DB
    /// </summary>
    /// <param name="member"></param>
    /// <returns></returns>
    public static bool InsertMember(Member member)
    {
        using var connection = DalConnection.CreateConnection();
        var query =
            "INSERT INTO members ( fname, lname, gender, phone, street_addr, city, state, zip, birthday, registration_date)";
        query +=
            "VALUES (@fname, @lname, @gender, @phone, @street_addr, @city, @state, @zip, @birthday, @registration_date)";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = member.Fname;
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = member.Lname;
        command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = member.Gender;
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = member.Phone;
        command.Parameters.Add("@street_addr", MySqlDbType.VarChar).Value = member.StreetAddr;
        command.Parameters.Add("@city", MySqlDbType.VarChar).Value = member.City;
        command.Parameters.Add("@state", MySqlDbType.VarChar).Value = member.State;
        command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = member.Zip;
        command.Parameters.Add("@birthday", MySqlDbType.Date).Value = member.Birthday;
        command.Parameters.Add("@registration_date", MySqlDbType.Date).Value = member.RegestrationDate;

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    /// <summary>
    ///     Gets all members to be loaded on launch
    /// </summary>
    /// <returns></returns>
    public static IList<Member> GetMembers()
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM members";

        using var command = new MySqlCommand(query, connection);

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            IList<Member> membersList = new List<Member>();
            while (reader.Read())
            {
                var id = reader.GetString(0);
                var fname = reader.GetString(1);
                var lname = reader.GetString(2);
                var gender = reader.GetString(3);
                var phone = reader.GetString(4);
                var streetAddr = reader.GetString(5);
                var city = reader.GetString(6);
                var state = reader.GetString(7);
                var zip = reader.GetString(8);
                var birthdate = DateTime.Parse(reader.GetString(9));
                var registrationDate = DateTime.Parse(reader.GetString(10));
                var member = new Member(id, fname, lname, gender, phone, streetAddr, city, state, zip,
                    birthdate, registrationDate);
                membersList.Add(member);
            }

            connection.Close();
            return membersList;
        }

        return new List<Member>();
    }

    /// <summary>
    ///     Searches members by name
    /// </summary>
    /// <param name="fName"></param>
    /// <param name="lName"></param>
    /// <returns></returns>
    public static IList<Member> SearchByName(string fName, string lName)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM members WHERE fname = @fname AND lname = @lname";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fName;
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lName;

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                IList<Member> membersList = new List<Member>();
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var fname = reader.GetString(1);
                    var lname = reader.GetString(2);
                    var gender = reader.GetString(3);
                    var phone = reader.GetString(4);
                    var streetAddr = reader.GetString(5);
                    var city = reader.GetString(6);
                    var state = reader.GetString(7);
                    var zip = reader.GetString(8);
                    var birthdate = DateTime.Parse(reader.GetString(9));
                    var registrationDate = DateTime.Parse(reader.GetString(10));
                    var member = new Member(id, fname, lname, gender, phone, streetAddr, city, state, zip,
                        birthdate, registrationDate);
                    membersList.Add(member);
                }

                connection.Close();
                return membersList;
            }
        }
        catch (Exception e)
        {
        }

        return new List<Member>();
    }

    /// <summary>
    ///     Searches members by ID
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns></returns>
    public static IList<Member> SearchById(string memberId)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM members WHERE member_id = @id";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = memberId;

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            IList<Member> membersList = new List<Member>();
            while (reader.Read())
            {
                var id = reader.GetString(0);
                var fname = reader.GetString(1);
                var lname = reader.GetString(2);
                var gender = reader.GetString(3);
                var phone = reader.GetString(4);
                var streetAddr = reader.GetString(5);
                var city = reader.GetString(6);
                var state = reader.GetString(7);
                var zip = reader.GetString(8);
                var birthdate = DateTime.Parse(reader.GetString(9));
                var registrationDate = DateTime.Parse(reader.GetString(10));
                var member = new Member(id, fname, lname, gender, phone, streetAddr, city, state, zip,
                    birthdate, registrationDate);
                membersList.Add(member);
            }

            connection.Close();
            return membersList;
        }

        return new List<Member>();
    }

    /// <summary>
    ///     Searches members by Phone number
    /// </summary>
    /// <param name="phoneNum"></param>
    /// <returns></returns>
    public static IList<Member> SearchByPhone(string phoneNum)
    {
        using var connection = DalConnection.CreateConnection();
        var query = "SELECT * FROM members WHERE phone = @phone";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneNum;

        connection.Open();
        command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            IList<Member> membersList = new List<Member>();
            while (reader.Read())
            {
                var id = reader.GetString(0);
                var fname = reader.GetString(1);
                var lname = reader.GetString(2);
                var gender = reader.GetString(3);
                var phone = reader.GetString(4);
                var streetAddr = reader.GetString(5);
                var city = reader.GetString(6);
                var state = reader.GetString(7);
                var zip = reader.GetString(8);
                var birthdate = DateTime.Parse(reader.GetString(9));
                var registrationDate = DateTime.Parse(reader.GetString(10));
                var member = new Member(id, fname, lname, gender, phone, streetAddr, city, state, zip,
                    birthdate, registrationDate);
                membersList.Add(member);
            }

            connection.Close();
            return membersList;
        }

        return new List<Member>();
    }

    /// <summary>
    /// Edits the entry in the DB for the given member.
    /// </summary>
    /// <param name="member"></param>
    /// <returns>True if successful, false otherwise.</returns>
    public static bool EditMember(Member member)
    {
        using var connection = DalConnection.CreateConnection();
        var query = editMemberQuery();

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = member.Fname;
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = member.Lname;
        command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = member.Gender;
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = member.Phone;
        command.Parameters.Add("@street_addr", MySqlDbType.VarChar).Value = member.StreetAddr;
        command.Parameters.Add("@city", MySqlDbType.VarChar).Value = member.City;
        command.Parameters.Add("@state", MySqlDbType.VarChar).Value = member.State;
        command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = member.Zip;
        command.Parameters.Add("@birthday", MySqlDbType.Date).Value = member.Birthday;

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    private static string editMemberQuery()
    {
        var query =
            "UPDATE members SET fname = @fname, lname = @lname, gender = @gender, phone = @phone, street_addr = @street_addr, ";
        query += "city = @city, state = @state, zip = @zip, birthday = @birthday WHERE member_id = @id;";
        return query;
    }

    #endregion
}