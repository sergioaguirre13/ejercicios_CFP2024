using Automoviles;

namespace TesteoClaseAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Autos autoUno = new Autos("Ford", "A322PPG", 2014, 290000);

            autoUno.TocarBocina();

            Console.WriteLine(autoUno.TocarBocina());


        }
    }
}
