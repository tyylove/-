using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Management
{
    public static class ToModel
    {
        public static TModel DataRowToModel<TModel>(this DataRow dr)
        {
            Type type = typeof(TModel);
            TModel md = (TModel)Activator.CreateInstance(type);
            foreach(var prop in type.GetProperties())
            {
                prop.SetValue(md, dr[prop.Name]);
            }
            return md;
        }
    }
}
