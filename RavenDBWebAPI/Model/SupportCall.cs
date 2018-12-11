using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI.Model
{
    public class SupportCall
    {
        public string Id { get; set; }
        public int Cost { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public string Issue { get; set; }
    }
}
