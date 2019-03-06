using DesignPatterns.Implementaions;
using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            IAbstractfactory abstractFactory = new ConcreteFactory1();
            Client client = new Client(abstractFactory);
            client.run();
            abstractFactory = new ConcreteFactory2();
            client = new Client(abstractFactory);
            client.run();
            Console.ReadKey();
        }
    }
    class Client
    {
        private IProductA _iProductA ;
        private IProductB _iProductB ;
        public Client(IAbstractfactory factory)
        {
            _iProductA = factory.createProductA();
            _iProductB = factory.createProductB();
        }

        public void run()
        {
            _iProductB.Interact(_iProductA);
        }

    }
}
