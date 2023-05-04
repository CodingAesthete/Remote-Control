using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    public class DVD : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The DVD is Off.");
        }

        public void On()
        {
            Console.WriteLine("The DVD is On.");
        }

        public void VolumeDown()
        {
            if (this.Volume != 0)
            {
                this.Volume--;
            }
            Console.WriteLine($"The DVD Volume is {this.Volume}");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"The DVD Volume is {this.Volume}");
        }
    }
}
