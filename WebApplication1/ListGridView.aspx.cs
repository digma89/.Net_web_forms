using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ListGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List1 l = new List1();
            

            GridView1.DataSource = l.MyList;
            GridView1.DataBind();

        }
    }
}