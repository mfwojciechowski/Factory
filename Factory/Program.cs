using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = CarFactory.CreateInstance("Porshe");
            var factoryCarListConstains = CarFactory.CarList.ContainsKey("Porshe");

            Console.WriteLine(factory);
            Console.WriteLine(factoryCarListConstains);
           
            
            
            Console.ReadKey();
        }
    }
}
