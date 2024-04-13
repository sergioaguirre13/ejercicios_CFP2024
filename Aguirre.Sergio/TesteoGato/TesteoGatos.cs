namespace TesteoGato
{
    internal class TesteoGatos
    {
        static void Main(string[] args)
        {

            string hambre;

            Gatos gatoUno = new Gatos();

            gatoUno.nombre = "Kero Josefina";
            gatoUno.edad = 2;
            gatoUno.raza = "verdulera";
            gatoUno.pelajeColor = "gris con rayas";

            Console.WriteLine(gatoUno.Saludar());

            Console.WriteLine($"{gatoUno.nombre} tiene hambre ?");
            hambre = Console.ReadLine();

            if (hambre == "miau")
            {
                gatoUno.hambre = true;
            }

        }
    }
}
