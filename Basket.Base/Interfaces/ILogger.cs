using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketBase.Interfaces
{
    public interface ILogger
    {
        void Write(string message);
        void Info(string message);
    }
}
