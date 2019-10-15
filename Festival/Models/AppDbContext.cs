using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MusicFestival> MusicFestival { get; set; }
        public DbSet<Band> Band { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=FestivalDB;Trusted_Connection=true");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
            modelBuilder.Entity<MusicFestival>(entity =>
            {
                entity.ToTable("MusicFestival");
                entity.HasKey(e => e.festivalId);
                entity.Property(e => e.name);
            });

            modelBuilder.Entity<Band>(entity =>
            {
                entity.ToTable("Band");

                entity.Property(e => e.bandId);

                entity.Property(e => e.name);

                entity.Property(e => e.recordLabel);

                entity.HasOne(d => d.MusicFestival)
                            .WithMany(p => p.Bands)
                            .HasForeignKey(d => d.festivalId)
                            .HasConstraintName("FK_Band_MusicFestival");
            });



            modelBuilder.Entity<MusicFestival>().HasData(
                new MusicFestival
                {
                    festivalId = 1,
                    name = "Twisted Tour"
                },
                new MusicFestival
                {
                    festivalId = 2,
                    name = "Trainerella"
                },
                new MusicFestival
                {
                    festivalId = 3,
                    name = "LOL-palooza"
                }

                );

            modelBuilder.Entity<Band>().HasData(

                new Band
                {
                    bandId = 11,
                    festivalId = 1,
                    name = "Squint-281"
                },
                 new Band
                 {
                     bandId = 12,
                     festivalId = 1,
                     name = "Summon",
                     recordLabel = "Outerscope"
                 },
                 new Band
                 {
                     bandId = 13,
                     festivalId = 1,
                     name = "Auditones",
                     recordLabel = "Marner Sis. Recording"
                 },

                  new Band
                  {
                      bandId = 14,
                      festivalId = 2,
                      name = "Adrian Venti",
                      recordLabel = "Monocracy Records"
                  },

                   new Band
                   {
                       bandId = 15,
                       festivalId = 2,
                       name = "YOUKRANE",
                       recordLabel = "Anti Records"
                   },

                    new Band
                    {
                        bandId = 16,
                        festivalId = 2,
                        name = "Manish Ditch",
                        recordLabel = "ACR"
                    },

                     new Band
                     {
                         bandId = 17,

                         name = "Wild Antelope",
                         recordLabel = "Still Bottom Records"
                     },

                     new Band
                     {
                         bandId = 18,
                         festivalId = 2,
                         name = "Propeller",
                         recordLabel = "Pacific Records"

                     },
                      new Band
                      {
                          bandId = 19,
                         
                          name = "Critter Girls",
                          recordLabel = "ACR"
                      },

                      new Band
                      {
                          bandId = 20,
                          festivalId = 3,
                          name = "Frank Jupiter",
                          recordLabel = "Pacific Records"
                      },
                       new Band
                       {
                           bandId = 21,
                           festivalId = 3,
                           name = "Winter Primates",
                       },
                       new Band
                       {
                           bandId = 22,
                           festivalId = 3,
                           name = "Jill Black",
                           recordLabel = "Fourth Woman Records"
                       },

                         new Band
                         {
                             bandId = 23,
                             festivalId = 3,
                             name = "Werewolf Weekday",
                             recordLabel = "XS Recordings"
                         }

            );

        }



    }
}
