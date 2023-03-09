using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.Input.Repositories
{
    public interface IWriteVehicleRepository
    {
        void InsertVehicle(Vehicle vehicle);
    }
}
