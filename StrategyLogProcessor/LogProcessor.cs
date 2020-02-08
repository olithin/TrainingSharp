using System;
using System.Collections.Generic;
using System.IO;

namespace StrategyLogProcessor
{
    public class LogProcessor
    {
        private readonly Func<List<LogEntry>> _logImporter;
    }

    public class LogEntry
    {
        public void WriteLog()
        {
            Console.WriteLine("Here is a log");
        }
        
    }
}