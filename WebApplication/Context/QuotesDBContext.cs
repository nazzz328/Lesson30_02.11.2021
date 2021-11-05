using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class QuotesDBContext : DbContext
    {
        public QuotesDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quote>().HasData
                (
                new Quote
                {
                    Id = Guid.NewGuid(),
                    Text = "Что разум человека может постигнуть и во что он может поверить, того он способен достичь",
                    Author = "Наполеон Хилл",
                    InsertDate = DateTime.Now
                },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Стремитесь не к успеху, а к ценностям, которые он дает",
                Author = "Альберт Эйнштейн",
                InsertDate = DateTime.Now
            },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Своим успехом я обязана тому, что никогда не оправдывалась и не принимала оправданий от других",
                Author = "Флоренс Найтингейл",
                InsertDate = DateTime.Now
            },
            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Сложнее всего начать действовать, все остальное зависит только от упорства",
                Author = "Амелия Эрхарт",
                InsertDate = DateTime.Now
            },

            new Quote
            {
                Id = Guid.NewGuid(),
                Text = "Надо любить жизнь больше, чем смысл жизни",
                Author = "Федор Достоевский",
                InsertDate = DateTime.Now
            }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=apidb.db");
        }

        public DbSet<Quote> Quotes { get; set; }

        public QuotesDBContext()
        {
        }

    }
}
