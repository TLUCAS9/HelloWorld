using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProcessor
{
    public class HelloWorldToConsole: HelloWorldProcessor
    {
        public override bool WriteHelloWorld()
        {
            bool writeOK = true;

            try
            {
                Console.WriteLine(HelloWorldModel.HelloWorld);
            }
            catch (Exception ex)
            {
                writeOK = false;
                throw new Exception("A general exception occurred in HelloWorldToConsole while attempting to write to console. " + ex.Message + ". Stacktrace" + ex.StackTrace);
            }

            return writeOK;
        }
    }
}
