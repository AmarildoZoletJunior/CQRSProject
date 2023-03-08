using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Domain.Interface
{
    public interface IVehicleRepository
    {
        public Task<Vehicle> GetVehicle(int id);
        public Task<Vehicle> GetVehicleForChassi(int chassi);
        public Task<List<Vehicle>> GetVehicles();
        public Task<int> AddVehicle(Vehicle vehicle);
    }
}
