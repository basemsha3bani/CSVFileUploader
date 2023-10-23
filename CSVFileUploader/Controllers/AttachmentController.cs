using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace TaskManagementSystem.Controllers
{
   
    public class AttachmentController : Controller
    {
        public AttachmentController()
        {
            
        }
        

        
        
        public IActionResult AddAttachment()
        {
            return View();
        }



        public IActionResult SearchAttachment()
        {
            return View();
        }
        public ActionResult ViewAttachment(int AttachmentId)
        {
           
            
            byte[] fileBytes = System.IO.File.ReadAllBytes("");

            return File(fileBytes, "application/force-download", "");

        }
    }
}