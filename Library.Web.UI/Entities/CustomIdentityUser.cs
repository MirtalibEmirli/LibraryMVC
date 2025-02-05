using Microsoft.AspNetCore.Identity;

namespace Library.Web.UI.Entities;

public class CustomIdentityUser:IdentityUser
{
    public string School { get; set; }
}
