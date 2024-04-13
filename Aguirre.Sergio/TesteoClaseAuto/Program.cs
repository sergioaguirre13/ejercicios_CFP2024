using Automoviles;

namespace TesteoClaseAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Autos autoUno = new Autos("Ford", "A322PPG", 2014, 290000);


            Console.WriteLine(autoUno.TocarBocina());

            Autos autoDos = new Autos("Chevrolet", "A223ABR", 2022, 133000.45);

            autoDos.TocarBocina();


        }
    }
}
