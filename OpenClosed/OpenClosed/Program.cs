using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(12,25);
            Console.WriteLine(rc.Area());
            Circle c = new Circle(4.87);
            Console.WriteLine(c.Area());

            Console.ReadLine();
        }
    }
}
