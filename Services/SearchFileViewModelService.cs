using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
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
        public List<string> SearchFile(string fileName,string searchText )
        {
            SearchFileViewModel searchFileViewModel = new SearchFileViewModel { fileName = fileName, SearchText = searchText };
            var validationResult = _validations.Validate(searchFileViewModel);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors[0].ToString());
            }
            string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "TestFiles",fileName);
            using (StreamReader sr = File.OpenText(fileName))
            {
                searchFileViewModel.SearchResult = new System.Collections.Generic.List<string>();

                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.ToLower().Contains(searchText.ToLower()))
                        {
                        searchFileViewModel.SearchResult.Add(s);
                        }
                 }
                    
                }
            return searchFileViewModel.SearchResult;
        }
    
      
          

   
    }
}
