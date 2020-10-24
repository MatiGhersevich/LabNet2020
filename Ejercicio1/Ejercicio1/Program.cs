using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehiculos = new List<Transporte>();

            Automovil[] automovil = new Automovil[5];
            Avion[] avion = new Avion[5];

            for (int i=0;i < 5;i++)
            {
                int c = i + 1;
                automovil[i] = new Automovil(c);
                vehiculos.Add(automovil[i]);
            }


            for (int i = 0; i < 5; i++)
            {
                int c = (i+1) * 10;
                avion[i] = new Avion(c);
                vehiculos.Add(avion[i]);
            }

            Console.WriteLine(automovil[0].Detenerse());
            Console.WriteLine(avion[2].Avanzar());
            
            Console.WriteLine(avion[1].DevolverCantPasajeros());
            Console.WriteLine(automovil[1].DevolverCantPasajeros());


            Console.ReadKey();
        }
    }
}

// no abusar del + para concatenar strings
