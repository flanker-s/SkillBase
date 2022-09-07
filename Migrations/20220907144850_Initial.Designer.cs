﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillBase.Data;

#nullable disable

namespace SkillBase.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220907144850_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("SkillBase.Models.ReferenceUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SkillId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("ReferenceUrl");
                });

            modelBuilder.Entity("SkillBase.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("SkillBase.Models.ReferenceUrl", b =>
                {
                    b.HasOne("SkillBase.Models.Skill", null)
                        .WithMany("References")
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("SkillBase.Models.Skill", b =>
                {
                    b.HasOne("SkillBase.Models.Skill", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SkillBase.Models.Skill", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("References");
                });
#pragma warning restore 612, 618
        }
    }
}
