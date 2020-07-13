using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_RentalAssign26
{
   public class RentalOperation: Connection
    {

        public int delRental(int ID) {
            //delete the Rental details 
            Sql_Permission("delete from Rental where Rental_ID=" + ID + "");
            return 1;

        }

        //count the Boking done by the member 
        public int countBooking(int CustID) {
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Rental where MemberID="+CustID+" and ReturnDate='Book'");
            return tbl.Rows.Count;
        }

        //count the Boking done by the member 
        public int countBookedCopies(int MovieID)
        {
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Rental where MovieID=" + MovieID + " and ReturnDate='Book'");
            return tbl.Rows.Count;
        }

        //count the Boking done by the member 
        public int getCopies(int MovieID)
        {
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Movie where MovieID=" + MovieID + "");
            return Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());
        }


        //count the Boking done by the member 
        public int getCost(int MovieID)
        {
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Movie where MovieID=" + MovieID + "");
            return Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());
        }

        public int CalculateCost(String BookDate,String ReturnDate,int MoviID) {

            //get the difference between 
            //get the difference in days between 2 dates and get  the cost from the database 
            DateTime start = Convert.ToDateTime(BookDate);

            DateTime endDate = Convert.ToDateTime(ReturnDate);

            String diff2 = (endDate - start).TotalDays.ToString();
            //convert the string value to double 
            double d = Convert.ToDouble(diff2);
            //pass the roud off value to calculate 
            double days = Math.Round(d);

            //get the cost of the video 
            DataTable tbl = new DataTable();
            if (d == 0)
            {
                days = 1;
            }

            int cost = getCost(Convert.ToInt32(MoviID));

            int payment = Convert.ToInt32(days) * cost;

            return payment;
        }


    }
}
