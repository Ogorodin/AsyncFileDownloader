namespace FileDownloader.Worker
{
    public interface IFileDownloader
    {
        public bool DownloadFile(string url);
    }
}
