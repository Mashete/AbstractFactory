using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Hotel
    {
        protected int cantidadNoches;

        protected DateTime fechaInicioTemporada;
        protected DateTime fechaFinTemporada;
        protected DateTime fechaLlegada;

        public string Nombre { get; set; }

        public Hotel(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicioTemporada = fechaInicio;
            this.fechaFinTemporada = fechaFin;
        }

        public virtual bool HacerReserva(DateTime fechaLlegada, int noches)
        {
            bool condicion = this.fechaInicioTemporada <= fechaLlegada && fechaLlegada.AddDays(noches) <= this.fechaFinTemporada;
            if (condicion)
            {
                Console.WriteLine("Hotel Reservado");
                this.cantidadNoches = noches;
                this.fechaLlegada = fechaLlegada;
            }
            else
                Console.WriteLine("Fuera de temporada");

            return condicion;
        }

        public abstract void VamosANadar();
        public abstract void VamosAEsquiar();

    }
}
