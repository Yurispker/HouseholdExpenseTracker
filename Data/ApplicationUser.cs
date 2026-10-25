using Microsoft.AspNetCore.Identity;
using HouseholdExpenseTracker.Models;

namespace HouseholdExpenseTracker.Data;

public class ApplicationUser : IdentityUser
{
    public int? HouseholdId { get; set; }
    public Household? Household { get; set; }
}