using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.DTOs.ClassResponse
{
    public class CategoryResponse : Response
    {
        public Category Data { get; set; }
    }
}
