
using InfoMgmtFurnitureRentalSystem.Model;
using MySqlConnector;
using System;
using System.Linq;

namespace InfoMgmtFurnitureRentalSystem.DAL
{
    public class MemberDal
    {
        public static Boolean InsertMember(Member member)
        {
            using (var connection = DalConnection.CreateConnection())
            {
                var query = "INSERT INTO members ( fname, lname, gender, phone, street_addr, city, state, zip, birthday, registration_date)";
                query += "VALUES (@fname, @lname, @gender, @phone, @street_addr, @city, @state, @zip, @birthday, @registration_date)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = member.Fname;
                    command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = member.Lname;
                    command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = member.Gender;
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = member.Phone;
                    command.Parameters.Add("@street_addr", MySqlDbType.VarChar).Value = member.Street_addr;
                    command.Parameters.Add("@city", MySqlDbType.VarChar).Value = member.City;
                    command.Parameters.Add("@state", MySqlDbType.VarChar).Value = member.State;
                    command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = member.Zip;
                    command.Parameters.Add("@birthday", MySqlDbType.Date).Value = member.Birthday;
                    command.Parameters.Add("@registration_date", MySqlDbType.Date).Value = member.Regestration_date;

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
            }
        }
    }
}
