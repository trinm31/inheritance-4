using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input name");
            string name = Console.ReadLine();
            Console.WriteLine("input age");
            int age = int.Parse(Console.ReadLine());
            Person person;
            Child child;
            if (age >= 15)
            {
                person = new Person(name, age);
                Console.WriteLine(person.ToString());
            }
            else 
            {
                child = new Child(name,age);
                Console.WriteLine(child.ToString());
            }

            Console.ReadLine();
        }
    }
}