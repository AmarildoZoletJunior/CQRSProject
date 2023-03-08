using FrotaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Domain.Entities
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int  ModelYear { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public EVehicleType Type { get; set; }
    }
}
