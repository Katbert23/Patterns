﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeApp
{
    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ImplementorB");
        }
    }
}
