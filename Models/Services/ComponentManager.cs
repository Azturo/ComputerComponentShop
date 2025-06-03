using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.DataBase;
using ComputerComponentShop.Models.ProductEnums;

namespace ComputerComponentShop.Models.Services
{
    public class ComponentManager
    {
        private Dictionary<ProductCategory, IListManager<Product>> _componentCategory;

        private readonly ComputerComponentRepository _componentRepository;

        public ComponentManager(ComputerComponentRepository componentRepository) 
        {
            _componentRepository = componentRepository;
        }

       

        public async Task<List<Product>> GetAllProductsFlat()
        {
            return await _componentRepository.GetAllProducts();

        }

        

        public string PrettyPrintComponentProperties(string aInput)
        {

            return System.Text.RegularExpressions.Regex.Replace(aInput, "(\\B[A-Z])", " $1");
        }

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

        private List<Product> _products = new List<Product>();


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
