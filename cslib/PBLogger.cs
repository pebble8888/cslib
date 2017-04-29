using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace cslib
{
    class PBLogger
    {
        public static void Print(string s)
        {
            StackTrace st = new StackTrace(1, true);
            string dateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            var t = dateTime + " " + s;
            Debug.Print(t);
        }
    }
}
