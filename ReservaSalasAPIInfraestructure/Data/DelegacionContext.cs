using Microsoft.EntityFrameworkCore;
using ReservaSalasAPIDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIInfraestructura.Data
{
    public class DelegacionContext: DbContext
    {
        public DelegacionContext(DbContextOptions<DelegacionContext> options) : base(options) 
        { 

        }

        public DbSet<Delegacion> Delegaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
