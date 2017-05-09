using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wypozyczalnia.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineType { get; set; }
        public double EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public bool Occupied { get; set; }
        public string Image { get; set; }

    }
}