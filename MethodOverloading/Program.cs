using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(10,10,true);
            Console.WriteLine(answer);
        }
    }
}
