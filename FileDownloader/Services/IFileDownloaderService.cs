namespace FileDownloader.Services
{
  public  interface IFileDownloaderService
    {
        public bool DownloadFile(string url);
    }
}
