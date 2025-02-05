using System.ComponentModel.DataAnnotations;

namespace Library.Web.UI.Models;

public class RegisterViewModel
{
    public required string UserName { get; set; }

    [DataType(DataType.Password)]
    public required string Password { get; set; }

    public required string Email { get; set; }


}