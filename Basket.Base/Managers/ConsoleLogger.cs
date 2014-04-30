using BasketBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.Managers
{
    public class ConsoleLogger : ILogger
    {

        public void Write(string message)
        {
            Console.WriteLine(message);
        }


        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
