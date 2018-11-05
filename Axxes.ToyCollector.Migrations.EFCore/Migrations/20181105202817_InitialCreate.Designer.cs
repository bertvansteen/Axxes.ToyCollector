﻿// <auto-generated />

using System;
using Axxes.ToyCollector.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Axxes.ToyCollector.Migrations.EFCore.Migrations
{
    [DbContext(typeof(ToyContext))]
    [Migration("20181105202817_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Axxes.ToyCollector.Core.Contracts.DataStructures.Toy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Toys");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Toy");
                });

            modelBuilder.Entity("Axxes.ToyCollector.Plugins.Lego.Models.LegoSet", b =>
                {
                    b.HasBaseType("Axxes.ToyCollector.Core.Contracts.DataStructures.Toy");

                    b.Property<DateTime?>("FinishedBuildDate")
                        .HasColumnType("date");

                    b.Property<string>("SetNumber")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("Unopened");

                    b.ToTable("LegoSet");

                    b.HasDiscriminator().HasValue("LegoSet");
                });

            modelBuilder.Entity("Axxes.ToyCollector.Plugins.Marbles.Models.Marble", b =>
                {
                    b.HasBaseType("Axxes.ToyCollector.Core.Contracts.DataStructures.Toy");

                    b.Property<int>("Diameter");

                    b.Property<bool>("SeeThrough")
                        .HasColumnName("Transparent");

                    b.ToTable("Marble");

                    b.HasDiscriminator().HasValue("Marble");
                });
#pragma warning restore 612, 618
        }
    }
}
