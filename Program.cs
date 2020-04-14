using System;
//Using NuGet Package https://www.nuget.org/packages/System.CommandLine.DragonFruit
//Using Nuget Package https://www.nuget.org/packages/System.CommandLine
#pragma warning disable 1591
// dotnet --idex Exer1
// dotnet --idex Exer2
// ..
// dotnet --idex ExerN
namespace src
{
    class Program1
    {
        /// <param name="idex">Id of Exercise to run up!</param>
        static int Main(string idex = null)
        {
            return idex switch
            {
                "Exer1" => new Basics().Main1(),
                "Exer2" => new Basics().Main2(),
                "Exer3" => new Basics().Main3(),
                "Exer4" => new Basics().Main4(),
                "Exer5" => new Basics().Main5(),
                "Exer6" => new Basics().Main6(),
                "Exer7" => new Basics().Main7(),
                "Exer8" => new Basics().Main8(),
                "Exer9" => new Basics().Main9(),
                "ExerColl6" => new ExerColl6().MainColl6(),
                null => RunAll(),
                _ => MissingTag(idex),
            };
        }
        private static int MissingTag(string tag, bool idex = true)
        {
            Console.WriteLine($"No code snippet configured for {(idex ? "idex" : "other")}: {tag}");
            return 1;
        }
        //string[] args Include args like argument is not using Command.Line
        private static int RunAll()
        {
            /*if (args.Length==0)
                Console.WriteLine("Missing argiments!");
            string session = args[0];
            return session switch
            {
                "Exer1" => new Basics().Main1(),
                "Exer2" => new Basics().Main2(),
                "Exer3" => new Basics().Main3(),
                "Exer4" => new Basics().Main4(),
                "Exer5" => new Basics().Main5(),
                "Exer6" => new Basics().Main6(),
                "Exer7" => new Basics().Main7(),
                "Exer8" => new Basics().Main8(),
                "Exer9" => new Basics().Main9(),
                null => MissingTag(session),
                _ => MissingTag(session),
            };*/
            new Basics().Main1();
            new Basics().Main2();
            new Basics().Main3();
            new Basics().Main4();
            new Basics().Main5();
            new Basics().Main6();
            new Basics().Main7();
            new Basics().Main8();
            new Basics().Main9();
            //Todo the next exercises
            return 0;
        }
    }
}
