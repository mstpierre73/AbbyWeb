﻿using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data {
    public class ApplicationDbContext : DbContext {
        public DbSet<Category> Categories { get; set; }
    }
}
