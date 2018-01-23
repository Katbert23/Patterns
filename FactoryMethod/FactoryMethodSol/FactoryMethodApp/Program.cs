using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();

            Console.ReadKey();
        }
    }
}
