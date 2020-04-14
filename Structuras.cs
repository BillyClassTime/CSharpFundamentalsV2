
using System;
using System.IO;
#pragma warning disable 1591
namespace src
{
    /*
    1 - Escriba un programa en C # Sharp para declarar una estructura simple.
    Solución:
*/
    struct eoiGenerationSt
    {
        public int x;
        public int y;
    }
    class strucExer1
    {
        public static void MainST1()
        {
            Console.Write("\n\nDeclare a simple structure :\n");
            Console.Write("--------------------------------\n");
            eoiGenerationSt egSt = new eoiGenerationSt();
            egSt.x = 15;
            egSt.y = 25;
            int sum = egSt.x + egSt.y;
            Console.WriteLine("The sum of x and y is {0}\n", sum);
        }
    }
    /*
    2 - Escriba un programa en C # Sharp para declarar una estructura simple y el uso de campos estáticos dentro de una estructura.
    Solución:
    */
    struct eoiGenSt
    {
        public static int x = 15;
        public static int y = 25;
    }
    class strucExer2
    {
        public static void MainST2()
        {
            Console.Write("\n\nStructure with the use of static fields inside a struct :\n");
            Console.Write("-------------------------------------------------------------\n");
            int sum = eoiGenSt.x + eoiGenSt.y;
            Console.WriteLine("The sum of x and y is {0}\n", sum);
        }
    }
    /*
    3 - Escriba un programa en C # Sharp para crear una estructura anidada para almacenar dos datos para un empleado en una matriz.
    Solución:
    */
    class strucExer3
    {
        //employee is a structure of members eName and dtObirth
        struct employee
        {
            public string eName;
            public dtObirth Date;
        }
        //dtObirth is a nested structure of employee
        struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void MainST3(string[] args)
        {

            int dd = 0, mm = 0, yy = 0;
            int total = 2;
            Console.Write("\n\nCreate a nested struct and store data in an array :\n");
            Console.Write("-------------------------------------------------------\n");
            employee[] emp = new employee[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
        }
    }
/*
4 - Escriba un programa en C # Sharp para crear una estructura y asignar el valor y llamarlo.
Solución:
*/
// crate a class
class aNewClass
    {
        public int x;
        public int y;
    }
    //create a structure 
    struct aNewStruc
    {
        public int x;
        public int y;
    }
    class strucExer4
    {
        static void MainST4(string[] args)
        {
            Console.Write("\n\nCreate a structure and Assign the Value and call it :\n");
            Console.Write("---------------------------------------------------------\n");
            aNewClass ClassNum1 = new aNewClass();
            ClassNum1.x = 75;
            ClassNum1.y = 95;
            //	ClassNum2 is ClassNum1 type	
            aNewClass ClassNum2 = ClassNum1;
            ClassNum1.x = 7500;
            ClassNum1.y = 9500;
            Console.WriteLine("\nAssign in Class:       x:{0},   y:{1}", ClassNum2.x, ClassNum2.y);
            aNewStruc StrucNum1 = new aNewStruc();
            StrucNum1.x = 750;
            StrucNum1.y = 950;
            //	StrucNum2 is StrucNum1 type			
            aNewStruc StrucNum2 = StrucNum1;
            StrucNum1.x = 75;
            StrucNum1.y = 95;
            Console.WriteLine("Assign in Structure:   x:{0},    y:{1}\n\n", StrucNum2.x, StrucNum2.y);
        }
    }
    /*
    5 - Escriba un programa en C # Sharp para mostrar qué sucede cuando una estructura y una instancia de clase se pasan a un método.
    Solución:
    */
    class newClass
    {
        public int n;
    }
    struct newStruct
    {
        public int n;
    }
    class strucExer5
    {
        public static void trackStruct(newStruct st)
        {
            st.n = 8;
        }
        public static void tracClass(newClass cl)
        {
            cl.n = 8;
        }
        public static void MainST5()
        {
            Console.Write("\n\nWhen a struct and a class instance is passed to a method :\n");
            Console.Write("--------------------------------------------------------------\n");
            newStruct ns = new newStruct();
            newClass nc = new newClass();
            ns.n = 5;
            nc.n = 5;
            //value of the struct field did not changed by passing its instance		
            //because a copy of the struct was passed to the trackStruct method		
            trackStruct(ns);
            //value of the class field changed by passing its instance
            //because a reference to the class was passed to the tracClass method		
            tracClass(nc);
            Console.WriteLine("\nns.n = {0}", ns.n);
            Console.WriteLine("nc.n = {0}\n", nc.n);
        }
    }
    /*
    6 - Escriba un programa en C # Sharp para declarar una estructura con una propiedad, un método y un campo privado.
    Solución:
    */
    struct newStrEG
    {
        private int num;
        public int n
        {
            get
            {
                return num;
            }
            set
            {
                if (value < 50)
                    num = value;
            }
        }
        public void clsMethod()
        {
            Console.WriteLine("\nThe stored value is: {0}\n", num);
        }
    }
    class strucExer6
    {
        public static void MainST6()
        {
            Console.Write("\n\nDeclares a struct with a property, a method, and a private field :\n");
            Console.Write("----------------------------------------------------------------------\n");
            newStrEG myInstance = new newStrEG();
            myInstance.n = 15;
            myInstance.clsMethod();
        }
    }
    /*
    7 - Escriba un programa en C # Sharp para demostrar la inicialización de la estructura utilizando constructores predeterminados y parametrizados.
    Solución:
    */
    public struct newStrE7
    {
        public int m, n;
        public newStrE7(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }
    }
    // Declare and initialize struct objects.
    class strucExer7
    {
        static void MainST7()
        {
            Console.Write("\n\nStruct declares using default and parameterized constructors :\n");
            Console.Write("-----------------------------------------------------------------\n");
            newStrE7 myPoint1 = new newStrE7();
            newStrE7 myPoint2 = new newStrE7(25, 25);


            Console.Write("\nnewStruct 1: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint1.m, myPoint1.n);

            Console.Write("newStruct 2: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint2.m, myPoint2.n);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
    /*
    8 - Escriba un programa en C # Sharp para demostrar la inicialización de la estructura sin usar el nuevo operador.
    Solución:
    */
    public struct nStr8
    {
        public int m, n;
        public nStr8(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }
    }
    // Declare and initialize struct objects.
    class strucExer8
    {
        static void MainST8()
        {
            Console.Write("\n\nStruct initialization without using the new operator :\n");
            Console.Write("----------------------------------------------------------\n");

            nStr8 myPoint;

            myPoint.m = 30;
            myPoint.n = 40;


            Console.Write("\nnStr8 : ");
            Console.WriteLine("m = {0nStr8}, n = {1}", myPoint.m, myPoint.n);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
    /*
    9 - Escriba un programa en C # Sharp para insertar la información de dos libros.
    Solución:
    */
    struct book
    {
        public string title;
        public string author;
    }
    public class strucExer9
    {
        public static void MainST9()
        {
            int nobook = 1000;
            book[] books = new book[nobook];
            int i, j, n = 1, k = 1;
            Console.Write("\n\nInsert the information of two books :\n");
            Console.Write("-----------------------------------------\n");
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book {0} :", k);

                Console.Write("Input name of the book : ");
                books[j].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }

        }
    }
    /*
    10 - Escriba un programa en C # Sharp para implementar un método que devuelva una estructura que incluya llamar al método y usar su valor.
    Solución:
    */
    public struct sampStru
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Square
    {
        sampStru ln;
        sampStru ht;

        public sampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }
        public sampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquare()
        {
            sampStru rct = new sampStru();

            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }
        public sampStru sqrLength()
        {
            sampStru rct = new sampStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    public class strucExer10
    {
        static void MainST10()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            var Sqre = new Square();
            Sqre.newSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}