using System;
using System.Text.RegularExpressions;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Salam Cavid.Necesen Cavid?";
            Console.WriteLine(str.CheckString("Cavid"));
        }
    }
}
