using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxInASPNETCore.Models
{
    public class TransactionDbContext: DbContext //繼承DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
