namespace CSharpAdvanced
{
    public class DownloadEventArgs : EventArgs
    {
        public int Percentage { get; }
        public DownloadEventArgs(int percentage)
        {
            Percentage = percentage;
        }
    }
}