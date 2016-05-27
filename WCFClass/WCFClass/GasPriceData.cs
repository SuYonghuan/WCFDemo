using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace WCFClass
{
    [DataContract]
    public class GasPriceData
    {
        [DataMember]
        public string GasStation { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}
