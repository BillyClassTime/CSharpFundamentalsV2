using System;
#pragma warning disable 1591
namespace src
{
    /*
    1.	Escriba un programa en C # Sharp para verificar si una matriz dada es una matriz de identidad. 
    Datos de prueba:
    Ingrese las órdenes (2x2, 3x3, ...) de la matriz squere: 2
    Elementos de entrada en la matriz:
    elemento - [0], [0]: 1
    elemento - [0], [1] : 0
    elemento - [1], [0]: 0
    elemento - [1], [1]: 1
    Salida esperada :
    La matriz es:
    1 0
    0 1
    La matriz es una matriz de identidad.
    Solución
    */
    //In a square matrix if all the main diagonal elements are 1's and 
    //all the remaining elements are 0's is called an Identity Matrix.

    class Exercise1
    {
        public static void MainMT1()
        {
            int[,] arr1 = new int[50, 50];
            int i, j, r1, c1;

            Console.Write("\n\n Check whether a Given Matrix is an Identity Matrix :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write(" Input the orders(2x2, 3x3, ...) of squere matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = r1;

            Console.Write(" Input elements in the matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(" element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(" The matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write(" {0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    if ((i == j && arr1[i, j] != 1) || (i != j && arr1[i, j] != 0))
                    {
                        goto label;
                    }
                }
            }
            Console.WriteLine(" The matrix is an Identity Matrix.\n\n");
            return;
        label:
            Console.WriteLine("\n The matrix is not an Identity Matrix\n\n");
        }
    }
    /*
    2- Escriba un programa en C # Sharp para aceptar dos matrices y verifique si son iguales 
    Datos de prueba:
    Filas y columnas de entrada de la 1ª matriz: 2 2
    Filas y columnas de entrada de la 2ª matriz: 2 2
    Elementos de entrada en la primera matriz:
    elemento - [0], [0]: 1
    elemento - [ 0], [1]: 2
    elementos - [1], [0]: 3
    elementos - [1], [1]: 4
    Elementos de entrada en la segunda matriz:
    elemento - [0], [0]: 1
    elemento - [0], [1]:
    elemento 2 - [1], [0]:
    elemento 3 - [1], [1]: 4
    Producto esperado :
    La primera matriz es:
    1 2
    3 4
    La segunda matriz es:
    1 2
    3 4
    Las matrices se pueden comparar:
    dos matrices son iguales.
    */
    public class Exercise2
    {
        public static void MainMT2()
        {
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int i, j, r1, c1, r2, c2, flag = 1;

            Console.Write("\n\nAccept two matrices and check whether they are equal :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Input the number of rows in the 1st matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 1st matrix : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number of rows in the 2nd matrix : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 2nd matrix : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The first matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("The second matrix is :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                    Console.Write("{0}  ", brr1[i, j]);
                Console.Write("\n");
            }
            /* Comparing two matrices for equality */
            if (r1 != r2 && c1 != c2)
            {
                Console.Write("The Matrices Cannot be compared :\n");
            }
            else
            {
                Console.Write("The Matrices can be compared : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        if (arr1[i, j] != brr1[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    Console.Write("Two matrices are equal.\n\n");
                else
                    Console.Write("But,two matrices are not equal\n\n");
            }
        }
        /*
        3. Escriba un programa en C # Sharp para aceptar una matriz y determinar si es una matriz dispersa.
        /*A sparse martix is matrix which  has more zero elements than nonzero elements */
        public class Exercise3
        {
            public static void MainMT3()
            {
                int[,] arr1 = new int[10, 10];
                int i, j, r, c;
                int ctr = 0;

                Console.Write("\n\nDetermine whether a matrix is a sparse matrix :\n ");
                Console.Write("----------------------------------------------------\n");
                Console.Write("Input the number of rows of the matrix : ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns of the matrix : ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (arr1[i, j] == 0)
                        {
                            ++ctr;
                        }
                    }
                }
                if (ctr > ((r * c) / 2))
                {
                    Console.Write("The given matrix is sparse matrix. \n");
                }
                else
                    Console.Write("The given matrix is not a sparse matrix.\n");

                Console.Write("There are {0} number of zeros in the matrix.\n\n", ctr);
            }
        }
        /*A sparse martix is matrix which  has more zero elements than nonzero elements */
        public class Exercise4
        {
            public static void MainMT4()
            {
                int[,] arr1 = new int[10, 10];
                int i, j, r, c;
                int ctr = 0;

                Console.Write("\n\nDetermine whether a matrix is a sparse matrix :\n ");
                Console.Write("----------------------------------------------------\n");
                Console.Write("Input the number of rows of the matrix : ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns of the matrix : ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (arr1[i, j] == 0)
                        {
                            ++ctr;
                        }
                    }
                }
                if (ctr > ((r * c) / 2))
                {
                    Console.Write("The given matrix is sparse matrix. \n");
                }
                else
                    Console.Write("The given matrix is not a sparse matrix.\n");

                Console.Write("There are {0} number of zeros in the matrix.\n\n", ctr);

            }
        }
        /*
        28. Escriba un programa en C # Sharp para calcular el determinante de una matriz de 3 x 3.
        */
        public class Exercise5
        {
            public static void MainMT5()
            {
                int i, j;
                int[,] arr1 = new int[10, 10];
                int det = 0;

                Console.Write("\n\nCalculate the determinant of a 3 x 3 matrix :\n");
                Console.Write("-------------------------------------------------\n");

                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("The matrix is :\n");
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }

                for (i = 0; i < 3; i++)
                    det = det + (arr1[0, i] * (arr1[1, (i + 1) % 3] * arr1[2, (i + 2) % 3] - arr1[1, (i + 2) % 3] * arr1[2, (i + 1) % 3]));

                Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);
            }
        }
        /*
        27. Escriba un programa en C # Sharp para imprimir o mostrar el triangular superior de una matriz dada.
        */
        public class Exercise6
        {
            public static void MainMT6()
            {
                int i, j, n;
                int[,] arr1 = new int[50, 50];

                Console.Write("\n\nDisplay the upper triangular of a given matrix :\n");
                Console.Write("----------------------------------------------\n");

                Console.Write("Input the size of the square matrix : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("The matrix is :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }

                Console.Write("\nSetting zero in upper triangular matrix\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        if (i >= j)
                            Console.Write("{0}  ", arr1[i, j]);
                        else
                            Console.Write("{0}  ", 0);
                }
                Console.Write("\n\n");
            }
        }
    }
}