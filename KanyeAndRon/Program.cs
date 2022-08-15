using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace KanyeAndRon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quotegen.KanyeQuote();
            Quotegen.RonQuote();
        }
    }
}
