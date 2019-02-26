using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HelloWorldProcessor
{
    public class HelloWorldModel
    {
        public static string HelloWorld = "Hello World";

        public enum OutputType
        {
            [Description("Console")]
            Console = 1,
            [Description("Database")]
            Database = 2,
            [Description("Text File")]
            File = 3
        }
    }
}
