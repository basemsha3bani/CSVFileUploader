using Domain.ViewModel;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Validations
{

    public class SearchFileViewModelValidator : AbstractValidator<SearchFileViewModel>
    {
        private string Keyvalue = string.Empty;

        
       
        public SearchFileViewModelValidator()
        {
            

            RuleFor(model => model.fileName).NotEmpty().NotNull().WithMessage("FileNameRequired").Must(val => Regex.IsMatch(val, "[{1,}[.csv]|[{1,}.CSV]")).WithMessage("Invalid file name or type");
            RuleFor(model => model.SearchText).NotEmpty().NotNull().WithMessage("SearchTextRequired");
        }

    }

}

