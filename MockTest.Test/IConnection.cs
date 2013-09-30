using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compta
{
    public interface IConnection
    {
        void Connect();
        void Execute();
    }
}
