using FrotaApp.Application.DTOs.ClassDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.DTOs.ClassResponse
{
    public class VehicleResponse : Response
    {
        public VehicleDTO Data { get; set; }
    }
}
