

namespace CreateVuelingFiles
{
    public class DelegateFileEvent
    {
        public delegate void FileLogHandler(string status);
        public event FileLogHandler FileEventLog;
        public void LogProcess()
        {
            string remarks = "Hello World";
            File b = new File(remarks);
            b.getMessage();
            OnFileEventLog(remarks);
        }

        protected void OnFileEventLog(string message)
        {
            FileEventLog?.Invoke(message);
        }
    }
}
