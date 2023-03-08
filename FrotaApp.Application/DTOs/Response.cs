using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.DTOs
{
    public class Response
    {
        public string PropertyName { get; set; }
        public string Error { get; set; }
        public bool Success { get; set; }
    }
}
