using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Collections;

namespace PerExt
{
    
    class Lab
    {
        delegate int cal(int a, int b);
        delegate void write();
        static int p(int a, int b) { return a + b; }
        

        static void Main(string[] args)
        {
            cal c = (int a, int b) => a + b;
            write w = () =>
            {
                Console.Write("dsd");
            };
            w();
        }

    }
}
