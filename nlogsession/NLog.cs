using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace nlogsession
{
    class NLogC
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }
        public void LogError(string input)
        {
            logger.Error(input);
        }
        public void LogWarn(string input)
        {
            logger.Warn(input);
        }
    }
}
