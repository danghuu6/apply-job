﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apply_job_web_api.Models;

#nullable disable

namespace apply_job_web_api.Migrations
{
    [DbContext(typeof(ApplyJobWebApiDbContext))]
    partial class ApplyJobWebApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("apply_job_web_api.Models.Entities.ApplyJob", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("currentSalary")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("expectedSalary")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("resumFile")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("applyJobs");
                });

            modelBuilder.Entity("apply_job_web_api.Models.Entities.Job", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("apply_job_web_api.Models.Entities.ApplyJob", b =>
                {
                    b.HasOne("apply_job_web_api.Models.Entities.Job", "job")
                        .WithMany("applyJobs")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("job");
                });

            modelBuilder.Entity("apply_job_web_api.Models.Entities.Job", b =>
                {
                    b.Navigation("applyJobs");
                });
#pragma warning restore 612, 618
        }
    }
}
