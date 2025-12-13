using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpAdvanced
{
    internal class DownloadManager
    {
        public event EventHandler<DownloadEventArgs> DownloadProgressChanged;
        public event CompleteEventHandler DownloadCompleted;
        public delegate void CompleteEventHandler();

        public void StartDownload()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                if (i % 10 == 0)
                {
                    DownloadProgressChanged?.Invoke(this, new DownloadEventArgs(i));
                }
                if (i == 100)
                {
                    DownloadCompleted?.Invoke();
                }
            }
        }
    }
}