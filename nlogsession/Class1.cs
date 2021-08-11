using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace nlogsession
{
    class addition
    {
       private readonly NLogC nlog = new NLogC();
        public int sum(int a,int b)
        {
            if(a==0||b==0)
            {
                nlog.LogDebug("Debug Successful  : sum()");
                nlog.LogError("Expecting null values ");
                nlog.LogWarn("a or b should not equal to 0");
            }
            int c = a + b;
            nlog.LogDebug("debug Succesful");
            return c;
        }
    }
}
