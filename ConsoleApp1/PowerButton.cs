using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PowerButton : ICommand
    {
        bool check = false;
        IElectronicDevice device;
        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
            check = true;
        }

        public void Undo()
        {
            device.Off();
            check = false;
        }
        public bool IsOn()
        {
            return check;
        }
    }
}
