using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldProcessor;

namespace HelloWorldProcessor
{
    public abstract class HelloWorldFactCreator
    {
        public abstract HelloWorldProcessor FactoryMethod();
    }

    public class FactoryCreatorConsole : HelloWorldFactCreator

    {
        public override HelloWorldProcessor FactoryMethod()
        {
            return new HelloWorldToConsole();
        }
    }

    public class FactoryCreatorDatabase : HelloWorldFactCreator
    {
        public override HelloWorldProcessor FactoryMethod()
        {
            return new HelloWorldToDatabase();
        }
    }

    public class FactoryCreatorFile : HelloWorldFactCreator
    {
        public override HelloWorldProcessor FactoryMethod()
        {
            return new HelloWorldToFile();
        }
    }
}
