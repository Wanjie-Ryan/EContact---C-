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

        public bool Insert(ContactClass c)
        {
            //creating a default value return type and setting its value to false

            bool isSuccess = false;

            //1. connect to db
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //2. create a sql query to insert data
                string sql = "INSERT INTO tbl_contact (FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender) ";

                // Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //open the connection
                conn.Open(); 
                
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully then the value of rows will be greater than 0 else it will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

               

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }



            return isSuccess;
        }

        //method to update data in db from our app

        public bool Update(ContactClass c)
        {
            //creating a default value return type and setting its value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {

                string sql = "UPDATE tbl_contact SET ";

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }



            return isSuccess;


        }





    }
}
