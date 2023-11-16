using System;

namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            // implicit casting //
            int myInt = 10;
            double mydouble = myInt;

            Console.WriteLine("my int is :"+ myInt);
            Console.WriteLine("my double is :"+mydouble);

            // explicit casting //

            double myDouble = 9.55;
            int myint = (int)mydouble;
            Console.WriteLine("my int is :"+myint);
            Console.WriteLine("my double is "+myDouble);

            int mInt = 15;
            double mdouble = 5.55;
            bool mybool = false;

            Console.WriteLine(Convert.ToString(mInt));
            Console.WriteLine(Convert.ToDouble(mInt));
            Console.WriteLine(Convert.ToInt32(mdouble));
            Console.WriteLine(Convert.ToString(mybool));

        }
    }
}