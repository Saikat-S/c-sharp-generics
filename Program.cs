using System;

namespace c_sharp_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dictionaty = new GenericDictionary<int, string>();
            //dictionaty.Add(1, "saikat");

            var number = new Nullable<int>();
            System.Console.WriteLine("Has value ?"+ number.HasValue);
            System.Console.WriteLine("value: "+ number.GetValueOrDefault());


        }
    }
}
