using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    public class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The TV is Off.");
        }

        public void On()
        {
            Console.WriteLine("The TV is On.");
        }

        public void VolumeDown()
        {
            if (this.Volume != 0)
            {
                this.Volume--;
            }
            Console.WriteLine($"The TV Volume is {this.Volume}");
        }

        public void VolumeUp()
        {
            this.Volume++;
            Console.WriteLine($"The TV Volume is {this.Volume}");
        }
    }
}
