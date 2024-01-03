using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DropDownListWithEF.Shared.Models;

namespace DropDownListWithEF.Shared.DataAccess
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Shared.Models.Region> Region { get; set; }

        public virtual DbSet<Shared.Models.Territories> Territories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\SyncfusionExamples\DropDownList\dropdown1\DropDownListWithEF\Shared\App_Data\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
 
}
