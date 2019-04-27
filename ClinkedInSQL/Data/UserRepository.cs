using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinkedInSQL.Models;

namespace ClinkedInSQL.Data
{
    public class UserRepository
    {
        static List<User> _users = new List<User>();

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            var connection = new SqlConnection("Server=localhost;Database=ClinkedIn;Trusted_Connection=True;");

            connection.Open();

            var getAllUsersCommand = connection.CreateCommand();

            getAllUsersCommand.CommandText = @"select * from users";

            var reader = getAllUsersCommand.ExecuteReader();

            while (reader.Read())
            {
                var id = (int)reader["Id"];
                var name = reader["Name"].ToString(); // could be (string)reader["name"];
                var releaseDate = reader["releaseDate"] == DBNull.Value ? null : (DateTime?)reader["releaseDate"];
                var isPrisoner = (bool)reader["isPrisoner"];
                var age = reader["age"] == DBNull.Value ? null : (int?)reader["age"];

                var user = new User(id, name, releaseDate, isPrisoner, age);

                users.Add(user);
            }

            connection.Close();

            return users;
        } 
    }
}
