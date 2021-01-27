using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Syncfusion.EJ2.FileManager.Base;
using Syncfusion.EJ2.FileManager.PhysicalFileProvider;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using EDI.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using EDI.Web.Extensions;
using EDI.Infrastructure.Data;
using EDI.Web.Lib;
using Blazored.SessionStorage;

namespace EDI.Web.Controllers
{
    [Route("api/[controller]")]
    public class FileManagerController : Controller
    {
        public PhysicalFileProvider operation;
        public string basePath;

        [Obsolete]
        public FileManagerController(IWebHostEnvironment hostingEnvironment)
        {
            this.basePath = hostingEnvironment.WebRootPath;
            this.operation = new PhysicalFileProvider();

            this.operation.RootFolder(this.basePath);
        }

        // Processing the File Manager operations
        [Route("FileOperations")]
        public object FileOperations([FromBody] EDI.Web.Models.FileManagerDirectoryUpdatedContent args)
        {
            //var username = args.CustomData["User_name"].ToString();
            //this.operation.SetRules(GetRules(username));

            switch (args.Action)
            {                
                case "read":
                    return this.operation.ToCamelCase(this.operation.GetFiles(args.Path, args.ShowHiddenItems));
                case "delete":
                    return this.operation.ToCamelCase(this.operation.Delete(args.Path, args.Names));
                case "copy":
                    return this.operation.ToCamelCase(this.operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData));
                case "move":
                    return this.operation.ToCamelCase(this.operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData));
                case "details":
                    return this.operation.ToCamelCase(this.operation.Details(args.Path, args.Names));
                case "create":
                    return this.operation.ToCamelCase(this.operation.Create(args.Path, args.Name));
                case "search":
                    return this.operation.ToCamelCase(this.operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive));
                case "rename":
                    return this.operation.ToCamelCase(this.operation.Rename(args.Path, args.Name, args.NewName));
            }
            return null;
        }

        public AccessDetails GetRules(string user_value)
        {
            AccessDetails accessDetails = new AccessDetails();

            List<AccessRule> accessRules = new List<AccessRule> {   
                // For Default User            
                 new AccessRule { Path = "/*.*", Role = "Adminstrator", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny},
                  new AccessRule { Path = "/*.*", Role = "Adminstrator", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny, IsFile=true},
            };
            accessDetails.AccessRules = accessRules;
            if (user_value == "user1")
            {
                // Here, you need to set the role for FileManager component. 
                accessDetails.Role = "Adminstrator";
            }
            else
            {
                accessDetails.Role = "Document Manager";
            }
            return accessDetails;
        }

        // Processing the Download operation
        [Route("Download")]
        public IActionResult Download(string downloadInput)
        {            
            FileManagerDirectoryContent args = JsonConvert.DeserializeObject<FileManagerDirectoryContent>(downloadInput);
            return operation.Download(args.Path, args.Names);
        }

        // Processing the Upload operation
        [Route("Upload")]
        public IActionResult Upload(string path, IList<IFormFile> uploadFiles, string action)
        {
            FileManagerResponse uploadResponse;
            uploadResponse = operation.Upload(path, uploadFiles, action, null);
            if (uploadResponse.Error != null)
            {
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.StatusCode = Convert.ToInt32(uploadResponse.Error.Code);
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = uploadResponse.Error.Message;
            }
            return Content("");
        }

        // Processing the GetImage operation
        [Route("GetImage")]
        public IActionResult GetImage(FileManagerDirectoryContent args)
        {
            return this.operation.GetImage(args.Path, args.Id, false, null, null);
        }
    }
}
