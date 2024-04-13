using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteoGato
{
    // Modificador - Palabra Reservada Class - Identificador
    public class Gatos
    {
        //Atributos

       //Modificador - Tipo - Identificador
       public string nombre;
       public int edad;
       public string raza;
       public string pelajeColor;
       public bool hambre;

        //Metodos
        public string Saludar()
        {
            return $"HOLA! Mi nombre es {this.nombre} y mi edad es {this.edad} años. Soy de raza {this.raza} y mi color de pelaje es {pelajeColor}";
        }   

        public static void Alimentar(Gatos gato)
        {
            if (!gato.hambre)
            {
                gato.hambre = true;
            }
        }
    }
}
