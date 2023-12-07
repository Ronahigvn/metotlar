using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(12, 12);
            dortIslem.Topla(6, 9);
            Console.ReadLine();
        }
    }
}
