﻿// <auto-generated />
using System;
using API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(BetaContext))]
    [Migration("20230218203910_Added-Resource-Seed-Data")]
    partial class AddedResourceSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Created = new DateTime(2023, 2, 18, 20, 39, 9, 344, DateTimeKind.Utc).AddTicks(2953),
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
                            Level = 1,
                            Name = "Command Centre"
                        },
                        new
                        {
                            Id = 2,
                            BaseId = 1,
                            Level = 1,
                            Name = "Guild Hub"
                        },
                        new
                        {
                            Id = 3,
                            BaseId = 1,
                            Level = 1,
                            Name = "Barracks"
                        },
                        new
                        {
                            Id = 4,
                            BaseId = 1,
                            Level = 1,
                            Name = "Warroom"
                        },
                        new
                        {
                            Id = 5,
                            BaseId = 1,
                            Level = 1,
                            Name = "Navigational Unit"
                        },
                        new
                        {
                            Id = 6,
                            BaseId = 1,
                            Level = 1,
                            Name = "Radar"
                        },
                        new
                        {
                            Id = 7,
                            BaseId = 1,
                            Level = 1,
                            Name = "Medical Facility"
                        },
                        new
                        {
                            Id = 8,
                            BaseId = 1,
                            Level = 1,
                            Name = "Research Facility"
                        },
                        new
                        {
                            Id = 9,
                            BaseId = 1,
                            Level = 1,
                            Name = "Tradepost"
                        },
                        new
                        {
                            Id = 10,
                            BaseId = 1,
                            Level = 1,
                            Name = "Market"
                        },
                        new
                        {
                            Id = 11,
                            BaseId = 1,
                            Level = 1,
                            Name = "Silos"
                        },
                        new
                        {
                            Id = 12,
                            BaseId = 1,
                            Level = 1,
                            Name = "Vaults"
                        },
                        new
                        {
                            Id = 13,
                            BaseId = 1,
                            Level = 1,
                            Name = "Bunkers"
                        },
                        new
                        {
                            Id = 14,
                            BaseId = 1,
                            Level = 1,
                            Name = "Shield"
                        });
                });

            modelBuilder.Entity("API.Domain.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Descriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "cement",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings."
                        },
                        new
                        {
                            Id = 2,
                            Name = "metal",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings, and units.."
                        },
                        new
                        {
                            Id = 3,
                            Name = "lumber",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings."
                        },
                        new
                        {
                            Id = 4,
                            Name = "water",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional."
                        },
                        new
                        {
                            Id = 5,
                            Name = "food",
                            Type = 0,
                            Value = "Resource used to keep units and workers alive."
                        },
                        new
                        {
                            Id = 6,
                            Name = "oxygen",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings."
                        },
                        new
                        {
                            Id = 7,
                            Name = "blue_crystal",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional."
                        },
                        new
                        {
                            Id = 8,
                            Name = "red_crystal",
                            Type = 0,
                            Value = "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional. This resource is poweful but difficult to find and mine."
                        },
                        new
                        {
                            Id = 9,
                            Name = "gold",
                            Type = 0,
                            Value = "Resource rarely found in mines. Used to queue building and unit upgrades"
                        },
                        new
                        {
                            Id = 10,
                            Name = "command centre",
                            Type = 1,
                            Value = "This is your center of communication. Upgrading this building can also unlock new options on other buildings."
                        },
                        new
                        {
                            Id = 11,
                            Name = "guild hub",
                            Type = 1,
                            Value = "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions."
                        },
                        new
                        {
                            Id = 12,
                            Name = "barracks",
                            Type = 1,
                            Value = "This is where you build your army. Build units and assign them to squads."
                        },
                        new
                        {
                            Id = 13,
                            Name = "warroom",
                            Type = 1,
                            Value = "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger."
                        },
                        new
                        {
                            Id = 14,
                            Name = "navigational unit",
                            Type = 1,
                            Value = "This building is used to view the area around you."
                        },
                        new
                        {
                            Id = 15,
                            Name = "radar",
                            Type = 1,
                            Value = "This building picks up enemy attacks and any troop movement to your base."
                        },
                        new
                        {
                            Id = 16,
                            Name = "medical facility",
                            Type = 1,
                            Value = "This building is used to heal your troops after they get hurt."
                        },
                        new
                        {
                            Id = 17,
                            Name = "research facility",
                            Type = 1,
                            Value = "This building is used to unlock new units and abilities."
                        },
                        new
                        {
                            Id = 18,
                            Name = "tradepost",
                            Type = 1,
                            Value = "This building is used to send resources to other players."
                        },
                        new
                        {
                            Id = 19,
                            Name = "market",
                            Type = 1,
                            Value = "This building is used to trade resources with locals of the new planet."
                        },
                        new
                        {
                            Id = 20,
                            Name = "silos",
                            Type = 1,
                            Value = "Upgrade these buildings to increase your resource storage capabilities."
                        },
                        new
                        {
                            Id = 21,
                            Name = "vaults",
                            Type = 1,
                            Value = "These buildings are used to protect your resources from raiders."
                        },
                        new
                        {
                            Id = 22,
                            Name = "bunkers",
                            Type = 1,
                            Value = "These buildings offer protection to your ranged units when defending."
                        },
                        new
                        {
                            Id = 23,
                            Name = "shield",
                            Type = 1,
                            Value = "Your shield offers all units and buildings protection when you are being attacked."
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
                            Level = 0,
                            Name = "Cement",
                            ProductionSpeed = 1000.0,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            BaseId = 1,
                            Level = 0,
                            Name = "Metal",
                            ProductionSpeed = 1000.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            BaseId = 1,
                            Level = 0,
                            Name = "Lumber",
                            ProductionSpeed = 1000.0,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            BaseId = 1,
                            Level = 0,
                            Name = "Water",
                            ProductionSpeed = 1000.0,
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            BaseId = 1,
                            Level = 0,
                            Name = "Food",
                            ProductionSpeed = 1000.0,
                            Type = 4
                        },
                        new
                        {
                            Id = 6,
                            BaseId = 1,
                            Level = 0,
                            Name = "Oxygen",
                            ProductionSpeed = 1000.0,
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            BaseId = 1,
                            Level = 0,
                            Name = "Blue_Crystal",
                            ProductionSpeed = 1000.0,
                            Type = 6
                        },
                        new
                        {
                            Id = 8,
                            BaseId = 1,
                            Level = 0,
                            Name = "Red_Crystal",
                            ProductionSpeed = 1000.0,
                            Type = 7
                        },
                        new
                        {
                            Id = 9,
                            BaseId = 1,
                            Level = 0,
                            Name = "Gold",
                            ProductionSpeed = 50.0,
                            Type = 8
                        },
                        new
                        {
                            Id = 10,
                            BaseId = 1,
                            Level = 0,
                            Name = "Cement",
                            ProductionSpeed = 1000.0,
                            Type = 1
                        },
                        new
                        {
                            Id = 11,
                            BaseId = 1,
                            Level = 0,
                            Name = "Metal",
                            ProductionSpeed = 1000.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 12,
                            BaseId = 1,
                            Level = 0,
                            Name = "Lumber",
                            ProductionSpeed = 1000.0,
                            Type = 2
                        },
                        new
                        {
                            Id = 13,
                            BaseId = 1,
                            Level = 0,
                            Name = "Water",
                            ProductionSpeed = 1000.0,
                            Type = 3
                        },
                        new
                        {
                            Id = 14,
                            BaseId = 1,
                            Level = 0,
                            Name = "Food",
                            ProductionSpeed = 1000.0,
                            Type = 4
                        },
                        new
                        {
                            Id = 15,
                            BaseId = 1,
                            Level = 0,
                            Name = "Oxygen",
                            ProductionSpeed = 1000.0,
                            Type = 5
                        },
                        new
                        {
                            Id = 16,
                            BaseId = 1,
                            Level = 0,
                            Name = "Blue_Crystal",
                            ProductionSpeed = 1000.0,
                            Type = 6
                        },
                        new
                        {
                            Id = 17,
                            BaseId = 1,
                            Level = 0,
                            Name = "Red_Crystal",
                            ProductionSpeed = 1000.0,
                            Type = 7
                        },
                        new
                        {
                            Id = 18,
                            BaseId = 1,
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

                    b.Property<double>("Blue_Crystal")
                        .HasColumnType("REAL");

                    b.Property<double>("Cement")
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

                    b.Property<double>("Red_Crystal")
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
                            Blue_Crystal = 3000.0,
                            Cement = 3000.0,
                            Food = 3000.0,
                            Gold = 1000.0,
                            Lumber = 3000.0,
                            Metal = 3000.0,
                            Oxygen = 3000.0,
                            Red_Crystal = 3000.0,
                            Water = 3000.0
                        });
                });

            modelBuilder.Entity("API.Domain.UpgradeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Blue_CrystalCost")
                        .HasColumnType("REAL");

                    b.Property<double>("CementCost")
                        .HasColumnType("REAL");

                    b.Property<double>("FoodCost")
                        .HasColumnType("REAL");

                    b.Property<double>("GoldCost")
                        .HasColumnType("REAL");

                    b.Property<double>("LevelCostMultiplier")
                        .HasColumnType("REAL");

                    b.Property<double>("LumberCost")
                        .HasColumnType("REAL");

                    b.Property<int>("MaxLevel")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MetalCost")
                        .HasColumnType("REAL");

                    b.Property<double>("OxygenCost")
                        .HasColumnType("REAL");

                    b.Property<double>("ProductionAfterUpgrade")
                        .HasColumnType("REAL");

                    b.Property<double>("Red_CrystalCost")
                        .HasColumnType("REAL");

                    b.Property<int>("UpgradeTarget")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UpgradeTimeInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<double>("WaterCost")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("UpgradeDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Blue_CrystalCost = 1000.0,
                            CementCost = 400.0,
                            FoodCost = 670.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 320.0,
                            MaxLevel = 40,
                            MetalCost = 700.0,
                            OxygenCost = 550.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 140.0,
                            UpgradeTarget = 6,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 800.0
                        },
                        new
                        {
                            Id = 2,
                            Blue_CrystalCost = 1800.0,
                            CementCost = 600.0,
                            FoodCost = 530.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 590.0,
                            MaxLevel = 40,
                            MetalCost = 900.0,
                            OxygenCost = 580.0,
                            ProductionAfterUpgrade = 300.0,
                            Red_CrystalCost = 200.0,
                            UpgradeTarget = 7,
                            UpgradeTimeInSeconds = 20,
                            WaterCost = 910.0
                        },
                        new
                        {
                            Id = 3,
                            Blue_CrystalCost = 1200.0,
                            CementCost = 860.0,
                            FoodCost = 550.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 300.0,
                            MaxLevel = 40,
                            MetalCost = 520.0,
                            OxygenCost = 500.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 170.0,
                            UpgradeTarget = 0,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 600.0
                        },
                        new
                        {
                            Id = 4,
                            Blue_CrystalCost = 1250.0,
                            CementCost = 350.0,
                            FoodCost = 600.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 350.0,
                            MaxLevel = 40,
                            MetalCost = 930.0,
                            OxygenCost = 540.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 140.0,
                            UpgradeTarget = 1,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 550.0
                        },
                        new
                        {
                            Id = 5,
                            Blue_CrystalCost = 1100.0,
                            CementCost = 400.0,
                            FoodCost = 270.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 360.0,
                            MaxLevel = 40,
                            MetalCost = 430.0,
                            OxygenCost = 790.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 100.0,
                            UpgradeTarget = 4,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 900.0
                        },
                        new
                        {
                            Id = 6,
                            Blue_CrystalCost = 1150.0,
                            CementCost = 440.0,
                            FoodCost = 890.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 480.0,
                            MaxLevel = 40,
                            MetalCost = 550.0,
                            OxygenCost = 760.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 200.0,
                            UpgradeTarget = 2,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 450.0
                        },
                        new
                        {
                            Id = 7,
                            Blue_CrystalCost = 1300.0,
                            CementCost = 490.0,
                            FoodCost = 620.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 560.0,
                            MaxLevel = 40,
                            MetalCost = 660.0,
                            OxygenCost = 650.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 160.0,
                            UpgradeTarget = 3,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 390.0
                        },
                        new
                        {
                            Id = 8,
                            Blue_CrystalCost = 1400.0,
                            CementCost = 520.0,
                            FoodCost = 400.0,
                            GoldCost = 0.0,
                            LevelCostMultiplier = 1.0,
                            LumberCost = 530.0,
                            MaxLevel = 40,
                            MetalCost = 780.0,
                            OxygenCost = 300.0,
                            ProductionAfterUpgrade = 1000.0,
                            Red_CrystalCost = 110.0,
                            UpgradeTarget = 5,
                            UpgradeTimeInSeconds = 10,
                            WaterCost = 640.0
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