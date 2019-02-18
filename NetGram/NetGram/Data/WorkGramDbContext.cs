using Microsoft.EntityFrameworkCore;
using NetGram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
                    UserName = "User Holder",
                    Title = "Some Title",
                    URL = "https://via.placeholder.com/150",
                    Comments = "ROAR",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 2,
                    UserName = "UserOne",
                    Title = "Friend Coding",
                    URL = "https://via.placeholder.com/450",
                    Comments = "Hack the world",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 3,
                    UserName = "User Doc",
                    Title = "Doctor in office",
                    URL = "https://via.placeholder.com/250",
                    Comments = "Making you healthy",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 4,
                    UserName = "Mobile Lab",
                    Title = "Dog Coding",
                    URL = "https://via.placeholder.com/450",
                    Comments = "I do odd jobs",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 5,
                    UserName = "OctoCat",
                    Title = "Teaching Code",
                    URL = "https://via.placeholder.com/400",
                    Comments = "I watch while you code.",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 6,
                    UserName = "SeattleChemist",
                    Title = "Hood Time",
                    URL = "https://via.placeholder.com/350",
                    Comments = "Such a reaction.",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 7,
                    UserName = "Hot Dog Champ",
                    Title = "Winning 1st",
                    URL = "https://via.placeholder.com/150/0000FF/808080?Text=!PlaceHolder!",
                    Comments = "I get paid to eat hot dogs.",
                    Views = 1
                },
                new WorkGram
                {
                    ID = 8,
                    UserName = "number 8",
                    Title = "Losing 1st",
                    URL = "https://via.placeholder.com/250",
                    Comments = "7th place",
                    Views = 1
                }
                );
        }

        public DbSet<WorkGram> WorkGrams { get; set; }
    }
}
