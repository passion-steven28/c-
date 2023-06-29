using Microsoft.EntityFrameworkCore;
using ticketer.core.entities;

namespace ticketer.core.context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //we need to have a Db set for our database table
    public Dbset<Ticket> Tickets
    {
        get;
        set;
    }
}
