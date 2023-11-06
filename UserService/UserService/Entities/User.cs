using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string OtherData { get; set; }
      
    }
}
