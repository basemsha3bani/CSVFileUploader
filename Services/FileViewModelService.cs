using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Validations;

namespace Services
{
    public class FileViewModelService
    {
       
        private readonly FileViewModelValidator _FileViewModelValidator;

        public FileViewModelService(FileViewModelValidator FileViewModelValidator)
        {
            
            _FileViewModelValidator = FileViewModelValidator;
        }
        public void SaveFile(IFormFile file)
        {
            
            var validationResult = _FileViewModelValidator.Validate(new UploadedFileViewModel { FileName = file.FileName });
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors[0].ToString());
            }

            if (file != null)
            {
              string  TargetPath = Path.Combine(
              Directory.GetCurrentDirectory(), "TestFiles");
                if (!Directory.Exists(TargetPath))
                {
                    Directory.CreateDirectory(TargetPath);



                }

                using (var stream = new FileStream(Path.Combine(TargetPath, file.FileName), FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            };
        }

   
    }
}
