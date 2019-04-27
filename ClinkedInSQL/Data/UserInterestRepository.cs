using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinkedInSQL.Models;

namespace ClinkedInSQL.Data
{
    public class UserInterestRepository
    {
        static List<UserInterest> _userInterests = new List<UserInterest>();

        public List<UserInterest> GetAllUserInterests()
        {
            var userInterests = new List<UserInterest>();

            var connection = new SqlConnection("Server=localhost;Database=ClinkedIn;Trusted_Connection=True;");

            connection.Open();

            var getAllUserInterestsCommand = connection.CreateCommand();

            getAllUserInterestsCommand.CommandText = @"select u.Name, i.Name Interest
                                                      from UserInterestJoin ui
                                                      left join Users u on u.Id = ui.UserId
                                                      left join Interests i on i.Id = ui.InterestId
                                                      order by u.Name";
            var reader = getAllUserInterestsCommand.ExecuteReader();

            while (reader.Read())
            {
                var name = (string)reader["Name"];
                var interest = (string)reader["Interest"];

                var userInterest = new UserInterest(name, interest);

                userInterests.Add(userInterest);
            }

            connection.Close();

            return userInterests;
        }
    }
}
