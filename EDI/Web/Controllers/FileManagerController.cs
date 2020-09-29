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

namespace EDI.Web.Controllers
{
    [Route("api/[controller]")]
    public class FileManagerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        public PhysicalFileProvider operation;
        public string basePath;

        [Obsolete]
        public FileManagerController(IHostingEnvironment hostingEnvironment, 
            IHttpContextAccessor httpContextAccessor,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            UserManager<ApplicationUser> userManager)
        {
            this.basePath = hostingEnvironment.ContentRootPath;
            this.operation = new PhysicalFileProvider();

            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
            _identityContext = identityContext;

            var username = _httpContextAccessor.HttpContext.User.Identity.Name;

            var user = _identityContext.Users.Where(p => p.UserName == username).FirstOrDefault();

            var roleid = _identityContext.UserRoles.Where(p => p.UserId == user.Id).First().RoleId;

            var role = _identityContext.Roles.Where(p => p.Id == roleid).FirstOrDefault();

            var rolename = role.Name;

            string newPath = string.Empty;

            if (rolename == "Administrator" || rolename == "Coordinator")
            {
                string folderName = @"Data\Files\";
                newPath = Path.Combine(this.basePath, folderName);                
            }
            else if (rolename == "Teacher")
            {
                if (user.ProvinceID.HasValue)
                {
                    var province = _dbContext.Provinces.Where(p => p.Id == user.ProvinceID).FirstOrDefault();

                    string folderName = @"Data\Files\" + province.English;
                    newPath = Path.Combine(this.basePath, folderName);                    
                }
                else
                {
                    string folderName = @"Data\Files\Unknown";
                    //string webRootPath = this.basePath + @"\wwwroot";
                    newPath = Path.Combine(this.basePath, folderName);
                }
            }

            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            this.operation.RootFolder(newPath);
        }

        // Processing the File Manager operations
        [Route("FileOperations")]
        public object FileOperations([FromBody] FileManagerDirectoryContent args)
        {
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
