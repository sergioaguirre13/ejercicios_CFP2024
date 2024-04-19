namespace LibreriaDeCuentas
{
    public class Cuentas
    {
        // atributos

        string titular;
        string tipoDeCuenta;
        decimal saldo;

        // constructor

        public Cuentas(string titular, string tipoDeCuenta, decimal saldo )
        {
            this.titular = titular;
            this.tipoDeCuenta = tipoDeCuenta;
            this.saldo = saldo;
        }

        // getters

        public string getTitular()
        {
            return titular;
        }

        public string getTipoDeCuenta()
        {
            return tipoDeCuenta;
        }

        public decimal getSaldo()
        {
            return saldo;
        }

        // metodos

        public string CuentaToString()
        {
            return $"el titular de la cuenta es: {titular} - el tipo de cuenta es: {tipoDeCuenta} - el saldo de la cuenta es: {saldo} ";
        }

        public decimal IngresarDinero()
        {
            ////IngresarDinero: recibirá un monto para acreditar a la cuenta. Si el monto
            //ingresado es negativo, no se hará nada.


            return 0;
        }

        public decimal RetirarDinero()
        {
            //        RetirarDinero: recibirá un monto para debitar de la cuenta. La cuenta
            //puede quedar en negativo.

            return 0;
        }


    }
}























