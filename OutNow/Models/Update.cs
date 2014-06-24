using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OutNow.Models
{
[DataContract]
   public class Update
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
