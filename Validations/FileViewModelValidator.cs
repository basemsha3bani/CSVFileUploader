using Domain.ViewModel;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Validations
{

    public class FileViewModelValidator : AbstractValidator<UploadedFileViewModel>
    {
        private string Keyvalue = string.Empty;
       
        
        public FileViewModelValidator()
        {
            //Keyvalue = keyvalue;
            //RuleFor(model => model.backWood).StringValueMustBeEnum(typeof(Wood));

            RuleFor(model => model.FileName).Must(val => Regex.IsMatch(val, ".{1,}.csv")).WithMessage("Invalid file name or type");
        }
      
    }

}