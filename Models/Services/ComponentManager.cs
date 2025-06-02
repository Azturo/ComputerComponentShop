using System.Runtime.CompilerServices;
using ComputerComponentShop.Models.BaseClasses;
using ComputerComponentShop.Models.ProductEnums;

namespace ComputerComponentShop.Models.Services
{
    public class ComponentManager
    {
        private Dictionary<ProductCategory, IListManager<Product>> _componentCategory;

        public ComponentManager() 
        {
            _componentCategory = new Dictionary<ProductCategory, IListManager<Product>>();

            List<ComponentModel> sComponentCategories = InitProducts.InitComponents();

            foreach (var aCategory in sComponentCategories)
            {
                ListManager<Product> aListManager = new ListManager<Product>();
                foreach (var sComponent in  aCategory.Components.ToList())
                {
                    aListManager.Add(sComponent);
                }

                _componentCategory[aCategory.ComponentCategory] = aListManager;

            }

            
        }

        public Dictionary<ProductCategory, IListManager<Product>> GetAllComponents()
        {
            return _componentCategory;
        }

        public List<Product> GetAllProductsFlat()
        {
            return _componentCategory.Values
                .SelectMany(manager => manager.ToList())
                .ToList();
        }

        public List<Product> GetComponentsBasedOnCategories(ProductCategory aProductCategory)
        {
            if(_componentCategory.TryGetValue(aProductCategory, out var sComponentManager))
            {
                return sComponentManager.ToList();
            }

            return new List<Product>();
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

        public List<Product> SearchSorter(string sSearchString)
        {
            List<Product> aSortedProductList = GetAllProductsFlat()
                    .Where(sProducts =>
                    sProducts.Name.Contains(sSearchString, StringComparison.OrdinalIgnoreCase) ||
                    sProducts.Manufacturer.Contains(sSearchString, StringComparison.OrdinalIgnoreCase) ||
                    sProducts.ProductCategory.ToString().Contains(sSearchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            return aSortedProductList;
        }

        
    }
}
