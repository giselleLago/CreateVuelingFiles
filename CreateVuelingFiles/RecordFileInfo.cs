using System;

namespace CreateVuelingFiles
{
    static class RecordFileInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            FileInfoLogger filelogtxt = new FileInfoLogger("vueling.txt");
            FileInfoLogger filelogjson = new FileInfoLogger("vueling.json");
            FileInfoLogger filelogxml = new FileInfoLogger("vueling.xml");
            DelegateFileEvent fileEvent = new DelegateFileEvent();
            fileEvent.FileEventLog += new DelegateFileEvent.FileLogHandler(Logger);
            fileEvent.FileEventLog += new DelegateFileEvent.FileLogHandler(filelogtxt.Logger);
            fileEvent.FileEventLog += new DelegateFileEvent.FileLogHandler(filelogjson.Logger);
            fileEvent.FileEventLog += new DelegateFileEvent.FileLogHandler(filelogxml.Logger);
            fileEvent.LogProcess();
            Console.ReadLine();
            filelogtxt.Close();
            filelogjson.Close();
            filelogxml.Close();
        }
    }
}
