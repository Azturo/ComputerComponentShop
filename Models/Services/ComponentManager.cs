using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.DataBase;


namespace ComputerComponentShop.Models.Services
{
    public class ComponentManager
    {
        private readonly ComputerComponentRepository _componentRepository;
        private List<Product> _products = new List<Product>();

        public ComponentManager(ComputerComponentRepository componentRepository) 
        {
            _componentRepository = componentRepository;
        }

       
        /// <summary>
        /// Gets all products from the repository
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetAllProductsFlat()
        {
            if (_products.Count == 0)
            {
                _products = await _componentRepository.GetAllProducts();
            }

            return _products.ToList();

        }

        
        /// <summary>
        /// Returns the parameter string and makes the string prettier
        /// </summary>
        /// <param name="aInput"></param>
        /// <returns></returns>
        public string PrettyPrintComponentProperties(string aInput)
        {
            return System.Text.RegularExpressions.Regex.Replace(aInput, "(\\B[A-Z])", " $1");
        }

        /// <summary>
        /// Replaces "_"  from a enumstring with blankspace
        /// </summary>
        /// <param name="aEnumValue"></param>
        /// <returns></returns>
        public static string Remove_(string aEnumValue)
        {
            if (aEnumValue.Contains("_"))
            {
                return aEnumValue.ToString().Replace("_", " ");
            }
            else
            {
                return aEnumValue;
            }
            
        }

        /// <summary>
        /// If a property value needs a suffix after the value, displays the correct suffix
        /// </summary>
        /// <param name="aPropertyName"></param>
        /// <returns>A suffix if needed, if not return the value</returns>
        public string ShowCorrectSuffixOnProperty(string aPropertyName)
        {
            switch (aPropertyName)
            {
                case "CapacityGb":
                    return " GB";
                case "SpeedMhz":
                    return "Mhz";
                case "Price":
                    return "kr";
                case "ReadSpeed":
                    return " MB/s";
                case "WriteSpeed":
                    return " MB/s";
                case "ExpectedLifetime":
                    return " Hours";
                case "Wattage":
                    return " W";
                case "FanSize":
                    return " mm";
                case "RadiatorSize":
                    return " mm";
                case "MaxTdpWatts":
                    return " W";
                case "NoiseLevelDb":
                    return " db";
                case "PumpSpeed":
                    return " rpm";
                case "Height":
                    return " mm";
                case "FanSpeed":
                    return " rpm";
                case "HeatPipes":
                    return "x";
                case "VramMemory":
                    return " GB";
                case "BaseClockSpeed":
                    return " GHz";
                case "BoostClockSpeed":
                    return " GHz";
                default:
                    return "";
            }

        }

        /// <summary>
        /// Populates a product list with all products. Then filters the list with the users search string in the GUI
        /// </summary>
        /// <param name="sSearchString"></param>
        /// <returns>All Products in the list that matches the search string</returns>
        public async Task<List<Product>> SearchSorter(string sSearchString)
        {
            if(_products.Count == 0)
            {
                _products = await _componentRepository.GetAllProducts();
            }
            

            return _products.Where(
                x => x.Name.Contains(sSearchString, StringComparison.OrdinalIgnoreCase) ||
                x.Manufacturer.Contains(sSearchString, StringComparison.OrdinalIgnoreCase) ||
                x.ProductCategory.ToString().Replace("_", " ").Contains(sSearchString, StringComparison.OrdinalIgnoreCase)
                

                ).ToList();

            

        }


    }
}
