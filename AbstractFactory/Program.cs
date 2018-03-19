using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITemporada temporada;
            Hotel hotel;
            Transporte transporte;

            Console.WriteLine("Temporada de verano");
            temporada = new Verano();
            hotel = temporada.CrearHotel();
            hotel.HacerReserva(new DateTime(2018, 6, 12), 10);
            hotel.HacerReserva(new DateTime(2019, 1, 12), 7);
            hotel.VamosAEsquiar();
            hotel.VamosANadar();
            transporte = temporada.CrearTransporte();
            transporte.Andar();

            Console.WriteLine();
            Console.WriteLine("Temporada de nieve");
            temporada = new Invierno();
            hotel = temporada.CrearHotel();
            hotel.HacerReserva(new DateTime(2018, 7, 10), 15);
            hotel.VamosAEsquiar();
            hotel.VamosANadar();
            transporte = temporada.CrearTransporte();
            transporte.Andar();

            Console.WriteLine();
            Console.WriteLine("SemanaSanta");
            temporada = new SemanaSanta();
            hotel = temporada.CrearHotel();
            hotel.HacerReserva(new DateTime(2018, 3, 25), 2);
            hotel.VamosAEsquiar();
            hotel.VamosANadar();
            transporte = temporada.CrearTransporte();
            transporte.Andar();
            Console.ReadKey();

        }
    }
}
