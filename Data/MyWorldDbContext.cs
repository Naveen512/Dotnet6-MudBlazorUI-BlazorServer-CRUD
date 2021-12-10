using Dot6.BlazorServer.Crud.Learn.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot6.BlazorServer.Crud.Learn.Data;
public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {
        
    }
    public DbSet<Cake> Cake{get;set;}
}