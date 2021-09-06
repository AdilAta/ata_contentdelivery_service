using ContentDeliveryService.Configs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentDeliveryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private DownloadSettings downloadSettings;
        public DownloadController(IOptions<DownloadSettings> downloadSettings)
        {
            this.downloadSettings = downloadSettings.Value;
        }

        [HttpGet("home")]
        public string Home()
        {
           return "download home page - test deployment slot";
        }

        [HttpGet("repository")]
        public FileContentResult DownloadRepostiry()
        {
            //    return File(System.IO.File.ReadAllBytes(Path.Combine(this.downloadSettings.RootPath, "Chapter 1.mp4")), "video/mp4", "MyFirstVideoFile.mp4");
            return File(System.IO.File.ReadAllBytes(@"./resources/Repository.mp4"), "video/mp4", "Repository.mp4");

        }

        [HttpGet("unitofwork")]
        public FileContentResult DownloadUnitOfWork()
        {
            //    return File(System.IO.File.ReadAllBytes(Path.Combine(this.downloadSettings.RootPath, "Chapter 1.mp4")), "video/mp4", "MyFirstVideoFile.mp4");
            return File(System.IO.File.ReadAllBytes(@"./resources/UnitOfWork.mp4"), "video/mp4", "UnitOfWork.mp4");

        }


    }
}
