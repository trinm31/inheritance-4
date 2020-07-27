using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child: Person
    {
        
        public Child(string name, int age): base(name,age)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + ". This is a child";
        }

    }
}
