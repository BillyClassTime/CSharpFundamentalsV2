
using System;
using System.Globalization;
#pragma warning disable 1591
namespace src
{
    /*
    1 - Escriba un programa C # Sharp para extraer la propiedad Date y mostrar el valor DateTime en la salida formateada.
    Solución:
    */
    public class ExamDT1
    {
        public static void MainDT1()
        {
            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            Console.WriteLine("Complete date: " + dt1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = dt1.Date;

            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }
    }

    /*
    2 - Escriba un programa C # Sharp para mostrar las propiedades del día (año, mes, día, hora, minuto, segundo, milisegundo, etc.)
    Solución:
    */

    public class ExamDT2
    {
        public static void MainDT2()
        {
            System.DateTime moment = new System.DateTime(2016, 8, 16, 3, 57, 32, 11);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);

        }
    }
    /*
    3 - Escriba un programa C # Sharp para obtener el día de la semana para una fecha específica.
    Solución
    */
    public class ExamDT3
    {
        public static void MainDT3()
        {
            // Assume the current system  is en-US.
            DateTime dt = new DateTime(2016, 7, 11);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
        }
    }
    /*
    4 - Escriba un programa C # Sharp para mostrar la cantidad de días del año entre dos años específicos.
    Solución:
    */
    public class ExamDT4
    {
        public static void MainDT4()
        {
            DateTime dec31 = new DateTime(2000, 12, 31);
            for (int ctr = 0; ctr <= 20; ctr++)
            {
                DateTime dateToDisplay = dec31.AddYears(ctr);
                Console.WriteLine("{0:d}: day {1} of {2} {3}", dateToDisplay,
                                  dateToDisplay.DayOfYear,
                                  dateToDisplay.Year,
                                  DateTime.IsLeapYear(dateToDisplay.Year) ?
                                                      "(Leap Year)" : "");
            }

        }
    }
    /*
    5 - Escriba un programa C # Sharp para obtener un valor de DateTime que represente la fecha y hora actuales en la computadora local.
    Solución:
    */
    public class ExamDT5
    {
        public static void MainDT5()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-IE", "en-ZA", "fr-CA",
                                "de-CH", "ro-RO" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }
        }
    }
    /*
    6 - Escriba un programa C # Sharp para mostrar el número de tics que han transcurrido desde principios del siglo XXI y para crear una instancia de un objeto TimeSpan utilizando la propiedad Ticks.
    Solución:
    */
    public class ExamDT6
    {
        public static void MainDT6()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-JM", "en-NZ", "fr-BE",
                                "de-CH", "nl-NL" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }
        }
    }
    /*
    7 - Escriba un programa C # Sharp para obtener la hora del día a partir de una matriz dada de valores de fecha y hora.
    Solución:
    */
    public class ExamDT7
    {
        public static void MainDT7()
        {
            DateTime[] dates = { DateTime.Now,
                           new DateTime(2016, 8, 16, 9, 28, 0),
                           new DateTime(2011, 5, 28, 10, 35, 0),
                           new DateTime(1979, 12, 25, 14, 30, 0) };
            foreach (var date in dates)
            {
                Console.WriteLine("Day: {0:d} Time: {1:g}", date.Date, date.TimeOfDay);
                Console.WriteLine("Day: {0:d} Time: {0:t}\n", date);
            }
        }
    }
    /*
    8 - Escriba un programa C # Sharp para recuperar la fecha actual.
    Solución:
    */
    public class ExamDT8
    {
        public static void MainDT8()
        {
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("General format " + thisDay.ToString());
            Console.WriteLine("Display the date in a variety of formats: ");
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(thisDay.ToString("g"));
        }
    }
    /*
    9 - Escriba un programa C # Sharp para calcular qué día de la semana son 40 días a partir de este momento.
    Solución:
    */
    public class ExamDT9
    {
        public static void MainDT9()
        {

            System.DateTime today = System.DateTime.Now;
            System.Console.WriteLine("Today = " + System.DateTime.Now);
            System.TimeSpan duration = new System.TimeSpan(40, 0, 0, 0);
            System.DateTime answer = today.Add(duration);
            System.Console.WriteLine("{0:dddd}", answer);
        }
    }
    /*
    10 - Escriba el programa C # Sharp para determinar el día de la semana 40 días después de la fecha actual.
    Solución:
    */
    public class ExamDT10
    {
        public static void MainDT10()
        {

            // Calculate what day of the week is 40 days from this instant.
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(40);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("40 days from today: {0:dddd}", answer);
        }
    }
    /*
    11 - Escriba el programa C # Sharp para agregar una cantidad de valores enteros y fraccionarios a una fecha y hora.
    Solución:
    */
    public class ExamDT11
    {
        public static void MainDT11()
        {
            double[] hours = {.08333, .16667, .25, .33333, .5, .66667, 1, 2,
                        29, 30, 31, 90, 365};
            DateTime dateValue = new DateTime(2016, 8, 16, 12, 0, 0);

            foreach (double hour in hours)
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour,
                                  dateValue.AddHours(hour));

        }
    }
    /*
    12 - Escriba C # Sharp Program para agregar un milisegundo y 2.5 milisegundos a un valor de fecha dado y muestre cada nuevo valor y la diferencia entre este y el valor original.
    Solución:
    */
    public class ExamDT12
    {
        public static void MainDT12()
        {
            string dateFormat = "MM/dd/yyyy hh:mm:ss.fffffff";
            DateTime date1 = new DateTime(2016, 8, 16, 16, 0, 0);
            Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
                          date1.ToString(dateFormat), date1.Ticks);

            DateTime date2 = date1.AddMilliseconds(1);
            Console.WriteLine("Second date:   {0} ({1:N0} ticks)",
                          date2.ToString(dateFormat), date2.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)\n",
                          date2 - date1, date2.Ticks - date1.Ticks);

            DateTime date3 = date1.AddMilliseconds(2.5);
            Console.WriteLine("Third date:    {0} ({1:N0} ticks)",
                          date3.ToString(dateFormat), date3.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)",
                          date3 - date1, date3.Ticks - date1.Ticks);

        }
    }
    /*
    13 - Escriba C # Sharp Program para agregar 30 segundos y la cantidad de segundos en un día a un valor DateTime.
    Solución:
    */
    public class ExamDT13
    {
        public static void MainDT13()
        {
            string dateFormat = "MM/dd/yyyy hh:mm:ss";
            DateTime date1 = new DateTime(2016, 8, 15, 16, 0, 0);
            Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
                              date1.ToString(dateFormat), date1.Ticks);

            DateTime date2 = date1.AddSeconds(30);
            Console.WriteLine("Second date:   {0} ({1:N0} ticks)",
                              date2.ToString(dateFormat), date2.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)\n",
                              date2 - date1, date2.Ticks - date1.Ticks);

            // Add 1 day's worth of seconds (60 secs. * 60 mins * 24 hrs.
            DateTime date3 = date1.AddSeconds(60 * 60 * 24);
            Console.WriteLine("Third date:    {0} ({1:N0} ticks)",
                              date3.ToString(dateFormat), date3.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)",
                              date3 - date1, date3.Ticks - date1.Ticks);
        }
    }
    /*
    14 - Escriba un programa C # Sharp para agregar un número específico de meses entre cero y quince meses hasta el último día de agosto de 2016.
    Solución:
    */
    public class ExamDT14
    {
        public static void MainDT14()
        {
            var dat = new DateTime(2016, 8, 31);
            for (int ctr = 0; ctr <= 15; ctr++)
                Console.WriteLine(dat.AddMonths(ctr).ToString("d"));

        }
    }
    /*
    15 - Escriba un programa C # Sharp para mostrar la fecha de quince años pasados y futuros de una fecha específica.
    Solución:
    */
    public class ExamDT15
    {
        public static void MainD15()
        {
            DateTime baseDate = new DateTime(2016, 2, 29);
            Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

            // Show dates of previous fifteen years.
            for (int ctr = -1; ctr >= -15; ctr--)
                Console.WriteLine("{0,2} year(s) ago:        {1:d}",
                                  Math.Abs(ctr), baseDate.AddYears(ctr));
            Console.WriteLine();

            // Show dates of next fifteen years.
            for (int ctr = 1; ctr <= 15; ctr++)
                Console.WriteLine("{0,2} year(s) from now:   {1:d}",
                                  ctr, baseDate.AddYears(ctr));
        }
    }
    /*
    16 - Escriba un programa C # Sharp que compare dos fechas.
    Solución:
    */
    public class ExamDT16
    {
        public static void MainDT16()
        {
            DateTime date1 = new DateTime(2016, 8, 1, 0, 0, 0);
            DateTime date2 = new DateTime(2016, 8, 1, 12, 0, 0);
            int result = DateTime.Compare(date1, date2);
            string relationship;

            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same time as";
            else
                relationship = "is later than";

            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);
        }
    }
    /*
    17 - Escriba un programa C # Sharp para crear una fecha un año antes y la fecha un año en el futuro en comparación con la fecha actual.
    Solución:
    */
    public class ExamDT17
    {
        private enum DateComparisonResult
        {
            Earlier = -1,
            Later = 1,
            TheSame = 0
        };

        public static void MainDT17()
        {
            DateTime thisDate = DateTime.Today;


            DateTime thisDateNextYear, thisDateLastYear;

            //  add/substract 1 year
            thisDateNextYear = thisDate.AddYears(1);
            thisDateLastYear = thisDate.AddYears(-1);

            DateComparisonResult comparison;
            // Compare today to last year
            comparison = (DateComparisonResult)thisDate.CompareTo(thisDateLastYear);
            Console.WriteLine("{0}: {1:d} is {2} than {3:d}",
                              (int)comparison, thisDate, comparison.ToString().ToLower(),
                              thisDateLastYear);

            // Compare today to next year
            comparison = (DateComparisonResult)thisDate.CompareTo(thisDateNextYear);
            Console.WriteLine("{0}: {1:d} is {2} than {3:d}",
                              (int)comparison, thisDate, comparison.ToString().ToLower(),
                              thisDateNextYear);
        }
    }
    /*
    18 - Escriba un programa C # Sharp para comparar la fecha actual con una fecha determinada.
    Solución:
    */
    public class ExamDT18
    {
        public static void MainDT18()
        {
            System.DateTime theDay = new System.DateTime(System.DateTime.Today.Year, 7, 28);
            int compareValue;

            try
            {
                compareValue = theDay.CompareTo(DateTime.Today);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Value is not a DateTime");
                return;
            }

            if (compareValue < 0)
                System.Console.WriteLine("{0:d} is in the past.", theDay);
            else if (compareValue == 0)
                System.Console.WriteLine("{0:d} is today!", theDay);
            else // compareValue > 0
                System.Console.WriteLine("{0:d} has not come yet.", theDay);
        }
    }
    /*
    19 - Escriba un programa C # Sharp para obtener la cantidad de días del mes y año especificados.
    Solución:
    */
    public class ExamDT19
    {
        static void MainDT19()
        {
            const int July = 7;
            const int Feb = 2;

            int daysInJuly = System.DateTime.DaysInMonth(2016, July);
            Console.WriteLine(daysInJuly);

            // 2013 was not a leap year.
            int daysInFeb = System.DateTime.DaysInMonth(2013, Feb);
            Console.WriteLine(daysInFeb);

            // 2004 was a leap year.
            int daysInFebLeap = System.DateTime.DaysInMonth(2004, Feb);
            Console.WriteLine(daysInFebLeap);
        }
    }
    /*
    20 - Escriba un programa C # Sharp para comparar objetos DateTime.
    Solución:
    */
    public class ExamDT20
    {
        public static void MainDT20()
        {
            // Create some DateTime objects.
            DateTime one = DateTime.UtcNow;

            DateTime two = DateTime.Now;

            DateTime three = one;

            // Compare the DateTime objects and display the results.
            bool result = one.Equals(two);

            Console.WriteLine("The result of comparing DateTime object one and two is: {0}.", result);

            result = one.Equals(three);

            Console.WriteLine("The result of comparing DateTime object one and three is: {0}.", result);
        }
    }
}
