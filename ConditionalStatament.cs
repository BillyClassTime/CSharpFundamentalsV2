using System;
#pragma warning disable 1591
namespace Name
{
    /*
  1 - Escriba un programa C # Sharp para aceptar dos enteros y verifique si son iguales o no.
  Solución:
  */
    public class ExerCon1
    {
        public static void MainCon1()
        {
            int int1, int2;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }
    }
    /*
    2 - Escriba un programa en C para verificar si un número dado es par o impar.
    Solución:
    */
    public class ExerCon2
    {
        public static void MainCon2()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        }
    }
    /*
    3 – Escriba un programa C # Sharp para verificar si un número dado es positivo o negativo.
    Solución:
    */
    public class ExerCon3
    {
        public static void MainCon3()
        {
            int num;
            Console.Write("\n\n");
            Console.Write("Check whether a number is positive or negative:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine("{0} is a positive number.\n", num);
            else
                Console.WriteLine("{0} is a negative number. \n", num);
        }
    }
    /*
    4 - Escriba un programa C # Sharp para determinar si un año dado es bisiesto o no.
    Solución:
    */
    public class ExerCon4
    {
        public static void MainCon4()
        {
            int chk_year;
            Console.Write("\n\n");
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
        }
    }
    /*
    5 - Escriba un programa C # Sharp para leer la edad de un candidato y determinar si es elegible para emitir su propio voto.
    Solución:
    */
    public class ExerCon5
    {
        public static void MainCon5()
        {
            int vote_age;
            Console.Write("\n\n");
            Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        }
    }
    /*
    6 - Escriba un programa C # Sharp para leer el valor de un número entero m y muestre que el valor de n es 1 cuando m es mayor que 0, 0 cuando m es 0 y -1 cuando m es menor que 0.
    Solución:
    */
    public class ExerCon6
    {
        public static void MainCon6()
        {
            int m, n;
            Console.Write("\n\n");
            Console.Write("Display the value of n is 1,0 and -1 for the value of er m:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  value of m :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.Write("The value of m = {0} \n", m);
            Console.Write("The value of n = {0} \n\n", n);
        }
    }
    /*
    7 - Escriba un programa C # Sharp para aceptar la altura de una persona en centímetros y categorice a la persona según su altura.
    Solución:
    */
    public class ExerCon7
    {
        public static void MainCon7()
        {
            float PerHeight;
            Console.Write("\n\n");
            Console.Write("Accept the height of a person in centimeter and categorize them:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the height of the person (in centimetres):");
            PerHeight = Convert.ToInt32(Console.ReadLine());

            if (PerHeight < 150.0)
                Console.Write("The person is Dwarf. \n\n");
            else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                Console.Write("The person is  average heighted. \n\n");
            else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                Console.Write("The person is taller. \n\n");
            else
                Console.Write("Abnormal height.\n\n");
        }
    }
    /*
    8 - Escribe un programa en C para encontrar el mayor de tres números.
    Solución:
    */
    public class ExerCon8
    {
        public static void MainCon8()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }

    /*
    9 - Escriba un programa en C para aceptar un punto de coordenadas en un sistema de coordenadas XY y determine en qué cuadrante se encuentra el punto de coordenadas.
    Solución:
    */
    public class ExerCon9
    {
        public static void MainCon9()
        {
            int co1, co2;

            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value for X coordinate :");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            co2 = Convert.ToInt32(Console.ReadLine());


            if (co1 > 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", co1, co2);
            else if (co1 > 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", co1, co2);
            else if (co1 == 0 && co2 == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", co1, co2);

        }
    }
    /*
    10 – Escriba un programa C para encontrar la elegibilidad de admisión a un curso profesional basado en los siguientes criterios:
    Marks in Maths >=65
    Marks in Phy >=55
    Marks in Chem>=50
    Total in all three subject >=180
    or
    Total in Math and Subjects >=140
    Solución:
    */
    public class ExerCon10
    {
        public static void MainCon10()
        {
            int p, c, m;

            Console.Write("\n\n");
            Console.Write("Find eligibility for admission :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Eligibility Criteria :\n");
            Console.Write("Marks in Maths >=65\n");
            Console.Write("and Marks in Phy >=55\n");
            Console.Write("and Marks in Chem>=50\n");
            Console.Write("and Total in all three subject >=180\n");
            Console.Write("or Total in Maths and Physics >=140\n");
            Console.Write("-------------------------------------\n");


            Console.Write("Input the marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
            Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");
        }
    }
    /*
    11 - Escriba un programa C # Sharp para calcular la raíz de la ecuación cuadrática.
    Solución:
    */
    public class ExerCon11
    {
        public static void MainCon11()
        {
            int a, b, c;

            double d, x1, x2;
            Console.Write("\n\n");
            Console.Write("Calculate root of Quadratic Equation :\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root root2= {0}\n", x2);
            }
            else
                Console.Write("Root are imeainary;\nNo Solution. \n\n");
        }
    }
    /*
    12 - Escriba un programa C # Sharp para leer el numero de inscripción, el nombre y las calificaciones de tres materias y calcule el total, el porcentaje y la división.
    Solución:
    */
    public class ExerCon12
    {
        public static void MainCon12(string[] args)
        {
            double rl, phy, che, ca, total;
            double per;
            string nm, div;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
            if (per < 60 && per >= 48)
                div = "Second";
            else
                if (per < 48 && per >= 36)
                div = "Pass";
            else
                div = "Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }
    }
    /*
    13 – Escriba un programa C # Sharp para leer la temperatura en centígrados y muestre el mensaje adecuado de acuerdo con la temperatura.
    Temp < 0 then Freezing weather
    Temp 0-10 then Very Cold weather
    Temp 10-20 then Cold weather
    Temp 20-30 then Normal in Temp
    Temp 30-40 then Its Hot
    Temp >=40 then Its Very Hot
    Solución:
    */
    public class ExerCon13
    {
        public static void MainCon13()
        {
            int tmp;
            Console.Write("\n\n");
            Console.Write("Accept a temperature in centigrade and display a suitable message:\n");
            Console.Write("--------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input days temperature : ");
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Freezing weather.\n");
            else if (tmp < 10)
                Console.Write("Very cold weather.\n");
            else if (tmp < 20)
                Console.Write("Cold weather.\n");
            else if (tmp < 30)
                Console.Write("Normal in temp.\n");
            else if (tmp < 40)
                Console.Write("Its Hot.\n");
            else
                Console.Write("Its very hot.\n");

        }
    }
    /*
    14 - Escriba un programa C # Sharp para verificar si un triángulo es equilátero, isósceles o escaleno.
    Solución:
    */
    public class ExerCon14
    {
        public static void MainCon14()
        {
            int sidea, sideb, sidec;
            Console.Write("\n\n");
            Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Input side 1 of triangle: ");
            sidea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            sideb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            sidec = Convert.ToInt32(Console.ReadLine());

            if (sidea == sideb && sideb == sidec)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sidea == sideb || sidea == sidec || sideb == sidec)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }
    }
    /* 
    15 – Escriba un programa C # Sharp para verificar si se puede formar un triángulo con el valor dado para los ángulos.
    Solución:
    */
    public class ExerCon15
    {
        public static void MainCon15()
        {
            int anga, angb, angc, sum; //are three angles of a triangle  
            Console.Write("\n\n");
            Console.Write("Check whether a triangle can be formed by given value:\n");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input angle1 of triangle: ");
            anga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle: ");
            angb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
            angc = Convert.ToInt32(Console.ReadLine());

            /* Calculate the sum of all angles of triangle */
            sum = anga + angb + angc;

            /* Check whether sum=180 then its a valid triangle otherwise not */
            if (sum == 180)
            {
                Console.Write("The triangle is valid.\n");
            }
            else
            {
                Console.Write("The triangle is not valid.\n");
            }
        }

    }
    /*
    16 - Escriba un programa C # Sharp para verificar si un alfabeto es vocal o consonante.
    Solución:
    */
    public class ExerCon16
    {
        static void MainCon16(string[] args)
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
/*
17 – Escriba un programa C # Sharp para calcular ganancias y pérdidas en una transacción.
Solución:
*/
public class ExerCon17
{
    public static void MainCon17()
    {
        int cprice, sprice, plamt;

        Console.Write("\n\n");
        Console.Write("Calculate profit and loss:\n");
        Console.Write("----------------------------");
        Console.Write("\n\n");


        Console.Write("Input Cost Price: ");
        cprice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Selling Price: ");
        sprice = Convert.ToInt32(Console.ReadLine());

        if (sprice > cprice)
        {
            plamt = sprice - cprice;
            Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
        }
        else if (cprice > sprice)
        {
            plamt = cprice - sprice;
            Console.Write("\nYou got a loss of amount : {0}\n", plamt);
        }
        else
        {
            Console.Write("\nYou are running in no profit no loss condition.\n");
        }
    }
}
/*
18 - Escriba un programa en C # Sharp para calcular e imprimir la factura de electricidad de un cliente determinado. La identificación del cliente, el nombre y la unidad consumidos por el usuario deben tomarse del teclado y mostrar el monto total a pagar al cliente. Los cargos son los siguientes:
Unit	Charge/unit
upto 199	@1.20
200 and above but less than 400	@1.50
400 and above but less than 600	@1.80
600 and above	@2.00
Solución:
*/
public class ExerCon18
{
    static void MainCon18(string[] args)
    {
        int custid, conu;
        double chg, surchg = 0, gramt, netamt;
        string connm;

        Console.Write("\n\n");
        Console.Write("Calculate Electricity Bill:\n");
        Console.Write("----------------------------");
        Console.Write("\n\n");

        Console.Write("Input Customer ID :");
        custid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the name of the customer :");
        connm = Console.ReadLine();
        Console.Write("Input the unit consumed by the customer : ");
        conu = Convert.ToInt32(Console.ReadLine());
        if (conu < 200)
            chg = 1.20;
        else if (conu >= 200 && conu < 400)
            chg = 1.50;
        else if (conu >= 400 && conu < 600)
            chg = 1.80;
        else
            chg = 2.00;
        gramt = conu * chg;
        if (gramt > 300)
            surchg = gramt * 15 / 100.0;
        netamt = gramt + surchg;
        if (netamt < 100)
            netamt = 100;
        Console.Write("\nElectricity Bill\n");
        Console.Write("Customer IDNO                       :{0}\n", custid);
        Console.Write("Customer Name                       :{0}\n", connm);
        Console.Write("unit Consumed                       :{0}\n", conu);
        Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
        Console.Write("Surchage Amount                     :{0}\n", surchg);
        Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);
    }
}
/*
19 - Escriba un programa en C # Sharp para aceptar una calificación y mostrar la descripción equivalente:
Grade	Description
E	Excellent
V	Very Good
G	Good
A	Average
F	Fail
Solución:
*/
public class ExerCon19
{
    static void MainCon19(string[] args)
    {
        string notes;
        char grd;
        Console.Write("\n\n");
        Console.Write("Accept a grade and display equivalent description:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the grade :");
        grd = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grd)
        {
            case 'E':
                notes = " Excellent";
                break;
            case 'V':
                notes = " Very Good";
                break;
            case 'G':
                notes = " Good ";
                break;
            case 'A':
                notes = " Average";
                break;
            case 'F':
                notes = " Fails";
                break;
            default:
                notes = "Invalid Grade Found.";
                break;
        }
        Console.Write("You have chosen  : {0}\n", notes);
    }
}
/*
20 – Escriba un programa en C # Sharp para leer cualquier número de día en entero y mostrar el nombre del día en la palabra.
Solución:
*/
public class ExerCon20
{
    public static void MainCon20()
    {
        int dayno;

        Console.Write("\n\n");
        Console.Write("Accept day number and display its equivalent day name in word:\n");
        Console.Write("----------------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input Day No : ");
        dayno = Convert.ToInt32(Console.ReadLine());

        switch (dayno)
        {
            case 1:
                Console.Write("Monday \n");
                break;
            case 2:
                Console.Write("Tuesday \n");
                break;
            case 3:
                Console.Write("Wednesday \n");
                break;
            case 4:
                Console.Write("Thursday \n");
                break;
            case 5:
                Console.Write("Friday \n");
                break;
            case 6:
                Console.Write("Saturday \n");
                break;
            case 7:
                Console.Write("Sunday  \n");
                break;
            default:
                Console.Write("Invalid day number. \nPlease try again ....\n");
                break;
        }
    }
}
/*
21 - Escriba un programa en C # Sharp para leer cualquier dígito, mostrar en la palabra.
Solución:
*/
public class ExerCon21
{
    public static void MainCon21()
    {
        int cdigit;

        Console.Write("\n\n");
        Console.Write("Accept digit and display in word:\n");
        Console.Write("-----------------------------------");
        Console.Write("\n\n");


        Console.Write("Input Digit(0-9) : ");
        cdigit = Convert.ToInt32(Console.ReadLine());

        switch (cdigit)
        {
            case 0:
                Console.Write("Zero\n");
                break;

            case 1:
                Console.Write("one\n");
                break;
            case 2:
                Console.Write("Two\n");
                break;
            case 3:
                Console.Write("Three\n");
                break;
            case 4:
                Console.Write("Four\n");
                break;
            case 5:
                Console.Write("Five\n");
                break;
            case 6:
                Console.Write("Six\n");
                break;
            case 7:
                Console.Write("Seven\n");
                break;
            case 8:
                Console.Write("Eight\n");
                break;
            case 9:
                Console.Write("Nine\n");
                break;
            default:
                Console.Write("invalid digit. \nPlease try again ....\n");
                break;
        }
    }
}
/*
22 – Escriba un programa en C # Sharp para leer cualquier número de mes en entero y mostrar el nombre del mes en la palabra.
Solución:
*/
public class ExerCon22
{
    public static void MainCon22()
    {
        int monno;


        Console.Write("\n\n");
        Console.Write("Read month number and display month name:\n");
        Console.Write("-------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input Month No : ");
        monno = Convert.ToInt32(Console.ReadLine());

        switch (monno)
        {
            case 1:
                Console.Write("January\n");
                break;
            case 2:
                Console.Write("February\n");
                break;
            case 3:
                Console.Write("March\n");
                break;
            case 4:
                Console.Write("April\n");
                break;
            case 5:
                Console.Write("May\n");
                break;
            case 6:
                Console.Write("June\n");
                break;
            case 7:
                Console.Write("July\n");
                break;
            case 8:
                Console.Write("August\n");
                break;
            case 9:
                Console.Write("September\n");
                break;
            case 10:
                Console.Write("October\n");
                break;
            case 11:
                Console.Write("November\n");
                break;
            case 12:
                Console.Write("December\n");
                break;
            default:
                Console.Write("invalid Month number. \nPlease try again ....\n");
                break;
        }
    }
}
/*
23 - Escriba un programa en C # Sharp para leer cualquier número de mes en entero y mostrar la cantidad de días para este mes.
Solución:
*/
public class ExerCon23
{
    static void MainCon23(string[] args)
    {
        int monno;

        Console.Write("\n\n");
        Console.Write("Read month number and display number of days for that month:\n");
        Console.Write("--------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input Month No : ");
        monno = Convert.ToInt32(Console.ReadLine());
        switch (monno)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.Write("Month  have 31 days. \n");
                break;
            case 2:
                Console.Write("The 2nd month is a February and have 28 days. \n");
                Console.Write("in leap year The February month  Have 29 days.\n");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.Write("Month have 30 days. \n");
                break;
            default:
                Console.Write("invalid Month number.\nPlease try again ....\n");
                break;
        }
    }
}
/*
24 – Escriba un programa en C # Sharp, que es un programa guiado por menús para calcular el área de las diversas formas geométricas.
Solución:
*/
public class ExerCon24
{
    public static void MainCon24()
    {
        int choice, r, l, w, b, h;
        double area = 0;

        Console.Write("\n\n");
        Console.Write("A menu driven program to compute the area of various geometrical shape:\n");
        Console.Write("-------------------------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input 1 for area of circle\n");
        Console.Write("Input 2 for area of rectangle\n");
        Console.Write("Input 3 for area of triangle\n");
        Console.Write("Input your choice : ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Input radius of the circle : ");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3.14 * r * r;
                break;
            case 2:
                Console.Write("Input length  of the rectangle : ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  width of the rectangle : ");
                w = Convert.ToInt32(Console.ReadLine());
                area = l * w;
                break;
            case 3:
                Console.Write("Input the base of the triangle :");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the hight of the triangle :");
                h = Convert.ToInt32(Console.ReadLine());
                area = .5 * b * h;
                break;
        }
        Console.Write("The area is : {0}\n", area);
    }
}
/*
25 – Escriba un programa en C # Sharp, que es un programa guiado por menús para realizar un cálculo simple.
Solución:
*/
public class ExerCon25
{
    public static void MainCon25()
    {
        int num1, num2, opt;
        Console.Write("\n\n");
        Console.Write("A menu driven program for a simple calculator:\n");
        Console.Write("------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Enter the first Integer :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second Integer :");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.Write("\nHere are the options :\n");
        Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
        Console.Write("\nInput your choice :");
        opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                break;

            case 2:
                Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                break;

            case 3:
                Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                break;

            case 4:
                if (num2 == 0)
                {
                    Console.Write("The second integer is zero. Devide by zero.\n");
                }
                else
                {
                    Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                }
                break;

            case 5:
                break;

            default:
                Console.Write("Input correct option\n");
                break;
        }
    }
}