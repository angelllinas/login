using System.Data;
using System.Data.SqlClient;

namespace login
{
    internal class Connect
    {
        public static SqlConnection conn()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-QOTQQVN;DATABASE=login01;integrated security=true;");
            cn.Open();
            return cn;

        }
    }
}
