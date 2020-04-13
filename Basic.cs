using System;
using System.IO;
#pragma warning disable 1591
namespace src
{
    //1 - Escriba un programa C # Sharp para imprimir Hello y su nombre en una línea separada.
    //Respuesta:
    public class Basics
    {
        public int Main1()
        {
            #region Exer1
            Console.WriteLine("(1)=====");
            System.Console.WriteLine("Hello");
            System.Console.WriteLine("Billy Vanegas!");
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
        //2 - Escriba un programa C # Sharp para imprimir la suma de dos números.
        //Respuesta:
        public int Main2()
        {
            #region Exer2
            Console.WriteLine("(2)=====");
            System.Console.WriteLine(15 + 17);
            #endregion
            return 0;
        }
        //3 - Escriba un programa C # Sharp para imprimir el resultado de dividir dos números. 
        //Respuesta:
        public int Main3()
        {
            #region Exer3
            Console.WriteLine("(3)=====");
            System.Console.WriteLine(36 / 6);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
        //4 - Escriba un programa C # Sharp para imprimir el resultado de la operación especificada.
        /*Test data:
        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2
        Expected Output:
        23
        5
        12
        3
        Respuesta:*/
        public int Main4()
        {
            #region Exer4
            Console.WriteLine("(4)=====");
            System.Console.WriteLine(-1 + 4 * 6);
            //-1 + 24 = 23
            System.Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5 (remainder of 40/7)
            System.Console.WriteLine(14 + -4 * 6 / 11);
            //14 - (24/11)= 14 - 2 = 12
            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
            Console.WriteLine("\n========");
            #endregion 
            return 0;
        }
        //5 - Escriba un programa C # Sharp para intercambiar dos números.
        /*Test Data:
        Input the First Number : 5
        Input the Second Number : 6
        Expected Output:
        After Swapping :
        First Number : 6
        Second Number : 5
        Respuesta:*/
        public int Main5()
        {
            #region Exer5
            Console.WriteLine("(5)=====");
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
        //6. Escriba un programa C # Sharp para imprimir la salida de la multiplicación de tres números que ingresará el usuario.
        /*Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36
        Respuesta:*/
        public int Main6()
        {
            #region Exer6
            Console.WriteLine("(6)=====");
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
        //7. Escriba un programa en C# Sharp para imprimir en pantalla el resultado de sumar, restar, multiplicar y divider dos números que serán ingresados por el usuario.
        /*Test Data:
        Input the first number: 25
        Input the second number: 4
        Expected Output:
        25 + 4 = 29
        25 - 4 = 21
        25 x 4 = 100
        25 / 4 = 6
        25 mod 4 = 1
        Respuesta:*/
        public int Main7()
        {
            #region Exer7
            Console.WriteLine("(7)=====");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
        //8. Escriba un programa C # Sharp que tome un número como entrada e imprima su tabla de multiplicar.
        /*Test Data:
        Enter the number: 5
        Expected Output:
        5 * 0 = 0
        5 * 1 = 5
        5 * 2 = 10
        5 * 3 = 15
        ....
        5 * 10 = 50
        Respuesta:*/
        public int Main8()
        {
            #region Exer8
            Console.WriteLine("(8)=====");
            int x;
            int result;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            result = x * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }

        //9. Escriba un programa C # Sharp que tome cuatro números como entrada para calcular e imprimir el promedio.
        /*Test Data:
        Enter the First number: 10
        Enter the Second number: 15
        Enter the third number: 20
        Enter the four number: 30
        Expected Output:
        The average of 10 , 15 , 20 , 30 is: 18
        Respuesta:*/
        public int Main9()
        {
            #region Exer9
            Console.WriteLine("(9)=====");
            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            number1, number2, number3, number4, result);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }
    }
    //10. Escriba un programa Sharp de C # que tome tres números (x, y, z) como entrada e imprima la salida de (x + y) · z y x · y + y · z.
    //Respuesta:
    public class Exercise10
    {
        public static void Main10()
        {
            #region Exer10
            int number1, number2, number3;

            Console.Write("Enter first number - ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
            #endregion
        }
    }
    //11. Escriba un programa C # Sharp que tome una edad (por ejemplo 20) como entrada e imprima algo como "Parece mayor de 20 años.
    //Respuesta:
    public class Exercise11
    {
        public static void Main11()
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
        }
    }
    //12. Escriba un programa C # que tome un número como entrada y muéstrelo cuatro veces seguidas (separadas por espacios en blanco), y luego cuatro veces en la siguiente fila, sin separación. Debes hacerlo dos veces: usa la Console.WriteLine  y Console.Write y luego usa {0}.
    //Respuesta:
    public class Exercise12
    {
        public static void Main12()
        {
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Part A: "num num num num" using Write
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            // Part B: "numnumnumnum" using Write
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            // Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
    //13. Escriba un programa C # que tome un número como entrada y luego muestre un rectángulo de 3 columnas de ancho y 5 filas de alto usando ese dígito.
    //Respuesta:
    public class Exercise13
    {
        public static void Main13()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
    //14. Escriba un programa C # Sharp para convertir de grados Celsius a Kelvin y Fahrenheit.
    /*kelvin = celsius + 273
    fahrenheit = celsius x 18/10 + 32
    Respuesta:*/
    public class Exercise14
    {
        public static void Main14()
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
    //15. Escribir un programa C # para eliminar un carácter específico de una cadena no vacía utilizando el índice de un carácter
    //Respuesta:

    public class Exercise15
    {
        static void Main15(string[] args)
        {
            Console.WriteLine(remove_char("EOIG3neration", 1));
            Console.WriteLine(remove_char("EOIG3neration", 9));
            Console.WriteLine(remove_char("EOIG3neration", 0));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
    //16. Escriba un programa C # para crear una nueva cadena a partir de una cadena determinada donde el primer y el último carácter cambiarán de posición.
    //Respuesta:

    public class Exercise16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine(first_last("EOIG3neration"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
    //17. Escriba un programa C # para crear una nueva cadena a partir de una cadena dada (longitud 1 o más) con el primer carácter agregado en la parte frontal y posterior.
    //Respuesta:
    public class Exercise17
    {
        static void Main17(string[] args)
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
    }
    //18.Escriba un programa C # para verificar dos enteros dados y devuelva verdadero si uno es negativo y el otro es positivo.
    //Respuesta:
    public class Exercise18
    {
        static void Main18(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
    }

    ///19. Escriba un programa C # para calcular la suma de dos enteros dados, si dos valores son iguales, devuelva el triple de su suma.
    //Respuesta:
    public class Exercise19
    {
        static void Main19(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }

    //20. Escriba un programa C # para obtener el valor absoluto de la diferencia entre dos números dados. Devuelve el doble del valor absoluto de la diferencia si el primer número es mayor que el segundo número.
    //Respuesta:

    public class Exercise20
    {
        static void Main20(string[] args)
        {
            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));
        }

        public static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return b - a;
        }
    }

    //21. Escriba un programa C # para verificar la suma de los dos enteros dados y devolver verdadero si uno de los enteros es 20 o si su suma es 20.
    //Respuesta:

    public class Exercise21
    {
        static void Main21(string[] args)
        {
            int x, y;
            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
    //22.Escriba un programa C # para verificar si un entero dado está dentro de 20 de 100 o 200.
    //Respuesta:
    public class Exercise22
    {
        static void Main22(string[] args)
        {
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
        }
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }

    //23. Escriba un programa de C # para convertir una cadena dada en minúsculas.
    //Respuesta:
    public class Exercise23
    {
        public static void Main23()
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            Console.WriteLine(line.ToLower());
        }
    }

    //24. Escriba un programa C # para encontrar la palabra más larga en una cadena.
    //Respuesta:
    public class Exercise24
    {
        public static void Main24()
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

        }
    }
    //25. Escriba un programa C # para imprimir los números impares del 1 al 99. Imprime un número por línea.
    //Respuesta:
    public class Exercise25
    {
        public static void Main25()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

        }
    }

    //26. Escriba un programa C # para calcular la suma de los primeros 500 números primos.
    //Respuesta:
    public class Exercise26
    {
        public static void Main26()
        {
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());

        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }

    //27. Escriba un programa C # y calcule la suma de los dígitos de un entero.
    //Respuesta:
    public class Exercise27
    {
        public static void Main27()
        {
            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }
}