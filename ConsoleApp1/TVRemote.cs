using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TVRemote
    {
        public static IElectronicDevice GetTV()
        {
            return new Television();
        }
        public static IElectronicDevice GetDVD()
        {
            return new DVD();
        }
    }
}
