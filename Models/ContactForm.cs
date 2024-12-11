using System.ComponentModel.DataAnnotations;

namespace AdoptionWebsiteTest.Models
{
    public class ContactForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Question/Concern is required.")]
        public string? QuestionsAndConcerns { get; set; }
    }
}
