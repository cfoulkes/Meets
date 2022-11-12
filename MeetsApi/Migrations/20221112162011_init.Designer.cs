﻿// <auto-generated />
using System;
using MeetsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MeetsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221112162011_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MeetsApi.Data.Models.Attendee", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<int>("MeetingId")
                        .HasColumnType("integer");

                    b.HasKey("MemberId", "MeetingId");

                    b.HasIndex("MeetingId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("MeetsApi.Data.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ScheduledAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("MeetsApi.Data.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MeetsApi.Data.Models.Attendee", b =>
                {
                    b.HasOne("MeetsApi.Data.Models.Meeting", "Meeting")
                        .WithMany()
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetsApi.Data.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MeetsApi.Data.Models.Meeting", b =>
                {
                    b.HasOne("MeetsApi.Data.Models.Member", "Creator")
                        .WithMany("Meetings")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("MeetsApi.Data.Models.Member", b =>
                {
                    b.Navigation("Meetings");
                });
#pragma warning restore 612, 618
        }
    }
}