using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATVAPIRELACIONAMENTO1109.Models;

namespace ATVAPIRELACIONAMENTO1109.Data
{
    public class ATVAPIRELACIONAMENTO1109Context : DbContext
    {
        public ATVAPIRELACIONAMENTO1109Context (DbContextOptions<ATVAPIRELACIONAMENTO1109Context> options)
            : base(options)
        {
        }

        public DbSet<ATVAPIRELACIONAMENTO1109.Models.Estoque> Estoque { get; set; } = default!;
    }
}
