using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Neo.ZZZ
{
    class TestUtil
    {
        /// <summary>
        /// 启动控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        /// 释放控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        static bool showflag=false;
      
        public static void log(Object o)
        {
            if (showflag == false)
            {
                showflag = AllocConsole();
            }

            Console.WriteLine(o.ToString());
        }


    }
}
