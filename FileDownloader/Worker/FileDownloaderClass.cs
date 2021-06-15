using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace FileDownloader.Worker
{
    public class FileDownloaderClass : IFileDownloader
    {
        public bool DownloadFile(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                string fileName = GetFileNameFromUrl(url);
                string path = Path.Combine(Environment.CurrentDirectory, @"Downloads\", fileName);
                webClient.DownloadFile(new Uri(url), path);
            }
            return true;
        }

        public string GetFileNameFromUrl(string url)
        {
            string[] parts = url.Split("/");
            if (parts.Length > 0)
            {
                string fileName = parts[parts.Length - 1];
                return fileName;
            }
            return url;
        }
    }
}
