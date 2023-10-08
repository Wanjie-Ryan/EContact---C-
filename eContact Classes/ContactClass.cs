using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.eContact_Classes
{
    internal class ContactClass
    {
        //getter and setter properties
        // they will act as data carriers in the App

        //to create a getter and setter, type prop

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        //creating a static method to connect to the db

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecting data from db

        public DataTable Select()
        {
            // 1. Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                // 2. Writing SQL Query
                string sql = "SELECT * FROM tbl_contact";

                // Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);




            }
            catch (Exception ex)
            {

            }
            finally
            {

                conn.Close();

            }
            return dt;
        }

        //inserting data into db



    }
}
