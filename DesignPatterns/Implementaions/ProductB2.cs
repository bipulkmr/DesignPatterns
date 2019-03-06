﻿using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Implementaions
{
    class ProductB2 : IProductB
    {
        public void Interact(IProductA a)
        {
            Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
        }
    }
}
