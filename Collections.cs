using System;
using System.Collections.Generic;
//using System.Linq;

#pragma warning disable 1591
namespace src
{
    /*
    1. Crear una lista de cadenas y luego recorrerla en iteración mediante una instrucción foreach
    */
    // Create a list of strings.
    class ExerColl1
    {
        public static void MainColl1()
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye
        }

    }

    /*
    2. 
    */
    class ExerColl2
    {
        public void MainColl2()
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye
        }
    }

    /*
    3. Recorrer en iteración los elementos de una colección mediante for en lugar de foreach.
    */
    class ExerColl3
    {
        public void MainColl3()
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            for (var index = 0; index < salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }
            // Output: chinook coho pink sockeye
        }

    }

    /*
    4. Quitar un elemento de una colección dada
    */
    class ExerColl4
    {
        public static void MainColl4()
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("coho");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook pink sockeye
        }
    }

    /*
    5. Quitar elementos de una lista generica
    */
    public class ExerColl5
    {
        public static void MainColl5()
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Remove odd numbers.
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    // Remove the element by specifying
                    // the zero-based index in the list.
                    numbers.RemoveAt(index);
                }
            }

            // Iterate through the list.
            // A lambda expression is placed in the ForEach method
            // of the List(T) object.
            numbers.ForEach(
                number => Console.Write(number + " "));
            // Output: 0 2 4 6 8
        }
    }

    /*
    6. Crear una colección Generica de definida por el usuario
    */
    public class ExerColl6
    {
        public int MainColl6()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25},
                new Galaxy() { Name="Milky Way", MegaLightYears=0},
                new Galaxy() { Name="Andromeda", MegaLightYears=3}
            };
            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            }
            // Output:
            //  Tadpole  400
            //  Pinwheel  25
            //  Milky Way  0
            //  Andromeda  3
            return 0;
        }

        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}