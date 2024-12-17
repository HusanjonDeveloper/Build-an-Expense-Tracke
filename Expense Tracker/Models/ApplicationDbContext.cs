using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions oprions) : base(oprions)
    { }

    public  DbSet<Transaction> Transactions { get; set; }
    public  DbSet<Category> Categories { get; set; }
    
    
}