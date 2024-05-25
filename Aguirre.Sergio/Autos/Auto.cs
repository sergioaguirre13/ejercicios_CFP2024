using System.Drawing;

namespace Autos
{
    public class Auto
    {
        private string marca;
        private double cantidadCombustible;
        private Color color;

        public Auto()
        {

        }
        public Auto(string marca, double cantidadCombustible, Color color)
        {
            this.marca = marca;
            this.cantidadCombustible = cantidadCombustible;
            this.color = color;
        }

        public Auto(string marca, string Combustible, string color)
        {
            this.marca = marca;
            this.ConvertirStringCantidadCombutible(Combustible);
            this.ConvertirstringColor(color);

        }

        public Auto(string marca, string cantidadCombustible, Color color)
        {
            this.marca = marca;
            this.cantidadCombustible = double.Parse(cantidadCombustible);
            this.color = color;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public double GetCombustible()
        {
            return this.cantidadCombustible;
        }

        public Color GetColor()
        {
            return this.color;
        }

        public string AutoToString()
        {
            return $"Marca: {marca} - Combustible {cantidadCombustible} - Color {color.Name}";
        }





        private bool ConvertirStringCantidadCombutible(string combutible)
        {
            bool validador;

            if (double.TryParse(combutible, out double combutibleDouble))
            {
                this.cantidadCombustible = combutibleDouble;
                validador = true;
            }
            else
            {
                validador = false;
            }

            return validador;

        }

        private bool ConvertirstringColor(string color)
        {
            bool conversion;

            switch (color.ToLower())
            {
                case "rojo":
                    this.color = Color.Red;
                    conversion = true;
                    break;
                case "azul":
                    this.color = Color.Blue;
                    conversion = true;
                    break;
                case "negro":
                    this.color = Color.Black;
                    conversion = true;
                    break;
                case "verde":
                    this.color = Color.Green;
                    conversion = true;
                    break;
                case "amarillo":
                    this.color = Color.Yellow;
                    conversion = true;
                    break;
                case "gris":
                    this.color = Color.Gray;
                    conversion = true;
                    break;
                default:
                    conversion = false;
                    break;
            }


            return conversion;
        }


        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red, Color.Green, Color.Blue, Color.Black,Color.Purple,Color.Yellow,Color.Silver
            };

            return list;
        }
    }
}
