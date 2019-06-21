using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication23.Models;

    public class WebApplication23Context : DbContext
    {
        public WebApplication23Context (DbContextOptions<WebApplication23Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication23.Models.Categoria> Categoria { get; set; }
    }
