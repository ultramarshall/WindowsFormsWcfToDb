using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfToDb
{
    [DataContract]
    public class Biodata
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public String Nama { get; set; }
        [DataMember]
        public int Umur { get; set; }
    }
}
