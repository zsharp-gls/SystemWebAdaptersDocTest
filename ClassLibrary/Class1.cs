using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassLibrary
{
    public class Class1
    {
        public bool PerformSomeCheck(HttpContext context)
        {
            return context.Request.Headers["SomeHeader"] == "ExpectedValue";
        }
    }
}
