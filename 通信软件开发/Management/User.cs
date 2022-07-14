using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Management
{
    public class User
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string Title { get; set; }

        public static List<User> ListAll()
        {
            List<User> user = new List<User>();
            DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT * FROM user ORDER BY Title");
            foreach (DataRow dr in dt.Rows)
            {
                user.Add(dr.DataRowToModel<User>());
            }
            return user;
        }

        public static int Insert(User user)
        {
            return MySqlHelper.MySqlConnect.ExecuteNonQuery($"INSERT INTO user(ID,Password,Name,Sex,Title) VALUES (@ID,@Password,@Name,@Sex,@Title)",
                new MySqlParameter("@ID",user.ID),
                new MySqlParameter("@Password",user.Password),
                new MySqlParameter("@Name",user.Name),
                new MySqlParameter("@Sex",user.Sex),
                new MySqlParameter("@Title",user.Title)
                );
        }

        public static int Update(User user)
        {
            return MySqlHelper.MySqlConnect.ExecuteNonQuery("UPDATE user SET Password=@Password,Name=@Name,Sex=@Sex,Title=@Title WHERE ID=@ID",
                new MySqlParameter("@ID", user.ID),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@Name", user.Name),
                new MySqlParameter("@Sex", user.Sex),
                new MySqlParameter("@Title", user.Title)
                );
        }

        public static int Delete(string ID)
        {
            return MySqlHelper.MySqlConnect.ExecuteNonQuery("DELETE FROM user WHERE ID=@ID",
                new MySqlParameter("@ID", ID)
            );
        }
    }
}
