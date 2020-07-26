using System;
namespace Zoo
{
    public class Animal
    {
        public string Name;
        public Animal(string name)
        {
            this.Name = name;
        }
        public void PrintName()
        {
            Console.Write("This is an animal from class animal");
        }
    }
}
