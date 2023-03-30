using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_Task_3.Models
{
    public class Animal
    {
        public Animal(string name, string color, int age, Gender gender) 
        { 
            this.Name = name;
            this.Color = color;
            this.Age = age;
            this.GenderType = gender;
        }


        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Gender GenderType { get; set; }
        public enum Gender
        {
            Male,
            Female

        }
    }
}
