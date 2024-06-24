using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Cliente
    {
       private string _apellido;
        private string _cuentaBancaria;
        private string _cuit;
        private int _edad;
        private string _nombre;

        public Cliente(string cuentaBancaria, string cuit)
        {
            _cuentaBancaria = cuentaBancaria;
            _cuit = cuit;
        }

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string CuentaBancaria { get => _cuentaBancaria;  }
        public string Cuit { get => _cuit; set => _cuit = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public static bool ValidarCUIT(string cuit)
        {
            int cantidadGuiones = 0;

            foreach (char c in cuit)
            {
                if (c == '-')
                {
                    cantidadGuiones++;
                }
            }

            if ((cuit.Length == 13) && (cantidadGuiones == 2))
            {
                return true;

            }
             return false;
        }

        public virtual string GuardarEnDisco()
        {
            return $"Nombre: {Nombre} - Apellido: {Apellido} - CUIT: {Cuit} - Cuenta bancaria: {CuentaBancaria} - Edad: {Edad}";
        }
    }
}
/*Todos los atributos deben tener propiedades de lectura/escritura, salvo _cuentaBancaria que será de sólo lectura. 
 * Dicha clase, inicializará con su constructor, tanto el número de CUIT como el número de Cuenta Bancaria. 
 * También tendrá un método estático ValidarCUIT, que recibirá el CUIT a validar y devolverá  True‘ 
 * si el CUIT es válido o  ̳False‘ caso contrario. (Sólo se deberá validar que contenga 11 números y dos guiones, ##-########-#).
 Un método virtual GuardarEnDisco(), que mostrara la información del cliente. Diseñar la clase ClientePlus,
que herede de Cliente, que posea el campo privado  ̳_puntos‘ (lectura/escritura), y que muestre los datos del cliente plus 

En el método Main se deberán crear distintos tipos de clientes.
*/