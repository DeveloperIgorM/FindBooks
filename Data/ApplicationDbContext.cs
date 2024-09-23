using FindBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindBooks.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    //Item que liga o banco de dados com a aplicação
    public Microsoft.EntityFrameworkCore.DbSet<Student> Students { get; set; } = default!;
    public Microsoft.EntityFrameworkCore.DbSet<Subscription> Subscriptions { get; set; } = default!;
}
