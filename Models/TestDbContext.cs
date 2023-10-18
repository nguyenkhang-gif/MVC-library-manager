using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final_project.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }

}
