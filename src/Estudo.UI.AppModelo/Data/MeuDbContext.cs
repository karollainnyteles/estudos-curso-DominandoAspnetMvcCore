using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo.UI.AppModelo.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}