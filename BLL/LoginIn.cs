using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    public class LoginIn
    {
        public static void isAccount(string sql)
        {
            //ConnHelper.Conn(sql);static
            ConnHelper conn = new ConnHelper();
        }
    }
}
