using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class InsertObject_class
    {
        private String input;
        private String texbox;
        private String checkboxList = "";
        private Boolean checkbox;
        private String dropdown;
        private String radioButton;

        public InsertObject_class()
        {

        }

        public InsertObject_class(string input, string texbox, string checkboxList, bool checkbox, string dropdown, string radioButton)
        {
            this.input = input;
            this.texbox = texbox;
            this.checkboxList = checkboxList;
            this.checkbox = checkbox;
            this.dropdown = dropdown;
            this.radioButton = radioButton;
        }

        public string Input
        {
            get
            {
                return input;
            }

            set
            {
                input = value;
            }
        }

        public string Texbox
        {
            get
            {
                return texbox;
            }

            set
            {
                texbox = value;
            }
        }       

        public bool Checkbox
        {
            get
            {
                return checkbox;
            }

            set
            {
                checkbox = value;
            }
        }

        public string Dropdown
        {
            get
            {
                return dropdown;
            }

            set
            {
                dropdown = value;
            }
        }

        public string RadioButton
        {
            get
            {
                return radioButton;
            }

            set
            {
                radioButton = value;
            }
        }

        public string CheckboxList
        {
            get
            {
                return checkboxList;
            }

            set
            {
                checkboxList = value;
            }
        }
    }
}