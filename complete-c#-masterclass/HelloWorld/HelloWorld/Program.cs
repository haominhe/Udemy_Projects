using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float strFloat = float.Parse(stringForFloat);
            int strInt = Int32.Parse(stringForInt);


            Console.WriteLine("Hi");
            Console.WriteLine("Int = {0}, Float = {1}", strInt, strFloat);
            Console.Read();
        }
    }
}
