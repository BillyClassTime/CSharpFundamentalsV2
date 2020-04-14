using System;
#pragma warning disable 1591

namespace src
{
    //1 - Escriba un programa en C # Sharp para crear una función definida por el usuario.
    //Solución:
    class funcion1
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
        }
        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }
        public static void MainF1()
        {
            Console.Write("\n\nSee, how to create an user define function :\n");
            Console.Write("------------------------------------------------\n");
            welcome();
            HaveAnice();
            Console.Write("\n");
        }
    }
    /*
    2 - Escriba un programa en C # Sharp para crear una función de definición de usuario con parámetros.
    Solución:
    */
    public class funcion2
    {
        public static void welcome(string name)
        {
            Console.WriteLine("Welcome friend " + name + " !");
        }
        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }
        public static void MainF2(string[] args)
        {
            Console.Write("\n\nSee, how to create an user define function with parameters :\n");
            Console.Write("----------------------------------------------------------------\n");
            string str1;

            Console.Write("Please input a name : ");
            str1 = Console.ReadLine();
            welcome(str1);
            HaveAnice();
        }
    }

/*
3 - Escriba un programa en C # Sharp para crear una función para la suma de dos números.
Solución:
*/
public class funcion3
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void MainF3()
        {
            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
        }
    }

/*
4 - Escriba un programa en C # Sharp para crear una función para ingresar una cadena y contar el número de espacios en la cadena.
Solución:
*/
public class funcion4
    {
        public static int SpaceCount(string str)
        {
            int spcctr = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }
            return spcctr;
        }
        public static void MainF4()
        {
            string str2;
            Console.Write("\n\nFunction to count number of spaces in a string :\n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();
            Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
        }
    }
/*
5 - Escriba un programa en C # Sharp para calcular la suma de elementos en una matriz.
Solución:
*/
public class funcion5
    {
        public static int Sum(int[] arr1)
        {
            int tot = 0;
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }
        public static void MainF5()
        {
            int[] arr1 = new int[5];
            Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.Write("Input 5 elements in the array :\n");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr1));
        }
    }
/*
6 - Escriba un programa en C # Sharp para crear una función para intercambiar los valores de dos números enteros.
Solución:
*/
public class funcion6
    {
        public static void interchange(ref int num1, ref int num2)
        {
            int newnum;

            newnum = num1;
            num1 = num2;
            num2 = newnum;
        }
        public static void MainF6()
        {
            int n1, n2;
            Console.Write("\n\nFunction : To swap the values of two integer numbers :\n");
            Console.Write("----------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            interchange(ref n1, ref n2);
            Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", n1, n2);
        }
    }
/*
7. Escriba un programa en C # Sharp para crear una función para calcular el resultado de elevar un número entero a otro.
Solución:
*/
public class funcion7
    {
        public static void MainF7()
        {
            int n1;
            int exp1;
            Console.Write("\n\nFunction : To calculate the result of raising an integer number to another :\n");
            Console.Write("--------------------------------------------------------------------------------\n");
            Console.Write("Input Base number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Exponent : ");
            exp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ", n1, exp1, PowerRaising(n1, exp1));
        }
        public static int PowerRaising(int num, int exp)
        {
            int rvalue = 1;
            int i;
            for (i = 1; i <= exp; i++)
                rvalue = rvalue * num;
            return rvalue;
        }
    } 
/*
8 - Escriba un programa en C # Sharp para crear una función que muestre la secuencia de Fibonacci del número n.
Solución:*/

class funcion8
    {
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
        public static void MainF9()
        {
            Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Input number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci series of " + n + " numbers is :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i) + "  ");
            }
            Console.WriteLine();
        }
    }
/*
9 - Escriba un programa en C # Sharp para crear una función para verificar si un número es primo o no.
Solución:
*/
public class funcion9
    {
        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void MainF9()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
/*
10 - Escriba un programa en C # Sharp para crear una función para calcular la suma de los dígitos individuales de un número dado.
Solución:
*/
public class funcion10
    {
        public static int SumCal(int n)
        {
            string n1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }

        public static void MainF10()
        {
            int num;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.Write("--------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));
        }
    }
/*
11 - Escriba un programa en C # Sharp para crear una función recursiva para encontrar el factorial de un número dado.
Solución:
*/
class func012
    {
        static void MainF12()
        {
            decimal f;
            Console.Write("\n\nRecursive Function : To find the factorial of a given number :\n");
            Console.Write("------------------------------------------------------------------\n");
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            f = Factorial(num);
            Console.WriteLine("The factorial of {0}! is  {1}", num, f);
        }
        static decimal Factorial(int n1)
        {
            // The bottom of the recursion
            if (n1 == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n1 * Factorial(n1 - 1);
            }
        }
    }
/*
12 - Escriba un programa en C # Sharp para crear una función recursiva para calcular el número de Fibonacci de un término específico.
Solución:
*/
public class funcion12
    {
        public static int Fib(int n1)
        {
            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
        }

        public static void Main12()
        {
            int num;

            Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
            Console.Write("-------------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
        }
    }
}