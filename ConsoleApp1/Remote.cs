using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    class Remote
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
