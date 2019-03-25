﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using petsrus;

namespace petsrus.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190325154012_AddPetsAndShelters")]
    partial class AddPetsAndShelters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PetsRUs.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<DateTime?>("DateAdopted");

                    b.Property<DateTime>("DateArrived");

                    b.Property<bool>("GoodWithKids");

                    b.Property<bool>("IsAdopted");

                    b.Property<string>("Name");

                    b.Property<int>("ShelterId");

                    b.Property<string>("Species");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetsRUs.Models.Shelter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("AdoptionFee");

                    b.Property<int>("CurrentCapacity");

                    b.Property<bool>("IsNoKill");

                    b.Property<int>("MaxCapacity");

                    b.Property<string>("Name");

                    b.Property<string>("PrimaryContactName");

                    b.Property<string>("PrimaryContactPhone");

                    b.HasKey("Id");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("PetsRUs.Models.Pet", b =>
                {
                    b.HasOne("PetsRUs.Models.Shelter", "Shelter")
                        .WithMany("Pets")
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
