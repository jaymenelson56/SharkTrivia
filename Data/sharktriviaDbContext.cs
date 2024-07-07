using Microsoft.EntityFrameworkCore;
using sharktrivia.Models;

public class SharkTriviaDbContext : DbContext
{

    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
  
    public SharkTriviaDbContext(DbContextOptions<SharkTriviaDbContext> context) : base(context)
    {

    }
}