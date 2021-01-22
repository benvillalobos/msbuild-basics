using System;
using System.IO;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starting!");
            // Do not call any MSBuild related code within the same function that you registerdefaults.
            // Things get confused and you hit an exception trying to load Microsoft.Build version 15.1.0
            MSBuildLocator.RegisterDefaults();
            Console.WriteLine("Register defaults finished!");

            TestMSBuild();

            Console.WriteLine("Program Finished!\nPress any key to close.");
            Console.ReadKey();
        }

        static void TestMSBuild() 
        {
            Project project = new Project(Directory.GetCurrentDirectory() + "\\..\\..\\..\\template.proj");
            Console.WriteLine(project.Build("HelloWorld"));
        }
    }
}
