using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    public partial class WebForm1 : System.Web.UI.Page
    {

        List<InsertObject_class> myList = new List<InsertObject_class>();
        public int InsertStudent(student student)
        {
            string sqlQuery = String.Format("Insert into students (studentid, studentname ,studentgrade) Values('{0}', '{1}', '{2}');"
+ "Select @@Identity", student.studentid, student.studentname, student.studentgrade);

            //Get connection string
            //testEntities name of connection string in WebConfig
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
        
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        String input;
        String texbox;
        String checkboxList = "";
        Boolean checkbox;
        String dropdown;
        String radioButton;

        InsertObject_class objectClass = new InsertObject_class();

            //Input ****************************************************************************************
            objectClass.Input = Text1.Value;
            LabelInput.Text = Text1.Value;
            input = Text1.Value;

            //Textbox***************************************************************************************
            objectClass.Texbox = TextBox1.Text;
            LabelTextbox.Text = TextBox1.Text;
            texbox = TextBox1.Text;

            //Checbox list *********************************************************************************
            // Iterate through the Items collection of the CheckBoxList 
            // control and display the selected items.
            //foreach (ListItem item in CheckBoxList1.Items)  //Other way to do it
            LabelCheckBoxItems.Text = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {               
                if (CheckBoxList1.Items[i].Selected)
                {                    
                    objectClass.CheckboxList = objectClass.CheckboxList  + CheckBoxList1.Items[i].Text + " , "; //add to the object
                    LabelCheckBoxItems.Text += CheckBoxList1.Items[i].Text + "<br />";
                    checkboxList = objectClass.CheckboxList + CheckBoxList1.Items[i].Text + " , ";
                }
            }

            //Checkbox **************************************************************************************
            objectClass.Checkbox = oneCheckBox.Checked;
            LabelCheckBox.Text = oneCheckBox.Checked.ToString();
            checkbox = oneCheckBox.Checked;


            //Dropdown list *********************************************************************************
            objectClass.Dropdown = DropDownList1.SelectedValue; 
            LabelDropDown.Text = DropDownList1.SelectedValue;
            dropdown = DropDownList1.SelectedValue;


            //Radio Buttons *********************************************************************************
            objectClass.RadioButton = RadioButtonList1.SelectedValue;
            LabelRadioButton.Text = RadioButtonList1.SelectedValue;
            radioButton = RadioButtonList1.SelectedValue;


            //Data Binds ************************************************************************************
            //myList.Add(objectClass);
            List1 l = new List1();
            l.MyList.Add(objectClass);


            GridView1.DataSource = l.MyList;
            GridView1.DataBind();

           
     
            InsertObject_class objectClass1 = new InsertObject_class(input, texbox, checkboxList, checkbox, dropdown, radioButton);
           // myList.Add((InsertObject_class)Session["myList"]);
            myList.Add(objectClass1);
            //Session["myList"] = myList;
            
            numerOfElements.Text = myList.Count().ToString();
            GridView2.DataSource = myList;
            GridView2.DataBind();

        }

    }
}