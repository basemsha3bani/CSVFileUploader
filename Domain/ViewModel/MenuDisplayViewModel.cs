using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
   public class MenuDisplayViewModel
    {
      public  UserType userType { get; set; }
        public List<MenuItemViewModel> menuItems { get; set; } = new List<MenuItemViewModel>();
    }
}
