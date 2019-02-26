using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorldProcessor;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputSelect = string.Empty;

            if (ConfigurationManager.AppSettings.AllKeys.Contains("OutputMode"))
            {
                outputSelect = ConfigurationManager.AppSettings["OutputMode"];
            }
           
            if (string.IsNullOrEmpty(outputSelect))
            {
                Console.WriteLine("OutputMode key configuration is missing. Must be 1 (Console), 2 (Database), or 3 (File). Defaulting to 1 (Console). ");
                outputSelect = "1";
            }
         
            int selectedType = 0;
            if (!int.TryParse(outputSelect, out selectedType))
            {
                Console.WriteLine("Invalid OutputMode. Must be 1 (Console), 2 (Database), or 3 (File). Please check settings. Defaulting to 1 (Console)");
                outputSelect = "1";
            }
            else
            {
                HelloWorldModel.OutputType outputType = (HelloWorldModel.OutputType)selectedType;
                switch (outputType)
                {
                    case HelloWorldModel.OutputType.Console:
                    {
                         FactoryCreatorConsole createConsole = new FactoryCreatorConsole();
                         HelloWorldToConsole helloConsole = (HelloWorldToConsole)createConsole.FactoryMethod();
                         helloConsole.WriteHelloWorld();
                         break;
                    }
                    case HelloWorldModel.OutputType.Database:
                    {
                         FactoryCreatorDatabase createDatabase = new FactoryCreatorDatabase();
                         HelloWorldToDatabase helloDatabase = (HelloWorldToDatabase)createDatabase.FactoryMethod();
                         helloDatabase.WriteHelloWorld();
                         break;
                    }
                    case HelloWorldModel.OutputType.File:
                    {
                        FactoryCreatorFile createFile = new FactoryCreatorFile();
                        HelloWorldToFile helloFile = (HelloWorldToFile)createFile.FactoryMethod();
                        helloFile.WriteHelloWorld();
                        break;
                    }
                    default:
                    {
                         throw new Exception("Hello World Selelection Not implemented");
                    }
                }
            }
        }
    }
}
