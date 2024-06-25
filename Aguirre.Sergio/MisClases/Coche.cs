using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Coche : Vehiculo
    {
        int numeroDePuertas;
        double capacidadMaletero;

        public Coche(string marca, string modelo, int numeroDePuertas, double capacidadMaletero)
            :base(marca,modelo)
        {
            this.numeroDePuertas = numeroDePuertas;
            this.capacidadMaletero = capacidadMaletero;
        }

        public override string Conducir()
        {
            return $"{base.Conducir()} un coche";
        }

        public string AbrirMaletero()
        {
            return "El maletero del coche se ha abierto";
        }

        public override string MostrarInfo()
        {
            return $"marca {base.marca} - modelo {base.modelo} - num de puertas {numeroDePuertas} - capacidad Maletero {capacidadMaletero} ";
        }
    }
}
