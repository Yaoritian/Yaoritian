using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ConnHelper
    {
        public  DataTable Conn(string sql)
        // 可以在data前面加static  如果不加的话 那么在bll层就要加new 
        {
           string conctr = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
            SqlConnection connection = new SqlConnection(conctr);
            return new DataTable();
        }
    }
}
