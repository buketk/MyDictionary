using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(456, "Motor");
            myDictionary.Add(888, "Scoter");
            myDictionary.Add(999, "Bicycle");

            myDictionary.ToList();


        }
    }
}
