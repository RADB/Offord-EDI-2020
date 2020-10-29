using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace EDI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IWebHostEnvironment hostingEnv;
        private string imageFile;
        private double x;
        public ImageController(IWebHostEnvironment env)
        {
            this.hostingEnv = env;
        }

        // POST api/<DapperController>
        [HttpPost]
        public void Post(IList<IFormFile> UploadFiles)
        {
            try
            {
                foreach (IFormFile file in UploadFiles)
                {
                    if (UploadFiles != null)
                    {
                        // Create folder if not available
                        var folder = hostingEnv.ContentRootPath + "\\wwwroot\\UploadImages";
                        if (!Directory.Exists(folder))
                        {
                            Directory.CreateDirectory(folder);
                        }

                        string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        imageFile = filename;

                        string path = folder + $@"\{filename}";

                        // Rename if already file exist in same path (/wwwroot/UploadImages/).
                        while (System.IO.File.Exists(path))
                        {
                            imageFile = "rteImage" + x + "-" + filename;
                            path = hostingEnv.ContentRootPath + "\\wwwroot\\UploadImages" + $@"\rteImage{x}-{filename}";
                            x++;
                        }
                        if (!System.IO.File.Exists(path))
                        {
                            using (FileStream fs = System.IO.File.Create(path))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                                fs.Close();
                            }
                            //Response.Clear();
                            Response.Headers.Add("name", imageFile);
                        }
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                Response.Clear();
                Response.StatusCode = 204;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "No Content";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
    }
}
