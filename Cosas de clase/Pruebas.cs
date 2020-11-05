using System.Net.NetworkInformation;

namespace Cosas_de_clase
{
    class Pruebas
    {
        public static void Prueba(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0 ; j < n; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        public static void Prueba2(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios = n - r - 1;
                for (int c = 0; c <= r; c++)
                {
                    if (c < 1)
                    {
                        for (int c1 = 0; c1 < nespacios; c1++)
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.Write("*");

                }
                System.Console.WriteLine();
            }
        }
    }
}
