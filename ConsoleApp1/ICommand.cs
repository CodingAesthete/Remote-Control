using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
