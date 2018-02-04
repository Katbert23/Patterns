using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = null;
            Prototype clone = null;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();
            Console.WriteLine(clone.id);

            Console.WriteLine(new string('*',25));

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
            Console.WriteLine(clone.id);

            Console.ReadKey();
        }
    }
}
