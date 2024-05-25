namespace LibreriaDeAutos
{
    public class Auto
    {
        string marca;
        int cantCombustible;
        string color;

        public Auto(string marca, int cantCombustible, string color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }

        public string GetMarca()
        {
            return marca;
        }

        public int GetCantCombustible()
        {
            return cantCombustible;
        }

        public string GetColor()
        {
            return color;
        }

        public string AutoToString()
        {
            return $"Marca: {marca} - Color {color} - Cantidad de combustible: {cantCombustible}";
        }

        public bool Avanzar(int km)
        {
            bool pudoAvanzar;
            int kilometrosPorCombustible = 10;
            int combustibleGastado = kilometrosPorCombustible * km;

            if (cantCombustible < combustibleGastado || cantCombustible < 1)
            {
                pudoAvanzar = false;

            }
            else
            {
                cantCombustible -= combustibleGastado;
                pudoAvanzar = true;
            }



            return pudoAvanzar;
        }



    }
}