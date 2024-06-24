using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Clienteplus : Cliente
    {
        private int _puntos;

        public int Puntos { get => _puntos; set => _puntos = value; }
        public Clienteplus(string cuentaBancaria, string cuit, int puntos)
            : base(cuentaBancaria, cuit)
        {
            Puntos = puntos;
        }

        public override string GuardarEnDisco()
        {
            return $"{base.GuardarEnDisco()} - Puntos: {Puntos}";
        }
    }
}
