using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotoNieve : Transporte
    {
        public override void Andar()
        {
            Console.WriteLine("Voy por la montaña!");
        }
    }
}
