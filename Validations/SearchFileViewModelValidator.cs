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
            

            RuleFor(model => model.fileName).NotEmpty().NotNull().WithMessage("FileNameRequired");
            RuleFor(model => model.SearchText).NotEmpty().NotNull().WithMessage("SearchTextRequired");
        }

    }

}

