using System;
using System.Globalization;
using System.Text;

namespace RemoteControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = Remote.GetTV();
            PowerButton powBut = new PowerButton(TV);
            VolumeButton volBut = new VolumeButton(TV);
            powBut.Execute();
            if (powBut.IsOn())
            {
                volBut.Execute();
                volBut.Undo();
            }
            powBut.Undo();
        }
    }
}
