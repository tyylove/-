using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlHelper;

namespace Management
{
    public class UserBases
    {
        public string ID { get; set; }
        public string? UserName { get; set; }
        public string? Sex { get; set; }
        public string Title { get; set; }

        public static List<UserBases> ListAll()
        {
            List<UserBases> userBases = new List<UserBases>();
            DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT ID,Name,Sex,Title FROM user ORDER BY Title");
            foreach(DataRow dr in dt.Rows)
            {
                userBases.Add(ToModel(dr));
            }
            return userBases;
        }

        public static List<UserBases> ListAllByTitle()
        {
            List<UserBases> userBases = new List<UserBases>();
            DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT * FROM user GROUP BY Title ORDER BY Title");
            //DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT ID,Name,Sex,Constrast FROM user, titlecontrast where user.Title = titlecontrast.Title ORDER BY user.Title");
            foreach (DataRow dr in dt.Rows)
            {
                userBases.Add(ToModel(dr));
            }
            return userBases;
        }

        private static UserBases ToModel(DataRow dr)
        {
            UserBases userBases = new UserBases();
            userBases.ID = dr["ID"].ToString();
            userBases.UserName = dr["Name"].ToString();
            userBases.Sex = dr["Sex"].ToString();
            userBases.Title = dr["Title"].ToString();
            return userBases;

        }
    }
}
