using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Domain.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
    }
}
