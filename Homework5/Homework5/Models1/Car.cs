using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Models1
{
    public class Car
    {
        public string Model { get; set; }
        public string Speed { get; set; }   
        public Driver Driver { get; set; }
    }
}
