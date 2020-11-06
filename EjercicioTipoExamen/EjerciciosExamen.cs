namespace EjercicioTipoExamen
{
    public class EjerciciosExamen
    {
        // Ejercicio 1 hacer una funcion que reciba 2 enteros y devuelva la suma de esos dos enteros
        public static int Ejercicio1(int a, int b)
        {
            return a + b;
        }

        // Ejercicio 2 Hacer una funcion que reciba 2 reales y devuelva la resta de esos dos reales
        public static double Ejercicio2(double a, double b)
        {
            return a - b;
        }

        // Ejercicio 3 Hacer una funcion que reciba dos enteros y devuelva el menor de los dos
        public static int Ejercicio3(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        // Ejercicio 4 Hacer una funcion que reciba 2 enteros y devuelva si el primero es menor que el segundo
        public static bool Ejercicio4(int a, int b)
        {
            return a < b;
        }

        // Ejercicio 5 Hacer una funcion que reciba 3 strings y devuelva la concatenacion de esos strings
        public static string Ejercicio5(string a, string b, string c)
        {
            return a + b + c;
        }

        // Ejercicio 6 Hacer una funcion que reciba 2 enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero y 0 en cualquier otro caso
        public static int Ejercicio6(int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return 1;
            return 0;
        }

        // Ejercicio 7 Hacer una funcion que reciba un codigo de error e imprima por pantalla error critico en caso de que el codigo sea 0; error leve en caso de que el codigo sea 1
        // Error moderado en caso de que el codigo de error sea 2; error desconocido en cualquier otro caso
        public static void Ejercicio7(int a)
        {
            switch (a)
            {
                case 0:
                    System.Console.WriteLine("Error Critico");
                    break;
                case 1:
                    System.Console.WriteLine("Error leve");
                    break;
                case 2:
                    System.Console.WriteLine("Error moderado");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        // Ejercicio 8 Hacer una funcion que reciba por parametro un numero y escriba lo siguiente: 0,3,6,9,12... hasta llegar a ese número
        public static void Ejercicio8(int a)
        {
            int i = 0;
            while (i <= a)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
        }

        // Ejercicio 9 Hacer una funcion que se le pasen 3 enteros y devuelva el menor de los tres
        public static int Ejercicio9(int a, int b, int c)
        {
              if (a <= b && a <= c)
                  return a;
              else if (b <= a && b <= c)
                  return b;
              return c;
           // if (a <= b)
           // {
           //     if (a <= c)
           //         return a;
           //     else
           //         return c;

           // }
        }

        // Ejercicio 10 Hacer una funcion que se le pasen 4 enteros y devuelva el menor de los cuatro
        public static int Ejercicio10(int a, int b, int c, int d)
        {
            if (a <= b)
            {
                if (a <= c && a <= d)
                    return a;
                else if (c <= d)
                    return c;
            }
            else
            {
                if (b <= c && b <= d)
                    return b;
                else if (c <= d)
                    return c;
            }
            return d;
        }

        // Ejercicio 11 Hacer una funcion que se le pase un entero e inprima por pantalla las siguientes series de ejemplo serie(10) = 0,1,2,3,4,5,6,7,8,9
        public static void Ejercicio11(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write(i + ", ");
        }

        // Ejercicio 12 Hacer una funcion que se le pase un entero e imprima por pantalla las siguientes series de ejemplo serie(3) = 0,1,2
        public static void Ejercicio12(int n)
        {
            if (n > 0)
                System.Console.Write(0);
            for (int i = 0; i < n; i++)
                System.Console.Write("," + i++);
        }

        // Ejercicio 13 Hacer una funcion que se le pase un numero entero e improma una linea de tantos asteriscos como ese numero asteriscos (4)= ****
        public static void Ejercicio13(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        // Ejercicio 14 Hacer una funcion que se le pase un numero e imprima el siguiente patron: asteriscos(4) *+*+
        public static void Ejercicio14(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }

        // Ejercicio 15 Hacer una funcion que se le pase un numer entero e imprima el siguiente patron: asteriscos(10)= *+-/*+-/*+
        public static void Ejercicio15(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
        }

        // Ejercicio 16 Hacer una funcion que se le pase un numero entero e imprima algo como lo siguiente: funcion(3) ***
        //                                                                                                             ***
        //                                                                                                             ***
        public static void Ejercicio16(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        // Ejercicio 17 Hacer una funcion que devuelva el menor de 16 enteros
        public static int Ejercicio17(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10, int n11, int n12, int n13, int n14, int n15, int n16)
        {
            return Ejercicio10(Ejercicio10(n1, n2, n3, n4), Ejercicio10(n5, n6, n7, n8), Ejercicio10(n9, n10, n11, n12), Ejercicio10(n13, n14, n15, n16));
        }

        // Ejercicio 18 igual que el 16 pero con las filas pares ++++
        public static void Ejercicio18(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((r % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        // Ejercicio 19 igual que el anterior pero *+*+
        //                                         +*+*
        public static void Ejercicio19(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int flag = r + c;
                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        // Ejercicio 20
        public static void Ejercicio20(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        // Ejercicio 21
        public static void Ejercicio21(int n)
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

        // Ejercicio 22 hacer una funcion que imprima por pantalla todos los divisores desde 1 hasta el numero que se le pase
        public static void Ejercicio22(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if ((n % i) == 0)
                    System.Console.Write(i + ",");
            }
        }

        // Ejercicio 23
        public static void Ejercicio23(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios = n - r - 1;
                int nespaciosintermedios = r * 2;
                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespaciosintermedios; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();

            }
        }

        // Ejercicio 24
        public static void Ejercicio24(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios1 = r;
                int nespacios2 = (n - r - 1) * 2;
                for (int c = 0; c < nespacios1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        // Ejercicio 25
        public static void Ejercicio25(int n)
        {
            Ejercicio23(n);
            Ejercicio24(n);
        }

        // Ejercicio 26 hacer una funcion que devuelva 2 elevado a un numero entero
        public static int Ejercicio26(int n)
        {
            int acumulado = 1;
            for (int i = 0; i < n; i++)
                acumulado *= 2;
            return acumulado;
            
        }

        // Ejercicio 27
        public static void Ejercicio27()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 20; c++)
                {
                    if (c >= 0 && c <= 6 && r <= 2 && r >= 0)
                    {
                        int flag = r + c;
                        if ((flag % 2) == 0)
                            System.Console.Write(".");
                        else
                            System.Console.Write(" ");
                    }
                    else if (((r / 2) % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }

        // Ejercicio 28
        public static void Ejercicio28()
        {
            
        }
    }
}
