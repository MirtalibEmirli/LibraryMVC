using System.ComponentModel.DataAnnotations;

namespace Library.Web.UI
{
    public class LoginViewModel
    {
        public required string UserName { get; set; }
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        public required bool RememberMe { get; set; }
    }
}