using System;
using System.IO;
using System.Text;
#pragma warning disable 1591

namespace src
{
    /*1 - Escriba un programa en C # Sharp para crear un archivo en blanco en el disco recientemente.
    Solución:
    */
    class filexercise1
    {
        public static void MainFH1()
        {
            string fileName = @"mytest.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                // Create the file.
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    2 - Escriba un programa en C # Sharp para eliminar un archivo del disco.
    Solución:
    */
    class filexercise2
    {
        public static void MainFH2()
        {
            string fileName = @"mytest.txt";
            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName);
            }
            else
            {
                Console.WriteLine(" File does not exist");
                Console.ReadKey();
            }
        }
    }
    /*
    3 - Escriba un programa en C # Sharp para crear un archivo en blanco en el disco si ya existe el mismo archivo.
    Solución:
    */
    class filexercise3
    {
        public static void MainFH3()
        {
            string fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file in the disk if it is exists:\n");
                Console.Write("-----------------------------------------------\n");
                // Create the file.
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    4 - Escriba un programa en C # Sharp para crear un archivo y agregar texto.
    Solución:
    */
    class filexercise4
    {
        public static void MainFH4()
        {
            string fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file with content in the disk :\n");
                Console.Write("---------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                    Console.WriteLine(" A file created with content name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    5 – Escriba un programa en C # Sharp para crear un archivo con texto y leer el archivo.
    Solución:
    */
    class filexercise5
    {
        public static void MainFH5()
        {
            string fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file with text and read the file  :\n");
                Console.Write("-------------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    6 – Escriba un programa en C # Sharp para crear un archivo y escriba una matriz de cadenas en el archivo.
    Solución:
    */
    class filexercise6
    {
        static void MainFH6()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;

            Console.Write("\n\n Create a file and write an array of strings  :\n");
            Console.Write("---------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\n The content of the file is  :\n", n);
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", s);
                }
                Console.WriteLine();
            }
        }
    }
    /*
    7 – Escriba un programa en C # Sharp para crear y escribir una línea de texto en un archivo que no contenga una cadena dada en una línea.
    Solución:
    */
    class filexercise7
    {
        static void MainFH7()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            string str;

            int n, i;

            Console.Write("\n\n Create and write some line of text which does not contain a given string in a line  :\n");
            Console.Write("------------------------------------------------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input the string to ignore the line : ");
            str = Console.ReadLine();
            Console.Write(" Input number of lines to write in the file  : ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];

            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"mytest.txt"))
            {
                foreach (string line in ArrLines)
                {
                    if (!line.Contains(str)) // write the line to the file If it doesn't contain the string in str
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\n The line has ignored which contain the string '{0}'. \n", str);
                Console.Write("\n The content of the file is  :\n", n);
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", s);
                }
                Console.WriteLine();
            }
        }
    }
    /*
    8 - Escriba un programa en C # Sharp para agregar texto a un archivo existente.
    Solución:
    */
    class filexercise8
    {
        public static void MainFH8()
        {
            string fileName = @"mytest.txt";
            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Append some text to an existing file  :\n");
                Console.Write("--------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"mytest.txt", true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file after appending the text : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }

            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    9 - Escriba un programa en C # Sharp para crear y copiar el archivo a otro nombre y mostrar el contenido.
    Solución:
    */
    public class filexercise9
    {
        static void MainFH9()
        {
            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";

            // Delete the file if it exists.
            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            Console.Write("\n\n Create a file and copy the file  :\n");
            Console.Write("---------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }

            /*      string sourcefolder = "path";  // you can mention the path of source folder
                    string targetfolder =  "path"; // you can mention the path of target folder 
                    string sourceFile = System.IO.Path.Combine(sourcefolder, sfileName); // combine the source file with path
                    string targetFile = System.IO.Path.Combine(targetfolder, tfileName);   // combine the target file with path */

            /*		Create a new target folder if not exists
                    if (!System.IO.Directory.Exists(targetfolder))
                    {
                        System.IO.Directory.CreateDirectory(targetfolder);
                    }
                    System.IO.File.Copy(sourceFile, destFile, true); // overwrite the target file if it already exists. */
            System.IO.File.Copy(sfileName, tfileName, true);
            Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory.", sfileName, tfileName);

            using (StreamReader sr = File.OpenText(tfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    /*
    10 – Escriba un programa en C # Sharp para crear un archivo y mover el archivo al mismo directorio con otro nombre.
    Solución:
    */
    public class filexercise10
    {
        static void MainFH10()
        {

            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";

            /*      string sourcefolder = "path";  // you can mention the path of source folder
                    string targetfolder = "path"; // you can mention the path of target folder 
                    string sourceFile = System.IO.Path.Combine(sourcefolder, sfileName); // combine the source file with path
                    string targetFile = System.IO.Path.Combine(targetfolder, tfileName);   // combine the target file with path */

            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
            }
            Console.Write("\n\n Create a file and move the file in same folder to another name  :\n");
            Console.Write("----------------------------------------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            System.IO.File.Move(sfileName, tfileName); // move a file to another name in same location:
            Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", sfileName, tfileName);

            using (StreamReader sr = File.OpenText(tfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    /*
    11 - Escriba un programa en C # Sharp para leer la primera línea de un archivo.
    Solución:
    */
    class filexercise11
    {
        public static void MainFH11()
        {
            string fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Read the first line from a file  :\n");
                Console.Write("---------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" test line 1");
                    fileStr.WriteLine(" test line 2");
                    fileStr.WriteLine(" Test line 3");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }

                Console.Write("\n The content of the first line of the file is :\n");
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.Write(lines[0]);
                }
                Console.WriteLine();
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
    /*
    12 - Escriba un programa en C # Sharp para crear y leer la última línea de un archivo.
    Solución:
    */
    class filexercise12
    {
        static void MainFH12()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;

            Console.Write("\n\n Create and read the last line of a file  :\n");
            Console.Write("-----------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);
            Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                Console.WriteLine(" {0}", lines[n - 1]);
            }
            Console.WriteLine();
        }
    }
    /*
    13 - Escriba un programa en C # Sharp para leer una línea específica de un archivo.
    Solución:
    */
    class filexercise13
    {
        static void MainFH13()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i, l;

            Console.Write("\n\n Read a specific line from a file  :\n");
            Console.Write("----------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);

            Console.Write("\n Input which line you want to display  :");
            l = Convert.ToInt32(Console.ReadLine());
            if (l >= 1 && l <= n)
            {
                Console.Write("\n The content of the line {0} of the file {1} is : \n", l, fileName);
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine(" {0}", lines[l - 1]);
                }
            }
            else
            {
                Console.WriteLine(" Please input the correct line no.");
            }

            Console.WriteLine();
        }
    }
    /*
    14 - Escriba un programa en C # Sharp para crear y leer el último n número de líneas de un archivo.
    Solución:
    */
    class filexercise14
    {
        static void MainFH14()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i, l, m = 1;

            Console.Write("\n\n Read last n number of lines from a file  :\n");
            Console.Write("-----------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);

            Console.Write("\n Input last how many numbers of lines you want to display  :");
            l = Convert.ToInt32(Console.ReadLine());
            m = l;
            if (l >= 1 && l <= n)
            {
                Console.Write("\n The content of the last {0} lines of the file {1} is : \n", l, fileName);
                if (File.Exists(fileName))
                {
                    for (i = n - l; i < n; i++)
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        Console.Write(" The last no {0} line is : {1} \n", m, lines[i]);
                        m--;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Please input the correct line no.");
            }

            Console.WriteLine();
        }
    }
    /*
    15 - Escriba un programa en C # Sharp para contar el número de líneas en un archivo.
    Solución:
    */
    class filexercise15
    {
        public static void MainFH15()
        {
            string fileName = @"mytest.txt";
            int count;

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Count the number of lines in a file :\n");
                Console.Write("------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" test line 1");
                    fileStr.WriteLine(" test line 2");
                    fileStr.WriteLine(" Test line 3");
                    fileStr.WriteLine(" test line 4");
                    fileStr.WriteLine(" test line 5");
                    fileStr.WriteLine(" Test line 6");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    count = 0;
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine("");
                }
                Console.Write(" The number of lines in  the file {0} is : {1} \n\n", fileName, count);
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}