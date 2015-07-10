using System.ComponentModel.DataAnnotations;

namespace WebApplication5.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
