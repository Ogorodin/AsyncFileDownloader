using FileDownloader.Worker;
namespace FileDownloader.Services
{
    public class FileDownloaderService : IFileDownloaderService
    {
        IFileDownloader _worker;

        public FileDownloaderService(IFileDownloader worker)
        {
            _worker = worker;
        }
        public bool DownloadFile(string url)
        {
            return _worker.DownloadFile(url);
        }
    }
}
