using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace video_RentalAssign26
{
   public class Connection
    {
        //object of the Sql Class
        SqlConnection sqlcntn;

        //object of the SQL Command 
        SqlCommand sqlcmd;

        //object of the SQL Data Adapter
        SqlDataReader sqlDataReader;


        //connection string 
        String location = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=RentalStore;Integrated Security=True";



        //use the permision to insert delete or update 

        public void Sql_Permission(String query)
        {
            sqlcntn = new SqlConnection(location);
            sqlcntn.Open();
            sqlcmd = new SqlCommand(query, sqlcntn);
            sqlcmd.ExecuteNonQuery();
            sqlcntn.Close();
        }


        //permission to read the data from the daabase 
        public DataTable Sql_searchPermission(String qry)
        {
            DataTable tbl = new DataTable();

            sqlcntn = new SqlConnection(location);

            sqlcntn.Open();

            sqlcmd = new SqlCommand(qry, sqlcntn);

            sqlDataReader = sqlcmd.ExecuteReader();

            tbl.Load(sqlDataReader);

            sqlcntn.Close();

            return tbl;
        }


    }
}
