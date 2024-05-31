using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class ProfilContext : dataconn
    {
        public static DataTable all(string query) 
        {
            DataTable dataTable = queryExecutor(query);
            return dataTable;
        }
    }
}
