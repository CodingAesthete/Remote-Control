using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
