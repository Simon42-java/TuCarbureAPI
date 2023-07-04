﻿using Microsoft.EntityFrameworkCore;
using TuCarbureAPI.EntityLayer;

public class MySqlConnectionContext : DbContext
{
    public MySqlConnectionContext(DbContextOptions<MySqlConnectionContext> options) : base(options)
    {
    }

    public DbSet<Carburant> Carburants { get; set; }
}
