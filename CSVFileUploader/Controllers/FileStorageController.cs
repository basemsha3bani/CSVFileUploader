using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Validations;

namespace CSVFileUploader.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileStorageController : ControllerBase
    {
        SearchFileViewModelService _searchFileViewModelService;
        FileViewModelService _fileViewModelService;

        public FileStorageController(SearchFileViewModelService searchFileViewModelService, FileViewModelService fileViewModelService)
        {
            _fileViewModelService = fileViewModelService;
            _searchFileViewModelService = searchFileViewModelService;
        }
        // GET: api/FileStorage
       
     

        // POST: api/FileStorage
        [HttpPost]
        public IActionResult Post(IFormFile fileUpload)
        {

            


            try
            {



                _fileViewModelService.SaveFile(fileUpload);


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("SearchFile")]
        public IActionResult SearchFile(SearchFileViewModel searchFileViewModel)
        {




            try
            {



                List<string> SearchResult = _searchFileViewModelService.SearchFile(searchFileViewModel);


                return Ok(new { result = SearchResult });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




     
    }
}
