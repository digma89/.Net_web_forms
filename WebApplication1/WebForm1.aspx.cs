using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        public int InsertStudent(student student)
        {
            string sqlQuery = String.Format("Insert into students (studentid, studentname ,studentgrade) Values('{0}', '{1}', '{2}');"
+ "Select @@Identity", student.studentid, student.studentname, student.studentgrade);

            //Get connection string
            testEntities entity = new testEntities();            
            SqlConnection connection = new SqlConnection(entity.Database.Connection.ConnectionString);
            
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to SQL Server and return the newly created ID
            //command.ExecuteScalar();

            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            return 1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            student s = new student();
            s.studentgrade = "2";
            s.studentid = 10;
            s.studentname = "DDDDDDDD";

            InsertStudent(s);
            
            try
            {
             student db = new student();
               label1.Text =  db.studentname.ToString();
            }
            catch (Exception E)
            {

            }
        }

 

        protected void GreetingBtn_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.
           
            Button clickedButton = (Button)sender;
            clickedButton.Text = "myname";
            clickedButton.Enabled = false;

            // Display the greeting label text.
            GreetingLabel.Visible = true;
        }
    }
}