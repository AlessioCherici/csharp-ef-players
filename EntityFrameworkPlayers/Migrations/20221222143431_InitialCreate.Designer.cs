﻿// <auto-generated />
using EntityFrameworkPlayers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkPlayers.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20221222143431_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkPlayers.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerID"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartiteGiocate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartiteVinte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerID");

                    b.HasIndex("PlayerID")
                        .IsUnique();

                    b.ToTable("player");
                });
#pragma warning restore 612, 618
        }
    }
}
