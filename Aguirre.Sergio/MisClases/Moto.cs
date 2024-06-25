using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Moto : Vehiculo
    {
        string tipo;
        int cilindrada;

        public Moto(string marca, string modelo,string tipo, int cilindrada)
            :base(marca,modelo)
        {
            this.tipo = tipo;
            this.cilindrada = cilindrada;
        }

        public override string Conducir()
        {
            return $"{base.Conducir()} una moto";
        }

        public string HacerCaballito()
        {
            return "La moto está haciendo un caballito";
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - tipo {tipo} - cilindrada {cilindrada} ";
        }
    }
}
