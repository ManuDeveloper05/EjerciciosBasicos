namespace TablaDeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* TABLA DE MULTIPLICAR *******");

            Console.WriteLine();

            inicio:
            Console.WriteLine("Ingrese un numero entre 0 y 255");
            Console.WriteLine();

            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);

            //Condicion para validar que los numeros ingresados son entre 0 y 255
            if (numero > 0 & numero < 255)
            {
                //Bucle del 1 al 12 para la tabla de multiplicar
                for (int i = 1; i < 13; i++)
                {
                    int producto = i * numero;
                    Console.WriteLine(i+ " X " + numero + " = " + producto);
                }

            }
            else
            {
                Console.WriteLine(" **INVALIDO** INGRESE UN NUMERO ENTRE 0 Y 255");
               goto inicio;
            }



                
               

            

        }
    }
}