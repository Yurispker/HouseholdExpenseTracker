using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HouseholdExpenseTracker.Models;

namespace HouseholdExpenseTracker.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Household> Households { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}