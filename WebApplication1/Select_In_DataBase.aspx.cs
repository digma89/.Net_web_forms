using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Select_In_DataBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable();
        }


        //Create table with query 
        protected void CreateTable()
        {
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                DataTable dt = this.GetData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table border = '1'>");

                //Building the Header row.
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        //Create table with query part 2
        private DataTable GetData()
        {
            testEntities entity = new testEntities();
            string constr = entity.Database.Connection.ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select studentid, studentname ,studentgrade from students"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testEntities entity = new testEntities();
            string connectionString = entity.Database.Connection.ConnectionString;
            string sqlQuery = "Select studentid, studentname ,studentgrade from students";
            System.Diagnostics.Debug.WriteLine("query:" +sqlQuery);
            System.Diagnostics.Debug.WriteLine("query:" + connectionString);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("all good");
                //Create a Command object
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                System.Diagnostics.Debug.WriteLine ("all still good");
                try
                {
                    System.Diagnostics.Debug.WriteLine("all gg");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("\t{0}\t{1}\t{2}",
                        System.Diagnostics.Debug.WriteLine (reader[0].ToString() +" " +reader[1] +" " +reader[2] + "<br />");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
                connection.Close();
                System.Diagnostics.Debug.WriteLine("all ss gg");
            }
            System.Diagnostics.Debug.WriteLine("fin");
        }
    }
}