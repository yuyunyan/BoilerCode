using JYResume.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BoilerCode.Services
{
    public class CategorieService : BaseService
    {
        public static List<Domain.Categories> ListCategories()
        {
            List<Domain.Categories> list = null;

            DataProvider.ExecuteCmd(GetConnection, "dbo.Categories_SelectAll"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {

               }
               , map: (Action<IDataReader, short>)delegate (IDataReader reader, short set)
               {
                   Domain.Categories p = new Domain.Categories();
                   int startingIndex = 0; //startingOrdinal
                   p.CategoryID = reader.GetSafeInt32(startingIndex++);
                   p.CategoryName = reader.GetSafeString(startingIndex++);
                   p.Description = reader.GetSafeString(startingIndex++);


                   if (list == null)
                   {
                       list = new List<Domain.Categories>();
                   }

                   list.Add(p);
               }
               );


            return list;
        }

    }
}