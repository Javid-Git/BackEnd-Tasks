﻿// <auto-generated />
using System;
using Front_To_Back_practice.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Front_To_Back_practice.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220525201433_Team_Position")]
    partial class Team_Position
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Front_To_Back_practice.Models.PlanItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanItems");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.PricingPlanItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlanItemId")
                        .HasColumnType("int");

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanItemId");

                    b.HasIndex("PricingId");

                    b.ToTable("PricingPlanItems");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.PricingPlanItem", b =>
                {
                    b.HasOne("Front_To_Back_practice.Models.PlanItem", "PlanItem")
                        .WithMany("PricingPlanItems")
                        .HasForeignKey("PlanItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Front_To_Back_practice.Models.Pricing", "Pricing")
                        .WithMany("PricingPlanItems")
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Front_To_Back_practice.Models.Team", b =>
                {
                    b.HasOne("Front_To_Back_practice.Models.Position", "Position")
                        .WithMany("Teams")
                        .HasForeignKey("PositionId");
                });
#pragma warning restore 612, 618
        }
    }
}
