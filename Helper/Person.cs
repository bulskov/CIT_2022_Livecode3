using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public int PetId { get; set; }

        //public override string ToString()
        //{
        //    return $"Name: {Name}, Age: {Age}";
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}, PetId = {PetId}";
        }
    }
}
