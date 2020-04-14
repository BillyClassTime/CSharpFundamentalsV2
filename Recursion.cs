using System;
#pragma warning disable 1591
namespace src
{
    /*
    1 - Escriba un programa en C # Sharp para imprimir el primer número n (n=20) natural usando recursividad.
    Solución:
    */
    class Recursion1
    {
        static int printNatural(int stval, int ctr)
        {
            if (ctr < 1)
            {
                return stval;
            }
            ctr--;
            Console.Write(" {0} ", stval);
            return printNatural(stval + 1, ctr);
        }
        static void MainRC1()
        {
            Console.Write("\n\n Recursion : Print the first n natural number :\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write(" How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());
            // Call recursive method with two parameters.	
            printNatural(1, ctr);
            Console.Write("\n\n");
        }
    }
    /*
    2 - Escriba un programa en C # Sharp para imprimir números de n (n=20) a 1 usando recursividad.
    Solución:
    */
    class Recursion2
    {
        static int printNatural(int ctr, int stval)
        {
            if (ctr < 1)
            {
                return stval;
            }

            Console.Write(" {0} ", ctr);
            ctr--;
            return printNatural(ctr, stval);
        }

        static void MainRC2()
        {
            Console.Write("\n\n Recursion : Print the natural numbers from n to 1 :\n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write(" How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());
            // Call recursive method with two parameters.	
            printNatural(ctr, 1);
            Console.Write("\n\n");
        }
        /*
        3 - Escriba un programa en C # Sharp para encontrar la suma de los primeros n (n=5) números naturales usando la recursividad.
        Solución: 
        */
        class Recursion3
        {
            static void MainRC3(string[] args)
            {
                Console.Write("\n\n Recursion : Sum of first n natural numbers :\n");
                Console.Write("--------------------------------------------------\n");
                Console.Write(" How many numbers to sum : ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write(" The sum of first {0} natural numbers is : {1}\n\n", n, SumOfTen(1, n));
            }

            static int SumOfTen(int min, int max)
            {
                return CalcuSum(min, max);
            }

            static int CalcuSum(int min, int val)
            {
                if (val == min)
                    return val;
                return val + CalcuSum(min, val - 1);
            }
        }
        /*
        4 - Escriba un programa en C # Sharp para mostrar los dígitos individuales de un número determinado utilizando la recursividad.
        Solución:
        */
        public class Recursion4
        {
            static void MainRC4()
            {
                Console.Write("\n\n Recursion : Display the individual digits of a given number :\n");
                Console.Write("------------------------------------------------------------------\n");
                Console.Write(" Input any number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write(" The digits in the number {0} are : ", num);
                separateDigits(num);
                Console.Write("\n\n");
            }

            static void separateDigits(int n)
            {
                if (n < 10)
                {
                    Console.Write("{0}  ", n);
                    return;
                }
                separateDigits(n / 10);
                Console.Write(" {0} ", n % 10);
            }
        }
        /*
        5 - Escriba un programa en C # Sharp para contar el número de dígitos en un número usando recursividad.
        Solución:
        */
        class Recursion5
        {
            static void MainRC5(string[] args)
            {

                Console.Write("\n\n Recursion : Count the number of digits in a number :\n");
                Console.Write("---------------------------------------------------------\n");
                Console.Write(" Input any number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n The number {0} contains number of digits : {1} ", num, getDigits(num, 0));
                Console.ReadLine();
            }

            public static int getDigits(int n1, int nodigits)
            {
                if (n1 == 0)
                    return nodigits;

                return getDigits(n1 / 10, ++nodigits);
            }
        }
        /*
        6 - Escriba un programa en C # Sharp para imprimir números pares o impares en un rango determinado utilizando la recursividad.
        Solución: 
        */
        class Recursion6
        {
            public static void MainRC6()
            {
                int n;
                Console.Write("\n\n Recursion : Print even or odd numbers in a given range :\n");
                Console.Write("-------------------------------------------------------------\n");

                Console.Write(" Input the range to print starting from 1 : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n All even numbers from 1 to {0} are : ", n);
                EvenAndOdd(2, n);//call the function EvenAndOdd for even numbers 

                Console.WriteLine("\n\n All odd numbers from 1 to {0} are : ", n);
                EvenAndOdd(1, n);// call the function EvenAndOdd for odd numbers
                Console.WriteLine("\n\n");

                return;
            }
            static void EvenAndOdd(int stVal, int n)
            {
                if (stVal > n)
                    return;
                Console.Write(" {0}  ", stVal);
                EvenAndOdd(stVal + 2, n);//calling the function EvenAndOdd itself recursively
            }
        }
        /*
        7 - Escriba un programa en C # Sharp para verificar si un número es primo o no usando recursividad.
        Solución:
        */
        class Recursion7
        {
            public static int MainRC7()
            {
                int n1, primeNo;

                Console.WriteLine("\n\n Recursion : Check a number is prime number or not :");
                Console.WriteLine("--------------------------------------------------------");

                Console.Write(" Input any positive number : ");
                n1 = Convert.ToInt32(Console.ReadLine());

                primeNo = checkForPrime(n1, n1 / 2);//call the function checkForPrime

                if (primeNo == 1)
                    Console.Write(" The number {0} is a prime number. \n\n", n1);
                else
                    Console.WriteLine(" The number {0} is not a prime number. \n\n", n1);
                return 0;
            }

            static int checkForPrime(int n1, int i)
            {
                if (i == 1)
                {
                    return 1;
                }
                else
                {
                    if (n1 % i == 0)
                        return 0;
                    else
                        return checkForPrime(n1, i - 1);//calling the function checkForPrime itself recursively
                }
            }
        }

        /*
        8 - Escriba un programa en C # Sharp para verificar si una cadena determinada es Palindrome o no utiliza recursividad.
        Solución:
        */
        public class Recursion8
        {
            public static bool IsPalindrome(string text)
            {
                if (text.Length <= 1)
                    return true;
                else
                {
                    if (text[0] != text[text.Length - 1])
                        return false;
                    else
                        return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
            public static void MainRC8()
            {
                Console.Write("\n\n Recursion : Check whether a string ia Palindrome or not :\n");
                Console.Write("---------------------------------------------------------------\n");
                string str1;
                bool tf;

                Console.Write(" Input a string : ");
                str1 = Console.ReadLine();
                tf = IsPalindrome(str1);
                if (tf == true)
                {
                    Console.WriteLine(" The string is Palindrome.\n");
                }
                else
                {
                    Console.WriteLine(" The string is not a Palindrome.\n");
                }
            }
        }
        /*
        9 - Escriba un programa en C # Sharp para encontrar el factorial de un número dado usando la recursividad.
        Solución:
        */
        class Recursion9
        {
            static void MainRC9(string[] args)
            {
                Console.WriteLine("\n\n Recursion : Find the factorial of a given number :");
                Console.WriteLine("-------------------------------------------------------");

                Console.Write(" Input any positive number : ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                long fact = FactorialCalcu(n1);
                Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);
                Console.ReadKey();
            }

            private static long FactorialCalcu(int n1)
            {
                if (n1 == 0)
                {
                    return 1;
                }
                return n1 * FactorialCalcu(n1 - 1);
            }
        }
        /*
        10 - Escriba un programa en C # Sharp para encontrar los números de Fibonacci para n números de series usando recursividad.
        Solución:
        */
        class Recursion10
        {
            public static int FindFibonacci(int n)
            {
                int p = 0;
                int q = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = p;
                    p = q;
                    q = temp + q;
                }
                return p;
            }

            static void MainRC10()
            {
                Console.WriteLine("\n\n Recursion : Find the Fibonacci numbers for a n numbers of series :");
                Console.WriteLine("-----------------------------------------------------------------------");

                Console.Write(" Input number of terms for the Fibonacci series : ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n The Fibonacci series of {0} terms is : ", n1);
                for (int i = 0; i < n1; i++)
                {
                    Console.Write("{0} ", FindFibonacci(i));
                }
                Console.ReadKey();
            }
        }
        /*
        11 - Escriba un programa en C # Sharp para generar todas las permutaciones posibles de una matriz mediante recursividad.
        Solución:
        */
        class formPermut
        {
            public void swapTwoNumber(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            public void prnPermut(int[] list, int k, int m)
            {
                int i;
                if (k == m)
                {
                    for (i = 0; i <= m; i++)
                        Console.Write("{0}", list[i]);
                    Console.Write(" ");
                }
                else
                    for (i = k; i <= m; i++)
                    {
                        swapTwoNumber(ref list[k], ref list[i]);
                        prnPermut(list, k + 1, m);
                        swapTwoNumber(ref list[k], ref list[i]);
                    }
            }
        }
        class Recursion11
        {
            public static void MainRC11()
            {
                int n, i;
                formPermut test = new formPermut();
                int[] arr1 = new int[5];

                Console.WriteLine("\n\n Recursion : Generate all possible permutations of an array :");
                Console.WriteLine("------------------------------------------------------------------");

                Console.Write(" Input the number of elements to store in the array [maximum 5 digits ] :");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Input {0} number of elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write(" element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\n The Permutations with a combination of {0} digits are : \n", n);
                test.prnPermut(arr1, 0, n - 1);
                Console.Write("\n\n");
            }
        }
        /*
        12 - Escriba un programa en C # Sharp para encontrar el MCM y el MCD de dos números usando la recursividad.
        Solución:
        */
        class Recursion12
        {
            public static void MainRC12()
            {
                long num1, num2, hcf, lcm;
                Console.WriteLine("\n\n Recursion : Find the LCM and GCD of two numbers :");
                Console.WriteLine("------------------------------------------------------");

                Console.Write(" Input the first number : ");
                num1 = Convert.ToInt64(Console.ReadLine());
                Console.Write(" Input the second number : ");
                num2 = Convert.ToInt64(Console.ReadLine());

                hcf = gcd(num1, num2);
                lcm = (num1 * num2) / hcf;

                Console.WriteLine("\n The GCD of {0} and {1} = {2} ", num1, num2, hcf);
                Console.WriteLine(" The LCM of {0} and {1} = {2}\n", num1, num2, lcm);


            }

            static long gcd(long n1, long n2)
            {
                if (n2 == 0)
                {
                    return n1;
                }
                else
                {
                    return gcd(n2, n1 % n2);
                }
            }
        }
        /*
        13 - Escriba un programa en C # Sharp para convertir un número decimal a binario usando recursividad.
        Solución:
        */
        class Recursion13
        {
            public static void MainRC13(string[] args)
            {
                int num;
                DecToBinClass pg = new DecToBinClass();
                Console.WriteLine("\n\n Recursion : Convert a decimal number to binary :");
                Console.WriteLine("------------------------------------------------------");
                Console.Write(" Input a decimal number : ");
                num = int.Parse(Console.ReadLine());
                Console.Write(" The binary equivalent of {0} is : ", num);
                pg.deciToBinary(num);
                Console.ReadLine();
                Console.Write("\n");
            }
        }
        public class DecToBinClass
        {
            public int deciToBinary(int num)
            {
                int bin;
                if (num != 0)
                {
                    bin = (num % 2) + 10 * deciToBinary(num / 2);
                    Console.Write(bin);
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }
        /*
        14 - Escriba un programa en C # Sharp para obtener el reverso de una cadena usando recursividad.
        Solución:
        */
        class Recursion14
        {
            static void MainRC14()
            {
                string str;
                Console.WriteLine("\n\n Recursion : Get the reverse of a string :");
                Console.WriteLine("----------------------------------------------");
                Console.Write(" Input the string : ");
                str = Console.ReadLine();
                str = StringReverse(str);
                Console.Write(" The reverse of the string is : ");
                Console.Write(str);
                Console.ReadKey();
                Console.Write("\n");

            }

            public static string StringReverse(string str)
            {
                if (str.Length > 0)
                    return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
                else
                    return str;
            }
        }
        /*
        15 - Escriba un programa en C # Sharp para calcular la potencia de cualquier número usando recursividad.
        Solución:
        */
        public class Recursion15
        {
            public static void MainRC15()
            {
                int bNum, pwr;
                int result;
                Console.Write("\n\n Recursion : Calculate power of any number :\n");
                Console.Write("------------------------------------------------\n");

                Console.Write(" Input the base  value : ");
                bNum = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Input the exponent : ");
                pwr = Convert.ToInt32(Console.ReadLine());

                result = CalcuOfPower(bNum, pwr);//called the function CalcuOfPower

                Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);
            }

            public static int CalcuOfPower(int x, int y)
            {
                if (y == 0)
                    return 1;
                else
                    return x * CalcuOfPower(x, y - 1);
            }
        }
    }
}

