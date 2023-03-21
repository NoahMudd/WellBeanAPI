﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WellBeanAPI.Data;

#nullable disable

namespace WellBeanAPI.Migrations
{
    [DbContext(typeof(WellBeanAPIDbContext))]
    [Migration("20230320220505_Fixed MinExercised")]
    partial class FixedMinExercised
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WellBeanAPI.Models.Survey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DidYouWork")
                        .HasColumnType("bit");

                    b.Property<int>("DietRating")
                        .HasColumnType("int");

                    b.Property<int>("HoursSlept")
                        .HasColumnType("int");

                    b.Property<int>("MinutesExercised")
                        .HasColumnType("int");

                    b.Property<int>("OzWater")
                        .HasColumnType("int");

                    b.Property<DateTime>("SurveyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WellbeingRating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
