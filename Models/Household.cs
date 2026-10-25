using HouseholdExpenseTracker.Data;

namespace HouseholdExpenseTracker.Models;

public class Household
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string InviteCode { get; set; } = string.Empty;

    public List<ApplicationUser> Members { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();
}