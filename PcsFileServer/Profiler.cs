using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    public static class Profiler
    {
        public static double MeasureAction(Action action)
        {
            var st = new Stopwatch();

            st.Start();

            action();

            st.Stop();

            return st.Elapsed.TotalMilliseconds;
        }
    }
}
