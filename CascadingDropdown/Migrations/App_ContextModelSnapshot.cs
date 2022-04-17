﻿// <auto-generated />
using System;
using CascadingDropdown.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CascadingDropdown.Migrations
{
    [DbContext(typeof(App_Context))]
    partial class App_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CascadingDropdown.Models.Cascade.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("stateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("stateId");

                    b.ToTable("tblCity");
                });

            modelBuilder.Entity("CascadingDropdown.Models.Cascade.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tblCountry");
                });

            modelBuilder.Entity("CascadingDropdown.Models.Cascade.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.ToTable("tblState");
                });

            modelBuilder.Entity("CascadingDropdown.Models.Cascade.City", b =>
                {
                    b.HasOne("CascadingDropdown.Models.Cascade.State", "state")
                        .WithMany()
                        .HasForeignKey("stateId");

                    b.Navigation("state");
                });

            modelBuilder.Entity("CascadingDropdown.Models.Cascade.State", b =>
                {
                    b.HasOne("CascadingDropdown.Models.Cascade.Country", "country")
                        .WithMany()
                        .HasForeignKey("countryId");

                    b.Navigation("country");
                });
#pragma warning restore 612, 618
        }
    }
}