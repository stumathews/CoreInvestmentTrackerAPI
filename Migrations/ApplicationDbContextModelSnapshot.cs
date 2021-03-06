﻿// <auto-generated />
using System;
using CoreInvestmentTracker.Models.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoreInvestmentTracker.Migrations
{
    [DbContext(typeof(InvestmentDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CoreInvestmentTracker.Models.CustomEntity_Investment", b =>
                {
                    b.Property<int>("InvestmentID");

                    b.Property<int>("CustomEntityId");

                    b.HasKey("InvestmentID", "CustomEntityId")
                        .HasName("PrimaryKey_InvestmentID_CustomEntityID");

                    b.HasIndex("CustomEntityId");

                    b.ToTable("CustomEntity_Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.CustomEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<int?>("CustomEntityTypeId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<int?>("OwningCustomEntityId");

                    b.Property<int>("OwningEntityId");

                    b.Property<int>("OwningEntityType");

                    b.Property<long>("Points");

                    b.HasKey("Id")
                        .HasName("PrimaryKey_Id_CustomEntityTypeId");

                    b.HasIndex("CustomEntityTypeId");

                    b.HasIndex("OwningCustomEntityId");

                    b.ToTable("CustomEntities");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.CustomEntityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<int>("DataType");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.HasKey("Id");

                    b.ToTable("CustomEntityTypes");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<float>("Currency");

                    b.Property<string>("Description");

                    b.Property<string>("DesirabilityStatement");

                    b.Property<float>("InitialInvestment");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.Property<string>("Symbol");

                    b.Property<float>("Value");

                    b.Property<string>("ValueProposition");

                    b.HasKey("Id");

                    b.ToTable("Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.InvestmentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<long>("Points");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.InvestmentNote", b =>
                {
                    b.Property<int>("OwningEntityId");

                    b.Property<int>("OwningEntityType");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.HasKey("OwningEntityId", "OwningEntityType", "Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.InvestmentTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Commission");

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Currency");

                    b.Property<string>("Description");

                    b.Property<int>("InvestmentId");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumUnits");

                    b.Property<long>("Points");

                    b.Property<float>("PricePerUnit");

                    b.Property<DateTimeOffset>("TransactionDate");

                    b.Property<string>("TransactionType");

                    b.HasKey("Id")
                        .HasName("PrimaryKey_Id");

                    b.HasAlternateKey("Name");

                    b.HasIndex("InvestmentId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.RecordedActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OwningEntityId");

                    b.Property<int>("OwningEntityType");

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<string>("Details");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.Property<string>("Tag");

                    b.Property<int?>("UserId");

                    b.HasKey("Id", "OwningEntityId", "OwningEntityType")
                        .HasName("PrimaryKey_Id_OwningEntityId_OwningEntityType");

                    b.HasIndex("UserId");

                    b.ToTable("RecordedActivities");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<long>("Points");

                    b.Property<int>("TimeZone");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentGroup_Investment", b =>
                {
                    b.Property<int>("InvestmentID");

                    b.Property<int>("InvestmentGroupID");

                    b.HasKey("InvestmentID", "InvestmentGroupID")
                        .HasName("PrimaryKey_InvestmentID_InvestmentGroupID");

                    b.HasIndex("InvestmentGroupID");

                    b.ToTable("InvestmentGroup_Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentInfluenceFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<string>("Influence");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.HasKey("Id");

                    b.ToTable("InvestmentInfluenceFactor");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentInfluenceFactor_Investment", b =>
                {
                    b.Property<int>("InvestmentID");

                    b.Property<int>("InvestmentInfluenceFactorID");

                    b.HasKey("InvestmentID", "InvestmentInfluenceFactorID")
                        .HasName("PrimaryKey_InvestmentID_InvestmentInfluenceFactorID");

                    b.HasIndex("InvestmentInfluenceFactorID");

                    b.ToTable("InvestmentInfluenceFactor_Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentRisk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Risks");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentRisk_Investment", b =>
                {
                    b.Property<int>("InvestmentID");

                    b.Property<int>("InvestmentRiskID");

                    b.HasKey("InvestmentID", "InvestmentRiskID")
                        .HasName("PrimaryKey_InvestmentID_InvestmentRiskID");

                    b.HasIndex("InvestmentRiskID");

                    b.ToTable("InvestmentRisk_Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsFlagged");

                    b.Property<DateTimeOffset>("LastModifiedTime");

                    b.Property<string>("Name");

                    b.Property<long>("Points");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.Region_Investment", b =>
                {
                    b.Property<int>("InvestmentID");

                    b.Property<int>("RegionID");

                    b.HasKey("InvestmentID", "RegionID")
                        .HasName("PrimaryKey_InvestmentID_RegionID");

                    b.HasIndex("RegionID");

                    b.ToTable("Region_Investment");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.CustomEntity_Investment", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.CustomEntity", "CustomEntity")
                        .WithMany("Investments")
                        .HasForeignKey("CustomEntityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment", "Investment")
                        .WithMany("CustomEntities")
                        .HasForeignKey("InvestmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.CustomEntity", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.CustomEntityType", "CustomEntityType")
                        .WithMany()
                        .HasForeignKey("CustomEntityTypeId");

                    b.HasOne("CoreInvestmentTracker.Models.DEL.CustomEntity", "OwningCustomEntity")
                        .WithMany("Associations")
                        .HasForeignKey("OwningCustomEntityId");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.InvestmentGroup", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.InvestmentGroup", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.InvestmentTransaction", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment")
                        .WithMany("Transactions")
                        .HasForeignKey("InvestmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.DEL.RecordedActivity", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentGroup_Investment", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.InvestmentGroup", "InvestmentGroup")
                        .WithMany("Investments")
                        .HasForeignKey("InvestmentGroupID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment", "Investment")
                        .WithMany("Groups")
                        .HasForeignKey("InvestmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentInfluenceFactor_Investment", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment", "Investment")
                        .WithMany("Factors")
                        .HasForeignKey("InvestmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreInvestmentTracker.Models.InvestmentInfluenceFactor", "InvestmentInfluenceFactor")
                        .WithMany("Investments")
                        .HasForeignKey("InvestmentInfluenceFactorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.InvestmentRisk_Investment", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment", "Investment")
                        .WithMany("Risks")
                        .HasForeignKey("InvestmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreInvestmentTracker.Models.InvestmentRisk", "InvestmentRisk")
                        .WithMany("Investments")
                        .HasForeignKey("InvestmentRiskID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreInvestmentTracker.Models.Region_Investment", b =>
                {
                    b.HasOne("CoreInvestmentTracker.Models.DEL.Investment", "Investment")
                        .WithMany("Regions")
                        .HasForeignKey("InvestmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreInvestmentTracker.Models.Region", "Region")
                        .WithMany("Investments")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
