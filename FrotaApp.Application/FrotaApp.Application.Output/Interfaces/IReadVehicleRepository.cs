using FrotaApp.Application.Output.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.Output.Interfaces
{
    public interface IReadVehicleRepository
    {
        IEnumerable<VehicleDTO> GetVehicles();
        IEnumerable<VehicleDTO> FindByCategoryId(int categoryId);
        Task<VehicleDTO> FindById(int id);
        Task<VehicleDTO> FindByChassi(int chassi);
    }
}
