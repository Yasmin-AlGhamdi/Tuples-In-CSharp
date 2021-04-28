using System;

namespace Tuples
{
    class Program
    {
        static void DisplayStudent(Tuple<int, string, string> student)
        {
            //Student ID, age, 
            Console.WriteLine("ID: " + student.Item1);
            Console.WriteLine("First name: " + student.Item2);
            Console.WriteLine("Last name: " + student.Item3);
        }
        static Tuple<int, string, string> Display()
        {
            return Tuple.Create(1, "Yasmin", "AlGhamdi");
        }
        static void Display(Tuple<int, string, string> person)
        {
            Console.WriteLine("ID: " + person.Item1);
            Console.WriteLine("First name: " + person.Item2);
            Console.WriteLine("Last name: " + person.Item3);
        }
        static void Main(string[]args)
        {
            Tuple<int, string, bool> mytuple=new Tuple<int, string, bool>(1, "Sara", false); // You can use this way
            var myTuple = Tuple.Create(1, "Sara", false); // or this way
            Console.WriteLine(myTuple.Item2);

            Console.WriteLine("---------------------------------------------------------------------");


            var nums = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(nums.Rest.Item1.Item4); // Rest is to use / access nested tuples

            Console.WriteLine("---------------------------------------------------------------------");


            var person = Tuple.Create(1, "Yasmin", "AlGhamdi");
            Display(person);

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine(Display());

            Console.WriteLine("---------------------------------------------------------------------");

            var stu=Tuple.Create(123, "Yasmin", "AlGhamdi");
            DisplayStudent(stu);

            Console.ReadKey();
        }
    }
}
