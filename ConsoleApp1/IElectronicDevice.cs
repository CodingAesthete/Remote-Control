using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}
