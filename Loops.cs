using System;
#pragma warning disable 1591
namespace src
{
    //1.Escriba un programa C # Sharp para mostrar un patrón alfabético como 'Z' con un asterisco.
    public class ExerLoop1
    {
        public static void MainLoop1()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'Z' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //2. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'Y' con un asterisco.
    public class ExerLoop2
    {
        public static void MainLoop2()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'Y' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //3. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'X' con un asterisco.
    public class ExerLoop3
    {
        public static void MainLoop3()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'X' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //4. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'W' con un asterisco.
    public class ExerLoop4
    {
        public static void MainLoop4()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'W' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //5. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'V' con un asterisco.
    public class ExerLoop5
    {
        public static void MainLoop5()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'V' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //6. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'U' con un asterisco.
    public class ExerLoop6
    {
        public static void MainLoop6()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'U' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //7. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'T' con un asterisco.
    public class ExerLoop7
    {
        public static void MainLoop7()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'T' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //8. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'S' con un asterisco.
    public class ExerLoop8
    {
        public static void MainLoop8()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'S' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //9. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'R' con un asterisco.
    public class ExerLoop9
    {
        public static void MainLoop9()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'R' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //10. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'Q' con un asterisco.
    public class ExerLoop10
    {
        public static void MainLoop10()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'Q' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //11. Escriba un programa de C# que muestre el patrón P con asteriscos 
    public class ExerLoop11
    {
        public static void MainLoop11()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'P' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //12. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'O' con un asterisco.
    public class ExerLoop12
    {
        public static void MainLoop12()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'O' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //13. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'N' con un asterisco.
    public class ExerLoop13
    {
        public static void MainLoop13()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'N' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //14. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'M' con un asterisco.
    public class ExerLoop14
    {
        public static void MainLoop14()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'M' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //15. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'L' con un asterisco.
    public class ExerLoop15
    {
        public static void MainLoop15()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'L' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || (row == 6 && column != 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //16. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'K' con un asterisco.
    public class ExerLoop16
    {
        public static void MainLoop16()
        {
            int row, column, j = 5, i = 0;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'K' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                        Console.Write("*");

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //17. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'J' con un asterisco.
    public class ExerLoop17
    {
        public static void MainLoop17()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'J' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //18. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'I' con un asterisco.
    public class ExerLoop18
    {
        public static void MainLoop18()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'I' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //19. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'H' con un asterisco.
    public class ExerLoop19
    {
        public static void MainLoop19()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'H' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //20. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'G' con un asterisco.
    public class ExerLoop20
    {
        public static void MainLoop20()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'G' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //21. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'F' con un asterisco.
    public class ExerLoop21
    {
        public static void MainLoop21()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'F' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //22. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'E' con un asterisco.
    public class ExerLoop22
    {
        public static void MainLoop22()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'E' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //23. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'D' con un asterisco.
    public class ExerLoop23
    {
        public static void MainLoop23()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'D' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
    //24. Escriba un programa C # Sharp para mostrar un patrón alfabético como 'C' con un asterisco.
    public class ExerLoop24
    {
        public static void MainLoop24()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'C' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}



