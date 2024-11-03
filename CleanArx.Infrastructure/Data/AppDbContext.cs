﻿using CleanArx.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Infrastructure.Data
{
    public class AppDbContext (DbContextOptions<AppDbContext> options): DbContext (options)
    {
        public DbSet<Employee>Employees { get; set; }
    }
}
