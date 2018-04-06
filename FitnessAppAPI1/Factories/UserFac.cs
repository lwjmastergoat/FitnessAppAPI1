using System;
using System.Data.SqlClient;

namespace FitnessAppAPI1
{


	 public class UserFac:AutoFac<User>
	 {

        public User Login(string username, string password)
        {
            User u = new User();

            string SQL = "SELECT * FROM [User] WHERE Username=@username AND Password=@password";

            using (var cmd = new SqlCommand(SQL, Conn.CreateConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                var mapper = new Mapper<User>();
                var r = cmd.ExecuteReader();

                if (r.Read())
                {
                    u = mapper.Map(r);
                }

                r.Close();
                cmd.Connection.Close();
                return u;
            }
        }
        

	 }

}
