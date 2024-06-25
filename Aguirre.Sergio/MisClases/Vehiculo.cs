using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Vehiculo
    {
       protected string marca;
       protected string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual string Conducir()
        {
            return "Estoy conduciendo";
        }

        public virtual string MostrarInfo()
        {
            return $"Marca: {marca} - Modelo: {modelo}";
        }

    }
}
