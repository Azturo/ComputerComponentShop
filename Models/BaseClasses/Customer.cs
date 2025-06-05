using System.ComponentModel.DataAnnotations;

namespace ComputerComponentShop.Models.BaseClasses
{
    public class Customer
    {

        public Order Order { get; set; }
        private string aPhoneNumber = string.Empty;

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [ValidateComplexType]
        public Address Address { get; set; }

        [Required(ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is invalid")]
        public string Phone
        {
            get { return aPhoneNumber; }
            set
            {
                if (IsPhoneNumberValid(value)) //Checks if the phone number is valid
                {
                    aPhoneNumber = value;
                }
                else
                    return;
            }
        }

        public Customer() 
        {
            Address = new Address();
            Order = new Order();
            
        }

        /// <summary>
        /// Method that checks if the phone number contains any characters other then the allowed ones
        /// </summary>
        /// <param name="aPhoneNumber"></param>
        /// <returns>True if Phone number is valid, if not false</returns>
        private bool IsPhoneNumberValid(string aPhoneNumber)
        {
            foreach (char character in aPhoneNumber) 
            {
                if (!char.IsDigit(character) && character != ' ' && character != '-' && character != '(' && character != ')' && character != '+') //Allowed characters
                {
                    return false; //If found an invalid character return false
                }
            }
            return true; //If phone number is valid


        }

    }
}
