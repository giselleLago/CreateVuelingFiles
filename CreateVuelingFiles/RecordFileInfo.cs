using System;

namespace CreateVuelingFiles
{
    static class RecordBoilerInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            FileInfoLogger filelog = new FileInfoLogger("vueling.txt");
            DelegateFileEvent boilerEvent = new DelegateFileEvent();
            boilerEvent.BoilerEventLog += new DelegateFileEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateFileEvent.BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            filelog.Close();
        }
    }
}
