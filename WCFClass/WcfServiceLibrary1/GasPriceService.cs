using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;


namespace WCFClass
{
    [AspNetCompatibilityRequirements(
        RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GasPriceService : IGasPriceService
    {
        #region Members

        public GasPriceData GetPriceByZipCode(string zipCode)
        {
            switch (zipCode)
            {
                case "00000":
                    return new GasPriceData { GasStation = "None", Price = 0.00m };
                case "12345":
                    return new GasPriceData { GasStation = "HP", Price = 420m };
                case "11111":
                    return new GasPriceData { GasStation = "Indian Oil", Price = 531m };
                default:
                    return new GasPriceData { GasStation = "DefaultGasPrice", Price = 400m };
            }
        }

        public GasPriceData GetPriceByCity(string city)
        {
            switch (city.ToLower())
            {
                case "hyderabad":
                    return new GasPriceData { GasStation = "HP", Price = 459m };
                case "delhi":
                    return new GasPriceData { GasStation = "Indian Oil", Price = 449m };
                case "chenni":
                    return new GasPriceData { GasStation = "BG", Price = 499m };
                default:
                    return new GasPriceData { GasStation = "DefaultGasPrice", Price = 409m };
            }
        }

        #endregion
    }
}
