using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class List1
    {
       private List<InsertObject_class> myList = new List<InsertObject_class>();

        public List<InsertObject_class> MyList
        {
            get
            {
                return myList;
            }

            set
            {
                myList = value;
            }
        }
    }
}