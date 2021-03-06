﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetGram.Data;

namespace NetGram.Migrations
{
    [DbContext(typeof(WorkGramDbContext))]
    [Migration("20190214185246_8th")]
    partial class _8th
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetGram.Models.WorkGram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<string>("Title");

                    b.Property<string>("URL");

                    b.Property<string>("UserName");

                    b.Property<int>("Views");

                    b.HasKey("ID");

                    b.ToTable("WorkGrams");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Comments = "ROAR",
                            Title = "Some Title",
                            URL = "https://via.placeholder.com/150",
                            UserName = "User Holder",
                            Views = 1
                        },
                        new
                        {
                            ID = 2,
                            Comments = "Hack the world",
                            Title = "Friend Coding",
                            URL = "/Assets/pic001.JPG",
                            UserName = "UserOne",
                            Views = 1
                        },
                        new
                        {
                            ID = 3,
                            Comments = "Making you healthy",
                            Title = "Doctor in office",
                            URL = "../Assets/pic002.jpg",
                            UserName = "User Doc",
                            Views = 1
                        },
                        new
                        {
                            ID = 4,
                            Comments = "I do odd jobs",
                            Title = "Dog Coding",
                            URL = "../../Assets/pic003.JPG",
                            UserName = "Mobile Lab",
                            Views = 1
                        },
                        new
                        {
                            ID = 5,
                            Comments = "I watch while you code.",
                            Title = "Teaching Code",
                            URL = "Assets/pic004.jpg",
                            UserName = "OctoCat",
                            Views = 1
                        },
                        new
                        {
                            ID = 6,
                            Comments = "Such a reaction.",
                            Title = "Hood Time",
                            URL = "pic005.JPG",
                            UserName = "SeattleChemist",
                            Views = 1
                        },
                        new
                        {
                            ID = 7,
                            Comments = "I get paid to eat hot dogs.",
                            Title = "Winning 1st",
                            URL = "https://via.placeholder.com/150/0000FF/808080?Text=!PlaceHolder!",
                            UserName = "Hot Dog Champ",
                            Views = 1
                        },
                        new
                        {
                            ID = 8,
                            Comments = "7th place",
                            Title = "Losing 1st",
                            URL = "https://via.placeholder.com/250",
                            UserName = "number 7",
                            Views = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
