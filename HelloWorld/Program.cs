using System;
using System.Collections.Generic;
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
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments passed. Usage: HelloWorld.exe outputOption. ==> For Console output example: HelloWorld 1 ");
                return;
            }

            int selectedType = 0;
            if (!int.TryParse(args[0], out selectedType))
            {
                Console.WriteLine("Invalid outputType. Must be 1 (Console), 2 (Database), or 3 (File). ");
                return;
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
