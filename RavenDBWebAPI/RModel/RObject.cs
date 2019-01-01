using RavenDBWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI.RModel
{
    public class RObject
    {
        public Customer customer { get; set; }
        public Employee employee { get; set; }
        public SupportCall support { get; set; }
        public long Milliseconds { get; set; }
        public string Sum { get; set; }
        public bool Action { get; set; }
    }
}
