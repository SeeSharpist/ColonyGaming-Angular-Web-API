﻿// <auto-generated />
using ColonyGaming_Angular_Web_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ColonyGaming_Angular_Web_API.Migrations
{
    [DbContext(typeof(ContactAppContext))]
    partial class ContactAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ColonyGaming_Angular_Web_API.Models.Contact", b =>
                {
                    b.Property<long?>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("birth");

                    b.Property<string>("email");

                    b.Property<byte>("gender");

                    b.Property<string>("message");

                    b.Property<string>("name");

                    b.Property<string>("techno");

                    b.HasKey("id");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
