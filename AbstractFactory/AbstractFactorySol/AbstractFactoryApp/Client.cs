using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryApp
{
    class Client
    {
        AbstractProductA apa;
        AbstractProductB apb;

        public Client(AbstractFactory af)
        {
            apa = af.CreateProductA();
            apb = af.CreateProductB();
        }

        public void Run()
        {
            apb.Interact(apa);
        }
    }
}
