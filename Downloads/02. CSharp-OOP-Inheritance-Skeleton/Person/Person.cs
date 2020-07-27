using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            this.Name = name;
            if (age < 0)
            {
                this.Age = 0;
            }
            else 
            {
                this.Age = age;
            }
            
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }
    }
}
