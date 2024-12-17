using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions oprions) : base(oprions)
    { }

    public  DbSet<Transaction> Transactions { get; set; }
    public  DbSet<Category> Categories { get; set; }

}