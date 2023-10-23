using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Validations;

namespace Services
{
    public class SearchFileViewModelService
    {
       
        private readonly SearchFileViewModelValidator _validations ;

        public SearchFileViewModelService(SearchFileViewModelValidator validations)
        {

            _validations = validations;
        }
        public List<string> SearchFile(SearchFileViewModel searchFileViewModel )
        {
           
            var validationResult = _validations.Validate(searchFileViewModel);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors[0].ToString());
            }
            string fileName = searchFileViewModel.fileName;
            string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "TestFiles", searchFileViewModel.fileName);
            List<string> fileLines = File.ReadAllLines(TargetPath).ToList();
            string searchText = searchFileViewModel.SearchText.ToLower();
            List<string> result=(from line in fileLines
                                 where line.ToLower().Contains(searchText)
                                 select line).ToList();
           return result;

        }
          
    
      
          

   
    }
}
