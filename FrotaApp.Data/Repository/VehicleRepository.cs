using FrotaApp.Data.Context;
using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Data.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly FrotaContext context;

        public VehicleRepository(FrotaContext _context)
        {
            context = _context;
        }
        public async Task<int> AddVehicle(Vehicle vehicle)
        {
                await context.Vehicles.AddAsync(vehicle);
                await context.SaveChangesAsync();
                return vehicle.Id;
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            return await context.Vehicles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Vehicle> GetVehicleForChassi(int chassi)
        {
            return await context.Vehicles.FirstOrDefaultAsync(x => x.NumberChassi == chassi);
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
                return await context.Vehicles.ToListAsync();
        }
    }
}
