using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Auto : Transporte
    {
        public override void Andar()
        {
            Console.WriteLine("Voy por la autopista a 160km/h");
        }
    }
}
