using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Transporte
    {
        public string Nombre { get; set; }

        public abstract void Andar();
    }
}
