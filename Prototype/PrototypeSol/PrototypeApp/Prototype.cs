using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp
{
    abstract class Prototype
    {
        public int id { get; private set; }

        public Prototype(int id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
