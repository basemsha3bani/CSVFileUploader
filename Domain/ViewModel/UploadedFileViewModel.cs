using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModel
{
    public class UploadedFileViewModel
    {
        [Required]
        [RegularExpression(".{1,}.csv")]
       public string FileName { get; set; }
    }
}
