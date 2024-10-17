using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaprarSalajan_AnaCezara_Lab2.Models;

namespace CaprarSalajan_AnaCezara_Lab2.Data
{
    public class CaprarSalajan_AnaCezara_Lab2Context : DbContext
    {
        public CaprarSalajan_AnaCezara_Lab2Context (DbContextOptions<CaprarSalajan_AnaCezara_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<CaprarSalajan_AnaCezara_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<CaprarSalajan_AnaCezara_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<CaprarSalajan_AnaCezara_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
