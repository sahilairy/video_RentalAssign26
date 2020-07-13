using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_RentalAssign26
{
    public partial class Form2 : Form
    {
        RentalOperation conn = new RentalOperation();
        int RentalID=0;
        int selection = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void cus_add_Click(object sender, EventArgs e)
        {
            if (!name_cus.Text.ToString().Equals("") && !email_cus.Text.ToString().Equals("") && !ph_cus.Text.ToString().Equals("") && !addres_cus.Text.ToString().Equals("")) {
                conn.Sql_Permission("insert into Member values('"+name_cus.Text+"','"+email_cus.Text+"','"+ph_cus.Text+"','"+addres_cus.Text+"')");
                MessageBox.Show("Member is Registered ");
            }
            else {
                MessageBox.Show("FIll all the values to register the member ");
            }
            name_cus.Text = "";
            addres_cus.Text = "";
            ph_cus.Text = "";
            email_cus.Text = "";

        }

        private void email_cus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cus_delete_Click(object sender, EventArgs e)
        {
            if (!Rent_cusID.Text.ToString().Equals(""))
            {
                DataTable tbl = new DataTable();
                //check weather the customer already get the movie on rent or not 
                tbl = conn.Sql_searchPermission("select * from Rental where MemberID="+Convert.ToInt32(Rent_cusID.Text.ToString())+" and ReturnDate='Book'");
                if (tbl.Rows.Count > 0)
                {
                    //means the Member has a video on rent 
                    MessageBox.Show("First return the Movie ");
                }
                else {
                    //means member has not book any movie on rent 
                    conn.Sql_Permission("delete from Member where CustID="+Convert.ToInt32(Rent_cusID.Text.ToString()) +"");
                }
            }
            else {
                MessageBox.Show("Select the Member to Delete ");
            }

            Rent_cusID.Text = "";
            name_cus.Text = "";
            addres_cus.Text = "";
            ph_cus.Text = "";
            email_cus.Text = "";

        }

        private void Cus_update_Click(object sender, EventArgs e)
        {

            if (!Rent_cusID.Text.ToString().Equals("") && !name_cus.Text.ToString().Equals("") && !email_cus.Text.ToString().Equals("") && !ph_cus.Text.ToString().Equals("") && !addres_cus.Text.ToString().Equals(""))
            {
                conn.Sql_Permission("update Member set Name='" + name_cus.Text + "',Email='" + email_cus.Text + "',Phone='" + ph_cus.Text + "',Address='" + addres_cus.Text + "' where  CustID=" + Convert.ToInt32(Rent_cusID.Text.ToString()) + "");
                MessageBox.Show("Member Record is Updated  ");
            }
            else
            {
                MessageBox.Show("Fill and Select the Member to Update the Record  ");
            }

            name_cus.Text = "";
            addres_cus.Text = "";
            ph_cus.Text = "";
            email_cus.Text = "";
            Rent_cusID.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!Mov_title.Text.ToString().Equals("") && !mov_rate.Text.ToString().Equals("") && !mov_year.Text.ToString().Equals("") && !mov_cost.Text.ToString().Equals("") && !mov_copies.Text.ToString().Equals("") && !mov_plot.Text.ToString().Equals("") && !mov_genre.Text.ToString().Equals(""))
            {

                //code to the Enter the Details of the Movie 
                conn.Sql_Permission("insert into Movie values ('" + Mov_title.Text + "','" + mov_rate.Text + "','" + mov_year.Text + "','" + mov_cost.Text + "','" + mov_copies.Text + "','" + mov_plot.Text + "','" + mov_genre.Text + "')");
                MessageBox.Show("Movie Record is saved in the Table ");


            }
            else {
                MessageBox.Show("Fill all the Record to add the Details ");
            }

            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_year.Text = "";


        }

        private void mov_year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;
                int cost = 0;

                int diffYear = Currentyear - Convert.ToInt32(mov_year.Text);
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                else if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                mov_cost.Text = "" + cost;

            }
            catch (Exception ex) {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!mov_RenID.Text.ToString().Equals("")) {

                DataTable tbl = new DataTable();
                //check weather the customer already get the movie on rent or not 
                tbl = conn.Sql_searchPermission("select * from Rental where MovieID=" + Convert.ToInt32(mov_RenID.Text.ToString()) + " and ReturnDate='Book'");
                if (tbl.Rows.Count > 0)
                {
                    //means the Member has a video on rent 
                    MessageBox.Show("this movie is already booked ");
                }
                else
                {
                    //means member has not book any movie on rent 
                    conn.Sql_Permission("delete from Movie where MovieID=" + Convert.ToInt32(mov_RenID.Text.ToString()) + "");
                }
            }
            else {
                MessageBox.Show("Select the Movie to  delete ");
            }

            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_year.Text = "";

            mov_RenID.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!mov_RenID.Text.ToString().Equals("") && !Mov_title.Text.ToString().Equals("") && !mov_rate.Text.ToString().Equals("") && !mov_year.Text.ToString().Equals("") && !mov_cost.Text.ToString().Equals("") && !mov_copies.Text.ToString().Equals("") && !mov_plot.Text.ToString().Equals("") && !mov_genre.Text.ToString().Equals(""))
            {

                //code to the Enter the Details of the Movie 
                conn.Sql_Permission("update Movie set Title='" + Mov_title.Text + "',Ratting='" + mov_rate.Text + "',Year='" + mov_year.Text + "',Cost='" + mov_cost.Text + "',Copies='" + mov_copies.Text + "',Plot='" + mov_plot.Text + "',Genre='" + mov_genre.Text + "' where MovieID=" + Convert.ToInt32(mov_RenID.Text.ToString()) + " ");
                MessageBox.Show("Movie Record is Updated in the Table ");


            }
            else
            {
                MessageBox.Show("Fill all the Record to add the Details ");
            }

            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_year.Text = "";

            mov_RenID.Text = "";
        }

        private void delete_rental_Click(object sender, EventArgs e)
        {
            //selet rental video details to delete 
            if (RentalID == 0)
            {
                MessageBox.Show("Select the Rental VIdeo to Deleete ");
            }
            else {
                conn.delRental(RentalID);
                mov_copies.Text = "";
                mov_cost.Text = "";
                mov_genre.Text = "";
                mov_plot.Text = "";
                mov_rate.Text = "";
                Mov_title.Text = "";
                mov_year.Text = "";

                mov_RenID.Text = "";

                name_cus.Text = "";
                addres_cus.Text = "";
                ph_cus.Text = "";
                email_cus.Text = "";
                Rent_cusID.Text = "";

            }
            RentalID = 0;
        }

        private void Rental_issue_Click(object sender, EventArgs e)
        {
            if (!mov_RenID.Text.ToString().Equals("") && !Rent_cusID.Text.ToString().Equals(""))
            {
                //
                if (conn.countBookedCopies(Convert.ToInt32(mov_RenID.Text.ToString())) < conn.getCopies(Convert.ToInt32(mov_RenID.Text.ToString())))
                {
                    if (conn.countBooking(Convert.ToInt32(Rent_cusID.Text.ToString())) < 2)
                    {
                        conn.Sql_Permission("insert into Rental values(" + Rent_cusID.Text + "," + mov_RenID.Text + ",'" + dtpIssue.Text + "','Book')");
                    }
                    else
                    {
                        MessageBox.Show("You already have 2 Movie on rent ");
                    }
                }
                else
                {
                    MessageBox.Show("All Samples are already booked ");
                }
            }
            else {
                MessageBox.Show("Select the Movie and Member To book ");
            }

            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_year.Text = "";

            mov_RenID.Text = "";

            name_cus.Text = "";
            addres_cus.Text = "";
            ph_cus.Text = "";
            email_cus.Text = "";
            Rent_cusID.Text = "";


        }

        private void return_rental_Click(object sender, EventArgs e)
        {
            if (RentalID > 0)
            {
                int Charges = conn.CalculateCost(dtpIssue.Text, dtpReturn.Text,Convert.ToInt32(mov_RenID.Text.ToString()));
                conn.Sql_Permission("update Rental set ReturnDate='"+dtpReturn.Text+"' where Rental_ID="+RentalID+"");
                MessageBox.Show("Thanks for visiting your charge is " + Charges);
            }
            else {
                MessageBox.Show("Select the Movie to Return ");
            }

            RentalID = 0;
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_year.Text = "";

            mov_RenID.Text = "";

            name_cus.Text = "";
            addres_cus.Text = "";
            ph_cus.Text = "";
            email_cus.Text = "";
            Rent_cusID.Text = "";


        }

        private void video_data_Click(object sender, EventArgs e)
        {
            //for video data flag one is used for selection 
            selection = 1;
            //get the Data from Movie table 
            DataTable tblVideo = new DataTable();
            tblVideo = conn.Sql_searchPermission("select * from Movie");
            Database.DataSource = tblVideo;
        }

        private void cus_data_Click(object sender, EventArgs e)
        {
            //for Customer data flag one is used for selection 
            selection = 2;
            //get the Data from Member table 
            DataTable tblVideo = new DataTable();
            tblVideo = conn.Sql_searchPermission("select * from Member");
            Database.DataSource = tblVideo;

        }

        private void rental_data_Click(object sender, EventArgs e)
        {
            //for Customer data flag one is used for selection 
            selection = 3;
            //get the Data from Rental table 
            DataTable tblVideo = new DataTable();
            tblVideo = conn.Sql_searchPermission("select * from Rental");
            Database.DataSource = tblVideo;
        }

        private void Database_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Database_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (selection)
            {
                case 1:
                    //for view the Vide Data 
                    mov_RenID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                    Mov_title.Text = Database.CurrentRow.Cells[1].Value.ToString();
                    mov_rate.Text = Database.CurrentRow.Cells[2].Value.ToString();
                    mov_year.Text = Database.CurrentRow.Cells[3].Value.ToString();
                    mov_cost.Text = Database.CurrentRow.Cells[4].Value.ToString();
                    mov_copies.Text = Database.CurrentRow.Cells[5].Value.ToString();
                    mov_plot.Text = Database.CurrentRow.Cells[6].Value.ToString();
                    mov_genre.Text = Database.CurrentRow.Cells[7].Value.ToString();
                    break;
                case 2:
                    //for view the Customer  Data 
                    Rent_cusID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                    name_cus.Text = Database.CurrentRow.Cells[1].Value.ToString();
                    email_cus.Text = Database.CurrentRow.Cells[2].Value.ToString();
                    ph_cus.Text = Database.CurrentRow.Cells[3].Value.ToString();
                    addres_cus.Text = Database.CurrentRow.Cells[4].Value.ToString();

                    break;
                case 3:

                    RentalID = Convert.ToInt32(Database.CurrentRow.Cells[0].Value.ToString());
                    Rent_cusID.Text = Database.CurrentRow.Cells[1].Value.ToString();
                    mov_RenID.Text = Database.CurrentRow.Cells[2].Value.ToString();
                    dtpIssue.Text = Database.CurrentRow.Cells[3].Value.ToString();

                    break;
            }
            selection = 0;
        }

        private void best_cus_Click(object sender, EventArgs e)
        {
            //get the Name of the Best Customer of the Store 

            DataTable tblData = new DataTable();
            tblData = conn.Sql_searchPermission("select * from Member");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tbl = new DataTable();
                tbl = conn.Sql_searchPermission("select * from Rental where MemberID=" + Convert.ToInt32(tblData.Rows[x]["CustID"].ToString()) + "");

                if (tbl.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Name"].ToString();
                    cunt = tbl.Rows.Count;
                }
            }
            MessageBox.Show("Best Cusotmer of the Store  is " + Name);

        }

        private void best_video_Click(object sender, EventArgs e)
        {
            //get the Name of the Best Movie  of the Store 

            DataTable tblData = new DataTable();
            tblData = conn.Sql_searchPermission("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tbl = new DataTable();
                tbl = conn.Sql_searchPermission("select * from Rental where MovieID=" + Convert.ToInt32(tblData.Rows[x]["MovieID"].ToString()) + "");

                if (tbl.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Title"].ToString();
                    cunt = tbl.Rows.Count;
                }

            }
            MessageBox.Show("Best Movie of the Store  is " + Name);
        }
    }
}
