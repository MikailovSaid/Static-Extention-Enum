using System;
using System.Text.RegularExpressions;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<object> list = new MyList<object>();
            list.Add("Said");
            list.Add("Salam");
            list.Add(1);
            list.Add(2);

            list.AddRange(3);

            //list.Clear();

            //list.Find();
        }
    }
}
