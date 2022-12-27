using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class FootballAnalysisContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6AJUFT5;database=FootballAnalysisDB;integrated security=true; Encrypt=False");
        }
        public DbSet<MatchScore> MatchScores { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<TeamInfo> TeamInfos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}