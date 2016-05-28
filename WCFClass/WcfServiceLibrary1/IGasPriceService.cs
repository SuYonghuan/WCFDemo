using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFClass
{
    [ServiceContract]
    public interface IGasPriceService
    {
        [OperationContract]
        [WebGet
            (ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/GetGasPrice/For/ZipCode/{zipCode}"
            )]
        GasPriceData GetPriceByZipCode(string zipCode);

        [OperationContract]
        [WebGet
            (RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/GetGasPrice/For/City/{city}"
            )]
        GasPriceData GetPriceByCity(string city);
    }
}
