using FontAwesome.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontAwesomeGenerateApplication
{
    /// <summary>
    /// Just for debugging the deserialization process.
    /// </summary>
    class DebugApp
    {
        static void Main(string[] args)
        {
            FontAwesomeInterop interop = new FontAwesomeInterop(@"D:\Projects\Font-Awesome-WPF\Font-Awesome\_config.yml");
        }
    }
}
