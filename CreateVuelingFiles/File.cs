namespace CreateVuelingFiles
{
    public class File
    {
        private readonly string message;

        public File(string m)
        {
            message = m;
        }

        public string getMessage()
        {
            return message;
        }
    }
}
