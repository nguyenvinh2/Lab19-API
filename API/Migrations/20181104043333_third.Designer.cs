﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20181104043333_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.ToDoItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListID");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.HasIndex("ListID");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("API.Models.ToDoList", b =>
                {
                    b.Property<int>("ListID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ListName");

                    b.HasKey("ListID");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("API.Models.ToDoItem", b =>
                {
                    b.HasOne("API.Models.ToDoList", "ToDoListName")
                        .WithMany("ToDoItems")
                        .HasForeignKey("ListID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
