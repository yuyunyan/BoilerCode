﻿using JYResume.Data.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYResume.Data
{
    public sealed class DataProvider
    {
        private DataProvider() { }

        public static IDao Instance
        {
            get
            {
                return SqlDao.Instance;
            }
        }

    }
}
