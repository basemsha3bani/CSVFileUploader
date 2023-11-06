using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModel
{
    public class MenuItemViewModel
    {


        public string Action { get; set; }

        public string Controller { get; set; }

        public string LinkText { get; set; }

        public UserType userType { get; set; }
    }

}
