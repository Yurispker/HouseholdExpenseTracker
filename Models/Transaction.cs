using HouseholdExpenseTracker.Data;

namespace HouseholdExpenseTracker.Models;

public class Transaction
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public bool IsPersonal { get; set; } = true;
    public string? Category { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }

    public int HouseholdId { get; set; }
    public Household? Household { get; set; }
}