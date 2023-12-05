namespace Ejercicio5
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de problemas que Sam resuelve diariamente: ");
            int samD = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de problemas que Kelly resuelve diariamente: ");
            int kellyD = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de problemas que Sam resolvio inicialmente mas que kelly: ");
            int diferencia = int.Parse(Console.ReadLine());

            int resultado = MinNum(samD, kellyD, diferencia);

            if (resultado == -1)
            {
                Console.WriteLine("Es imposible que kelly supere a sam");
            }
            else
            {
                Console.WriteLine($"Kelly supera a Sam en el dia {resultado}.");
            }
        }

        static int MinNum(int samD, int kellyD, int diferencia)
        {
            if (samD <= kellyD)
            {
                return -1;
            }

            int dias = (diferencia / (samD - kellyD)) + 1;
            return dias;
        }

    }
}
