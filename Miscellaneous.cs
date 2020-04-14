using System;
using System.Collections.Generic;
using System.Linq;
#pragma warning disable 1591
namespace src
{
    /*1. Escriba un programa C # para revertir las palabras de una oración.
    Respuesta:
    */
    public class ExerMis1
    {
        public static void MainMis1()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {
            " "
            }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {

                Console.WriteLine("\nReverse String: " + s);
            }
        }
    }
   /*
    2. Escriba un programa C # para verificar si una cadena dada contiene el carácter 'w' entre 1 y 3 veces.
    Respuesta:
    */
 
       public class ExerMis2
    {
        public static void MainMis2()
        {
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);
        }
    }
    /*
    3. Escriba un programa C # para convertir un número hexadecimal a número decimal.
    Respuesta:
    */
    public class ExerMis3
    {
        public static void MainMis3()
        {

            string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval,
            System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }
    }
    /*
    4. Escriba un programa C # para multiplicar los elementos correspondientes de dos matrices de enteros.
    Respuesta:
    */
    public class ExerMis4
    {
        public static void MainMis4()
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for (int i = 0; i < first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
    /*
    5. Escriba un programa C # para crear una nueva cadena de cuatro copias, tomando los últimos cuatro caracteres de una cadena dada. Si la longitud de la cadena dada es menor que 4, devuelva la original.
    Respuesta:
    */
    public class ExerMis5
    {
        static void MainMis5(string[] args)
        {
            string str;
            //int l = 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length > 4)
            {
                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            }
        }
    }
    /*
    6. Escriba un programa C # para verificar si un número positivo dado es un múltiplo de 3 o un múltiplo de 7
    Respuesta:
    */
    public class ExerMis6
    {
        static void MainMis6(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }
    }
    /*
    7. Escriba un programa C # para verificar si una cadena comienza con una palabra específica.
    Nota: Supongamos que la oración comienza con "Hola"
    Datos de muestra: string1 = "Hola, ¿cómo estás?"
    Resultado: Hola.
    Respuesta:
    */
    public class ExerMis7
    {
        static void MainMis7(string[] args)
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
    }
    /*
    8. Escriba un programa C # para verificar dos números dados donde uno es menor que 100 y otro es mayor que 200.
    Respuesta:
    */
    public class ExerMis8
    {
        static void MainMis8(string[] args)
        {
            Console.Write("Input a first number(<100): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>200): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));
        }
    }
    /*
    9. Escriba un programa C # para verificar si un número entero (de los dos enteros dados) está en el rango de -10 a 10
    Respuesta:
    */
    public class ExerMis9
    {
        static void MainMis9(string[] args)
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
        }
    }
    /*
    10. Escriba un programa C # para verificar si "HP" aparece en la segunda posición en una cadena y devuelve la cadena sin "HP".
    Respuesta:
    */
    public class ExerMis10
    {
        static void MainMis11(string[] args)
        {
            string str = "EOIGeneration";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
        }
    }
    /*
    11. Escriba un programa C # para obtener una nueva cadena de dos caracteres de una cadena dada. El primer y segundo carácter de la cadena dada debe ser "P" y "H", por lo que PHP será "PH".
    Respuesta:
    */
    public class ExerMis11
    {
        static void MainMis11(string[] args)
        {
            string str1 = "EOIGeneration";
            var result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
                result += str1[0];
            if (str1.Length >= 2 && str1[1] == 'H')
                result += str1[1];
            Console.WriteLine(result);
        }
    }
    /*
    12. Escriba un programa C # para encontrar los valores más grandes y más bajos de tres valores enteros.
    Respuesta:
    */
    public class ExerMis12
    {
        static void MainMi12(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
    /*
    13. Escriba un programa C # para verificar el valor más cercano de 20 de dos enteros dados y devuelva 0 si dos números son iguales.
    Respuesta:
    */
    public class ExerMis13
    {
        public static void MainMis13( )
        {
            Console.WriteLine("\nInput first integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");  
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));   
        }
    }
 
}