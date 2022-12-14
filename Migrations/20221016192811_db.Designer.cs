// <auto-generated />
using System;
using Blog.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace blogEmCSharp.Migrations
{
  [DbContext(typeof(BlogContext))]
  [Migration("20221016192811_db")]
  partial class db
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "6.0.10")
          .HasAnnotation("Relational:MaxIdentifierLength", 128);

      SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

      modelBuilder.Entity("Blog.Model.BlogPost", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            b.Property<string>("Content")
                      .IsRequired()
                      .HasColumnType("nvarchar(max)");

            b.Property<DateTime>("Published")
                      .HasColumnType("datetime2");

            b.Property<string>("Title")
                      .IsRequired()
                      .HasColumnType("nvarchar(max)");

            b.Property<DateTime>("Updated")
                      .HasColumnType("datetime2");

            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("BlogPosts");
          });

      modelBuilder.Entity("Blog.Model.Category", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            b.Property<string>("Name")
                      .IsRequired()
                      .HasMaxLength(30)
                      .HasColumnType("nvarchar(30)");

            b.HasKey("Id");

            b.ToTable("Categories");
          });

      modelBuilder.Entity("Blog.Model.PostCategories", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            b.Property<int>("CategoryId")
                      .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("PostCategories");
          });

      modelBuilder.Entity("Blog.Model.User", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            b.Property<string>("DisplayName")
                      .IsRequired()
                      .HasMaxLength(255)
                      .HasColumnType("nvarchar(255)");

            b.Property<string>("Email")
                      .IsRequired()
                      .HasMaxLength(255)
                      .HasColumnType("nvarchar(255)");

            b.Property<string>("Image")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Password")
                      .IsRequired()
                      .HasMaxLength(255)
                      .HasColumnType("nvarchar(255)");

            b.HasKey("Id");

            b.ToTable("Users");
          });
#pragma warning restore 612, 618
    }
  }
}
