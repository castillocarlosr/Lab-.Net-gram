using Microsoft.EntityFrameworkCore;
using NetGram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Data
{
    public class WorkGramDbContext : DbContext
    {
        public WorkGramDbContext(DbContextOptions<WorkGramDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkGram>().HasData(
                new WorkGram
                {
                    ID = 1,
                    UserName = "UserOne",
                    Title = "Friend Coding",
                    URL = "/assets/pic001.JPG",
                    Comments = "Hack the world",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 2,
                    UserName = "User Doc",
                    Title = "Doctor in office",
                    URL = "/assets/pic002.jpg",
                    Comments = "Making you healthy",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 3,
                    UserName = "Mobile Lab",
                    Title = "Dog Coding",
                    URL = "/assetst/pic003.JPG",
                    Comments = "I do odd jobs",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 4,
                    UserName = "OctoCat",
                    Title = "Teaching Code",
                    URL = "/assets/pic004.jpg",
                    Comments = "I watch while you code.",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 5,
                    UserName = "SeattleChemist",
                    Title = "Hood Time",
                    URL = "/assets/pic005.JPG",
                    Comments = "Such a reaction.",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 6,
                    UserName = "Hot Dog Champ",
                    Title = "Winning 1st",
                    URL = "C:/Users/casti/coding/codeFellows/code401/Lab-.Net-gram/NetGram/NetGram/wwwroot/Assets/pic006.jpg",
                    Comments = "I get paid to eat hot dogs.",
                    Views = 1
                }
                );
        }

        public DbSet<WorkGram> WorkGrams { get; set; }
    }
}
