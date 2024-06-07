namespace MisClases
{
    public class Materia
    {
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public int NotaFinal
        {
            get
            {
                return CalcularNotaFinal();
            }
        }

        public double Promedio
        {
            get
            {
                return CalcularPromedio();
            }
        }

        static Materia()
        {
            random = new Random();
        }

        public Materia(string nombre)
        {
            this.nombre = nombre;
        }

        private int CalcularNotaFinal()
        {
            int nota = 0;

            if (NotaPrimerParcial > 3 && NotaSegundoParcial > 3)
            {
                nota = random.Next(6, 10);
            }

            return nota;
        }

        private double CalcularPromedio()
        {
            return ((double)NotaPrimerParcial + NotaSegundoParcial) / 2;
        }

        public override string? ToString()
        {
            return $"{nombre}";
        }
    }
}
