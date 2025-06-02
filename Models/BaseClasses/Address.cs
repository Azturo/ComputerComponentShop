using System.ComponentModel.DataAnnotations;

namespace ComputerComponentShop.Models.BaseClasses
{
    public class Address
    {
        [Required(ErrorMessage = "Street name is required")]
        public string Street {  get; set; }

        [Required(ErrorMessage = "City name is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zipcode is required")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        public Address() { }


    }
}
