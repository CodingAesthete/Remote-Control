using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VolumeButton : ICommand
    {
        IElectronicDevice device;
        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
