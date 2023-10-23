using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModel
{
    public class SearchFileViewModel
    {
       
        
       public string fileName { get; set; }


        

        public string SearchText { get; set; }


        public List<string> SearchResult { get; set; }
    }
}
