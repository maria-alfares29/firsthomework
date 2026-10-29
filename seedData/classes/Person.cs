using System;
using System.Collections.Generic;
using System.Text;

namespace seedData.classes
{
    public abstract class Person
    {
        public abstract string GetRole();
        public override string ToString()
        {
            return "Hello person who you are";
        }
    }

}
