using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrintThat
{
    public static class PrintLogger
    {
        static string _pathToLogFile = string.Empty;
        static string _pathToLogDirectory = string.Empty;

        public static void Init()
        {
            _pathToLogDirectory = AppDomain.CurrentDomain.BaseDirectory + "PrintLog\\";
            DateTime _now = DateTime.Now;

            _pathToLogFile = string.Format("{0}{1}.{2} {3}", _pathToLogDirectory, _now.Day, _now.Year, "log.txt");

            if (!Directory.Exists(_pathToLogDirectory)) { Directory.CreateDirectory(_pathToLogDirectory); }
            if (!File.Exists(_pathToLogFile)) { File.Create(_pathToLogFile); }
        }

        public static void Put(this string FileName, int Count)
        {
            new System.Threading.Thread(() =>
            {
                using (StreamWriter outputFile = new StreamWriter(_pathToLogFile, true, Encoding.Default))
                {
                    DateTime now = DateTime.Now;
                    string data = string.Format("{0}.{1}.{2} {3}:{4}:{5}\t>>\t{6}шт. {7}\n",
                        now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second, Count, FileName);
                    outputFile.WriteLine(data);
                }
            }).Start();
        }
    }

}
