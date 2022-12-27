﻿// <auto-generated />
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(FootballAnalysisContext))]
    partial class FootballAnalysisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.MatchScore", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpponentScore")
                        .HasColumnType("int");

                    b.Property<int>("SeasonID")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SeasonID");

                    b.ToTable("MatchScores");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Season", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Champion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoalKing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoalKingScore")
                        .HasColumnType("int");

                    b.Property<int>("SeasonYear")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TeamInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("InUrlTeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InUrlTeamNumber")
                        .HasColumnType("int");

                    b.Property<string>("RealTeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TeamInfos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MatchScore", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Season", "Season")
                        .WithMany("MatchScore")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Season", b =>
                {
                    b.Navigation("MatchScore");
                });
#pragma warning restore 612, 618
        }
    }
}
