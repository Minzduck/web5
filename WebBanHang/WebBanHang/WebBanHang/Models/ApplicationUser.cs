using Microsoft.AspNetCore.Identity;
using Microsoft.Build.ObjectModelRemoting;

namespace WebBanHang.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
    }
}
