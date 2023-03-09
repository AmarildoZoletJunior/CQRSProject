using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.Output.DTOs
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int Type { get; set; }
        public int NumberChassi { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CategoryName { get; set; }
    }
}
