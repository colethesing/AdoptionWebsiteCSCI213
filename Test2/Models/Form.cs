using System.ComponentModel.DataAnnotations;

namespace AdoptionWebsiteTest.Models
{
    public class Form
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "House Size is required.")]
        public string HouseSize { get; set; }

        public int NumberOfPets { get; set; }

        public bool PreviousDogOwner { get; set; }

        public string QuestionsConcerns { get; set; }
    }
}
