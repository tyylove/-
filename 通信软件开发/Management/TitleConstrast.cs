using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Management
{
    public class TitleConstrast
    {
        public string Title { get; set; }
        public string Constrast { get; set; }

        public static List<TitleConstrast> ListAll()
        {
            List<TitleConstrast> titleConstrasts = new List<TitleConstrast>();
            DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT * FROM titlecontrast ORDER BY Title");
            foreach (DataRow dr in dt.Rows)
            {
                titleConstrasts.Add(ToModel(dr));
            }
            return titleConstrasts;
        }

        private static TitleConstrast ToModel(DataRow dr)
        {
            TitleConstrast titleConstrast = new TitleConstrast();
            titleConstrast.Title = dr["Title"].ToString();
            titleConstrast.Constrast = dr["Constrast"].ToString();
            return titleConstrast;

        }
    }
}
