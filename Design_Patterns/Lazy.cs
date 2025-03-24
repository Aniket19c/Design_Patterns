using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns;

namespace Design_Patterns
{
    class Lazy
    {
        private static readonly Lazy<string> _lazyMessage = new Lazy<string>(() => "Hello from Lazy<T>!");

        public static string Message => _lazyMessage.Value;
    }
}

