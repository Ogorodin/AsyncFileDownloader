
using FileDownloader.Services;
using Microsoft.AspNetCore.Mvc;

namespace FileDownloader.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileDownloaderController : Controller
    {

        private IFileDownloaderService _service;

        public FileDownloaderController(IFileDownloaderService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("dwnld")]
        public bool DownloadeFile(string url)
        {
            return _service.DownloadFile(url);
        }

    }
}
