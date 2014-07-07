using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toggled.Features;

namespace Toggled
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 100.5;
            var result = NumberService.ProcessNumber(value);

            

            Console.WriteLine(result);
        }
    }
}
