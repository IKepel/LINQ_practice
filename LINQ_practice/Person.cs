using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    public class Person
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }

        public Person(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
    }
}
