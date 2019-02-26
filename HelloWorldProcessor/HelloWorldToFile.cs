using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProcessor
{
    public class HelloWorldToFile : HelloWorldProcessor
    {
        public override bool WriteHelloWorld()
        {
            bool writeOK = true;

            try
            {
                using (System.IO.StreamWriter fileHello = new System.IO.StreamWriter(HelloWorldModel.HelloWorld + ".txt"))
                {
                    fileHello.WriteLine(HelloWorldModel.HelloWorld);
                }
            }
            catch (IOException ex)
            {
                writeOK = false;
                throw new Exception("An IO exception occurred HelloWorldToFile while attempting to write file. " + ex.Message + ". Stacktrace" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                writeOK = false;
                throw new Exception("A general exception occurred in HelloWorldToFile while attempting to write file. " + ex.Message + ". Stacktrace" + ex.StackTrace);
            }

            return writeOK;
        }
    }
}
