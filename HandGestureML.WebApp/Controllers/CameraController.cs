using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HandGestureML.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandGestureML.WebApp.Controllers
{
    public class CameraController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public CameraController(IWebHostEnvironment env)
        {
            _environment = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Capture()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Capture(string name)
        {
            var files = HttpContext.Request.Form.Files;
            string predictions = "";

            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        // Getting Filename  
                        var fileName = file.FileName;
                        // Unique filename "Guid"  
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        // Getting Extension  
                        var fileExtension = Path.GetExtension(fileName);
                        // Concating filename + fileExtension (unique filename)  
                        var newFileName = string.Concat(myUniqueFileName, fileExtension);
                        //  Generating Path to store photo   
                        var filepath = Path.Combine(_environment.WebRootPath, "CameraPhotos") + $@"\{newFileName}";

                        if (!string.IsNullOrEmpty(filepath))
                        {
                            // Storing Image in Folder  
                            StoreInFolder(file, filepath);
                        }

                        ModelInput sampleData = new ModelInput() { ImageSource = filepath, Label = "" };
                      
                        ModelOutput predictionResult = ConsumeModel.Predict(sampleData);

                        var score = predictionResult.Score.OrderByDescending(x => x).First();
                        
                        var finalScore = score * 100 + "%";
                       
                        var result = $"Predicted Label value {predictionResult.Prediction} - Predicted Label score: {finalScore}]";

                        HttpContext.Session.SetString("Prediction", result);
                       
                    }
                }
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [HttpGet]
        public JsonResult GetPrediction()
        {
            return Json(HttpContext.Session.GetString("Prediction"));
        }

        /// <summary>  
        /// Saving captured image into Folder.  
        /// </summary>  
        /// <param name="file"></param>  
        /// <param name="fileName"></param>  
        private void StoreInFolder(IFormFile file, string fileName)
        {
            using (FileStream fs = System.IO.File.Create(fileName))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
        }
    }
}