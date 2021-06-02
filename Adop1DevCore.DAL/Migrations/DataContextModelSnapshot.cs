﻿// <auto-generated />
using System;
using Adop1DevCore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adop1DevCore.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryId");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SalaryId");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.SalaryUser", b =>
                {
                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.HasKey("SalaryId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SalaryUser");

                    b.HasCheckConstraint("CK_Amount", "Amount >0");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SkillId");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.SkillUser", b =>
                {
                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("SkillId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SkillUser");

                    b.HasCheckConstraint("CK_Level", "Level >0");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasCheckConstraint("CK_Email", "Email LIKE '_%@_%'");
                });

            modelBuilder.Entity("CategorySkill", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsSkillId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "SkillsSkillId");

                    b.HasIndex("SkillsSkillId");

                    b.ToTable("CategorySkill");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.SalaryUser", b =>
                {
                    b.HasOne("Adop1DevCore.DAL.Entities.Salary", "Salary")
                        .WithMany("SalariesUser")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adop1DevCore.DAL.Entities.User", "User")
                        .WithMany("SalariesUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salary");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.SkillUser", b =>
                {
                    b.HasOne("Adop1DevCore.DAL.Entities.Skill", "Skill")
                        .WithMany("SkillsUser")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adop1DevCore.DAL.Entities.User", "User")
                        .WithMany("SKillsUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CategorySkill", b =>
                {
                    b.HasOne("Adop1DevCore.DAL.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adop1DevCore.DAL.Entities.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.Salary", b =>
                {
                    b.Navigation("SalariesUser");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.Skill", b =>
                {
                    b.Navigation("SkillsUser");
                });

            modelBuilder.Entity("Adop1DevCore.DAL.Entities.User", b =>
                {
                    b.Navigation("SalariesUser");

                    b.Navigation("SKillsUser");
                });
#pragma warning restore 612, 618
        }
    }
}
