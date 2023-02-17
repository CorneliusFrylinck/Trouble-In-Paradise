﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(BetaContext))]
    partial class BetaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("API.Domain.Base", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseX")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseY")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseX = 200,
                            BaseY = 200,
                            Created = new DateTime(2023, 2, 17, 18, 42, 56, 431, DateTimeKind.Utc).AddTicks(632),
                            Description = "Just a test bois",
                            Name = "Base 1"
                        });
                });

            modelBuilder.Entity("API.Domain.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BaseId");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseId = 1,
                            Description = "This is your center of communication. Upgrading this building can also unlock new options on other buildings.",
                            Level = 1,
                            Name = "Command Centre"
                        },
                        new
                        {
                            Id = 2,
                            BaseId = 1,
                            Description = "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.",
                            Level = 1,
                            Name = "Guild Hub"
                        },
                        new
                        {
                            Id = 3,
                            BaseId = 1,
                            Description = "This is where you build your army. Build units and assign them to squads.",
                            Level = 1,
                            Name = "Barracks"
                        },
                        new
                        {
                            Id = 4,
                            BaseId = 1,
                            Description = "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.",
                            Level = 1,
                            Name = "Warroom"
                        },
                        new
                        {
                            Id = 5,
                            BaseId = 1,
                            Description = "This building is used to view the area around you.",
                            Level = 1,
                            Name = "Navigational Unit"
                        },
                        new
                        {
                            Id = 6,
                            BaseId = 1,
                            Description = "This building picks up enemy attacks and any troop movement to your base.",
                            Level = 1,
                            Name = "Radar"
                        },
                        new
                        {
                            Id = 7,
                            BaseId = 1,
                            Description = "This building is used to heal your troops after they get hurt.",
                            Level = 1,
                            Name = "Medical Facility"
                        },
                        new
                        {
                            Id = 8,
                            BaseId = 1,
                            Description = "This building is used to unlock new units and abilities.",
                            Level = 1,
                            Name = "Research Facility"
                        },
                        new
                        {
                            Id = 9,
                            BaseId = 1,
                            Description = "This building is used to send resources to other players.",
                            Level = 1,
                            Name = "Tradepost"
                        },
                        new
                        {
                            Id = 10,
                            BaseId = 1,
                            Description = "This building is used to trade resources with locals of the new planet.",
                            Level = 1,
                            Name = "Market"
                        },
                        new
                        {
                            Id = 11,
                            BaseId = 1,
                            Description = "Upgrade these buildings to increase your resource storage capabilities.",
                            Level = 1,
                            Name = "Silos"
                        },
                        new
                        {
                            Id = 12,
                            BaseId = 1,
                            Description = "These buildings are used to protect your resources from raiders.",
                            Level = 1,
                            Name = "Vaults"
                        },
                        new
                        {
                            Id = 13,
                            BaseId = 1,
                            Description = "These buildings offer protection to your ranged units when defending.",
                            Level = 1,
                            Name = "Bunkers"
                        },
                        new
                        {
                            Id = 14,
                            BaseId = 1,
                            Description = "Your shield offers all units and buildings protection when you are being attacked.",
                            Level = 1,
                            Name = "Shield"
                        });
                });

            modelBuilder.Entity("API.Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EventOccurrence")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RelatedId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("API.Domain.ResourceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ProductionSpeed")
                        .HasColumnType("REAL");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BaseId");

                    b.ToTable("ResourceItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Cement",
                            ProductionSpeed = 1000.0,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and units..",
                            Level = 0,
                            Name = "Metal",
                            ProductionSpeed = 1000.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Lumber",
                            ProductionSpeed = 1000.0,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Water",
                            ProductionSpeed = 1000.0,
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            BaseId = 1,
                            Description = "Resource used to keep units and workers alive.",
                            Level = 0,
                            Name = "Food",
                            ProductionSpeed = 1000.0,
                            Type = 4
                        },
                        new
                        {
                            Id = 6,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Oxygen",
                            ProductionSpeed = 1000.0,
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Crystal_Blue",
                            ProductionSpeed = 1000.0,
                            Type = 6
                        },
                        new
                        {
                            Id = 8,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Crystal_Red",
                            ProductionSpeed = 1000.0,
                            Type = 7
                        },
                        new
                        {
                            Id = 9,
                            BaseId = 1,
                            Description = "Resource rarely found in mines. Used to queue building and unit upgrades",
                            Level = 0,
                            Name = "Gold",
                            ProductionSpeed = 50.0,
                            Type = 8
                        },
                        new
                        {
                            Id = 10,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Cement",
                            ProductionSpeed = 1000.0,
                            Type = 1
                        },
                        new
                        {
                            Id = 11,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and units..",
                            Level = 0,
                            Name = "Metal",
                            ProductionSpeed = 1000.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 12,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Lumber",
                            ProductionSpeed = 1000.0,
                            Type = 2
                        },
                        new
                        {
                            Id = 13,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Water",
                            ProductionSpeed = 1000.0,
                            Type = 3
                        },
                        new
                        {
                            Id = 14,
                            BaseId = 1,
                            Description = "Resource used to keep units and workers alive.",
                            Level = 0,
                            Name = "Food",
                            ProductionSpeed = 1000.0,
                            Type = 4
                        },
                        new
                        {
                            Id = 15,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings.",
                            Level = 0,
                            Name = "Oxygen",
                            ProductionSpeed = 1000.0,
                            Type = 5
                        },
                        new
                        {
                            Id = 16,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Crystal_Blue",
                            ProductionSpeed = 1000.0,
                            Type = 6
                        },
                        new
                        {
                            Id = 17,
                            BaseId = 1,
                            Description = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.",
                            Level = 0,
                            Name = "Crystal_Red",
                            ProductionSpeed = 1000.0,
                            Type = 7
                        },
                        new
                        {
                            Id = 18,
                            BaseId = 1,
                            Description = "Resource rarely found in mines. Used to queue building and unit upgrades",
                            Level = 0,
                            Name = "Gold",
                            ProductionSpeed = 50.0,
                            Type = 8
                        });
                });

            modelBuilder.Entity("API.Domain.ResourceStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cement")
                        .HasColumnType("REAL");

                    b.Property<double>("Crystal_Blue")
                        .HasColumnType("REAL");

                    b.Property<double>("Crystal_Red")
                        .HasColumnType("REAL");

                    b.Property<double>("Food")
                        .HasColumnType("REAL");

                    b.Property<double>("Gold")
                        .HasColumnType("REAL");

                    b.Property<double>("Lumber")
                        .HasColumnType("REAL");

                    b.Property<double>("Metal")
                        .HasColumnType("REAL");

                    b.Property<double>("Oxygen")
                        .HasColumnType("REAL");

                    b.Property<double>("Water")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("BaseId")
                        .IsUnique();

                    b.ToTable("ResourceStores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseId = 1,
                            Cement = 3000.0,
                            Crystal_Blue = 3000.0,
                            Crystal_Red = 3000.0,
                            Food = 3000.0,
                            Gold = 1000.0,
                            Lumber = 3000.0,
                            Metal = 3000.0,
                            Oxygen = 3000.0,
                            Water = 3000.0
                        });
                });

            modelBuilder.Entity("API.Domain.Building", b =>
                {
                    b.HasOne("API.Domain.Base", null)
                        .WithMany("Buildings")
                        .HasForeignKey("BaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Domain.ResourceItem", b =>
                {
                    b.HasOne("API.Domain.Base", null)
                        .WithMany("ResourceBuildings")
                        .HasForeignKey("BaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Domain.ResourceStore", b =>
                {
                    b.HasOne("API.Domain.Base", null)
                        .WithOne("Resources")
                        .HasForeignKey("API.Domain.ResourceStore", "BaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Domain.Base", b =>
                {
                    b.Navigation("Buildings");

                    b.Navigation("ResourceBuildings");

                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
