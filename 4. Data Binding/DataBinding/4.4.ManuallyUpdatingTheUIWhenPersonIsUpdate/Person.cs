using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuallyUpdatingTheUIWhenPersonIsUpdate
{
    public class Person
    {
        string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
