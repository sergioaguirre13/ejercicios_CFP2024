namespace RepasoCondicionales
{
    internal class Condicionales
    {
        static void Main(string[] args)
        {

            int precioLamparita = 150;
            string marca;
            int cantidad = 0;
            double precioNeto = 0;
            double descuento = 0;
            double porcentajeDescuento = 0;
            double precioTotal = 0;
            double ingresosBrutos = 1.1;
            double precioTotalFinal = 0;
            
           

            Console.WriteLine("Bienvenido al sistema de compras de lamparitas!");
            Console.WriteLine("Por favor seleccione la cantidad que desea comprar");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor seleccione la marca que desee");
            marca = Console.ReadLine();

            precioNeto = cantidad * precioLamparita;

            

            if (cantidad >= 3 && cantidad <= 6)
            {
                Console.WriteLine("USTED OBTIENE UN DESCUENTO!");
            

                    switch (cantidad)
                    {
                        case >= 6:
                            descuento = 0.5;
                            precioTotal = precioNeto * descuento;
                            break;

                        case 5:
                            if (marca.ToLower() == "argentinaluz")
                            {
                                descuento = 0.6;
                                precioTotal = precioNeto * descuento;
                            } else
                            {
                                descuento = 0.7;
                                precioTotal = precioNeto * descuento;
                            }
                            break;
                        case 4:
                            if (marca.ToLower() == "argentinaluz" || marca.ToLower() == "felipelamparas")
                            {
                                descuento = 0.75;
                                precioTotal = precioNeto * descuento;
                            }
                            else
                            {
                                descuento = 0.8;
                                precioTotal = precioNeto * descuento;
                            }
                            break;
                        case 3:
                            if (marca.ToLower() == "argentinaluz")
                            {
                                descuento = 0.85;
                                precioTotal = precioNeto * descuento;
                            }
                            else if (marca.ToLower() == "felipelamparas")
                            {
                                descuento = 0.9;
                                precioTotal = precioNeto * descuento;
                            }
                            else
                            {
                                descuento = 0.95;
                                precioTotal = precioNeto * descuento;
                            }
                            break;                        
                    }
            } else
            {
                Console.WriteLine("USTED NO OBTIENE UN DESCUENTO!");
                precioTotal = precioNeto;
            }


            porcentajeDescuento = (1 - descuento) * 100;


            Console.WriteLine("Perfecto, Aqui el registro de su compra!");

            Console.WriteLine($"Usted ordeno {cantidad} lamparitas de marca {marca}");
            Console.WriteLine($"El precio total sin descuentos es de: $ {precioNeto}");
            Console.WriteLine($"Usted tiene un descuento del  {porcentajeDescuento}%");
            Console.WriteLine($"El precio total con descuentos es de $ {precioTotal}");
            if (precioTotal > 950)
            {
                precioTotalFinal = precioTotal * ingresosBrutos;
                Console.WriteLine("Usted paga ingresos brutos");
                Console.WriteLine($"El precio final con descuentos y/o impuestos es de $ {precioTotalFinal}");
            }
            else
            {
                precioTotalFinal = precioTotal;
                Console.WriteLine($"El precio final con descuentos y/o impuestos es de $ {precioTotalFinal}");

            }


        }
    }
}
