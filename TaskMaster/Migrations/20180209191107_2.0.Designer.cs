﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TaskMaster.Data;

namespace TaskMaster.Migrations
{
    [DbContext(typeof(TaskItemsDbContext))]
    [Migration("20180209191107_2.0")]
    partial class _20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskMaster.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TaskMaster.Models.TaskCategoryAssoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<int>("TaskItem");

                    b.HasKey("Id");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("TaskMaster.Models.TaskItem", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<long>("DueBy");

                    b.Property<long>("RemindAt");

                    b.HasKey("Id");

                    b.ToTable("TaskItems");
                });
#pragma warning restore 612, 618
        }
    }
}
