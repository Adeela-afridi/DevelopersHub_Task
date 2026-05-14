using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EStore.Models;

public sealed class AppUser : IdentityUser
{
    [MaxLength(80)]
    public string? FullName { get; set; }
}


