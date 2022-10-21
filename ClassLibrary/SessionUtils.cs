using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class SessionUtils
    {
        public static void RegisterSessionKeys(IDictionary<string,System.Type> sessionKeys)
        {
            sessionKeys.Add("test-value", typeof(int));
        }
    }
}
