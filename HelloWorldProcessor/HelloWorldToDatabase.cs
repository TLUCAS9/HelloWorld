using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProcessor
{
    public class HelloWorldToDatabase : HelloWorldProcessor
    {
        public override bool WriteHelloWorld()
        {
            bool storeOK = true;

            try
            {
                //TODO: Store message to database 
            }
            catch (Exception ex)
            {
                storeOK = false;
                throw new Exception("A general exception occurred in HelloWorldToDatabase while attempting to write file. " + ex.Message + ". Stacktrace" + ex.StackTrace);
            }

            return storeOK;
        }
    }
}
