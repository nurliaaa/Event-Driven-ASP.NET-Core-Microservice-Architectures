using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Entities
{
    public class IntegrationEvent
    {
        public int ID { get; set; }
        public string Event { get; set; }
        public string Data { get; set; }
    }
}
