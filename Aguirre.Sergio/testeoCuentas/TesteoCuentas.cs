using LibreriaDeCuentas;

namespace testeoCuentas
{
    internal class TesteoCuentas
    {
        static void Main(string[] args)
        {
            Cuentas cuenta1 = new Cuentas("Jaime Strada","Sueldo",320000);
            Cuentas cuenta2 = new Cuentas("Chicho Bregman", "Dolares", 200);
            Cuentas cuenta3 = new Cuentas("Juan Roman Palermo", "Corriente", 1000);

            Console.WriteLine(cuenta1.CuentaToString());
            Console.WriteLine(cuenta2.CuentaToString());
            Console.WriteLine(cuenta3.CuentaToString());

            cuenta1.IngresarDinero(2522);
            Console.WriteLine("Cuenta 1 con dinero ingresado: ");
            Console.WriteLine(cuenta1.CuentaToString());

            cuenta3.RetirarDinero(1090);
            Console.WriteLine("Cuenta 3 con dinero retirado: ");
            Console.WriteLine(cuenta3.CuentaToString());
        }
    }
}
