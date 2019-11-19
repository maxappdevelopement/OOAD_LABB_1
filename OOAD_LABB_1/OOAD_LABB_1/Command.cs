using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_LABB_1
{
    interface Command
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
