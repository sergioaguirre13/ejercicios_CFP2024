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

        public bool IngresarDinero(decimal dineroIngresado)
        {
           
            if (dineroIngresado <= 0)
            {
                return false;
            }
            else
            {
                this.saldo += dineroIngresado;
                return true;
            }
        }

        public decimal RetirarDinero(decimal dineroRetirado)
        {
    
            saldo -= dineroRetirado;

            return saldo;
        }
    }
}























