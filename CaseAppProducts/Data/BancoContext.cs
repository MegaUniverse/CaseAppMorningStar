using CaseAppProducts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CaseAppProducts.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        // DBTables
        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
