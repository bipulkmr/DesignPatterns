using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Implementaions
{
    class ConcreteFactory2 : IAbstractfactory
    {
        public IProductA createProductA()
        {
            return new ProductA2();
        }

        public IProductB createProductB()
        {
            return new ProductB2();
        }
    }
}
