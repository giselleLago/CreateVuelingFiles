

namespace CreateVuelingFiles
{
    public class DelegateFileEvent
    {
        public delegate void BoilerLogHandler(string status);
        public event BoilerLogHandler BoilerEventLog;
        public void LogProcess()
        {
            string remarks = "Hello World";
            File b = new File(remarks);
            b.getMessage();
            OnBoilerEventLog(remarks);
        }

        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }
}
