using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFileName = string.Format(@"C:\dev\dump\GuestExecNetCore\{0}.txt", DateTime.Now.ToLongTimeString().Replace(":", string.Empty));

            while (true)
            {
                try
                {
                    File.AppendAllText(logFileName, DateTime.Now.ToLongTimeString() + "\n");
                    Task.Delay(1000);
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
    }
}