using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
// This was nammed incorectly when the project was created and now I can't figure out how to 
// revert it, so instead of star_wars, I need to use WebApplication1
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class StarWarsCharacterDAL
    {
        
        // This is like our map to row methods 
        public List<StarWarsCharacter> GetCharacters()
        {
            List<StarWarsCharacter> output = new List<StarWarsCharacter>();

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=StarWars;Trusted_Connection=True;"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Characters;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        StarWarsCharacter character = new StarWarsCharacter();
                        character.Name = Convert.ToString(reader["name"]);
                        character.HomePlanet = Convert.ToString(reader["homeplanet"]);
                        character.IsForceSensitive = Convert.ToBoolean(reader["isForceSensitive"]);
                        character.IsDarkSide = Convert.ToBoolean(reader["isDarkSide"]);

                        output.Add(character);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }

            return output;
        }

    }
}