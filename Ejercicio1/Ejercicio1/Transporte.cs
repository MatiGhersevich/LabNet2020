using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    abstract class  Transporte : ITransporte
    {
        #region Variables
        private int cantPasajeros;
        #endregion

        #region Metodos
        public Transporte(int cantPasajeros)
         {
         this.cantPasajeros = cantPasajeros;
         }
        public int CantPasajeros
        {
            get { return this.cantPasajeros; }

            set { this.cantPasajeros = value; }
        }

        public string DevolverCantPasajeros()
        {
            Avion tipo = new Avion(0);
            if (this.GetType().Equals(tipo.GetType()))
            {
                return $"el avion posee una cantidad de {this.cantPasajeros} de pasajeros";
            }
            else return $"El auto posee una cantidad de {this.cantPasajeros} de pasajeros";
        } 


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public  string Detenerse()
        {
            Avion tipo = new Avion(0);
            if (this.GetType().Equals(tipo.GetType()))
            {
                return "El avion esta detenido en el hangar";
            }
            else return "El auto esta detenido en el garage";
        }

        public string Avanzar() {
            Avion tipo = new Avion(0);
            if (this.GetType().Equals(tipo.GetType()))
            {
                return "El avion avanza por aire";
            }
            else return "El auto avanza por tierra";
        } 
        #endregion
    }
}
