using Microsoft.EntityFrameworkCore;
using PortfolioProject.Entities;

namespace PortfolioProject.Context
{
    public class PortfolioContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DF48HFD\\MYSSQLSERVER; Database=PortfolioDB;integrated security=true;Trust Server Certificate=True");
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<HeroTitle>  HeroTitles{ get; set; }
        public DbSet<Message>  Messages{ get; set; }
        public DbSet<Contact> contacts{ get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SkillItem> SkillItems { get; set; }
    }
}
