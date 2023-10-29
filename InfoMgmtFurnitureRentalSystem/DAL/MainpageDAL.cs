using System.Collections;
using System.Collections.Immutable;
using InfoMgmtFurnitureRentalSystem.Model;
using MySql.Data.MySqlClient;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class MainpageDAL
    {
        public static IList<Member> GetMembers()
        {
            using var connection = DalConnection.CreateConnection();
            var query = "SELECT * FROM members";

            using var command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();
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
                        var street_addr = reader.GetString(5);
                        var city = reader.GetString(6);
                        var state = reader.GetString(7);
                        var zip = reader.GetString(8);
                        var birthdate = DateTime.Parse(reader.GetString(9));
                        var registration_date = DateTime.Parse(reader.GetString(10));
                        Member member = new Member(id,fname, lname, gender, phone, street_addr, city, state, zip,
                            birthdate, registration_date);
                        membersList.Add(member);
                    }
                    return membersList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<Member>();
        }
    }
}
