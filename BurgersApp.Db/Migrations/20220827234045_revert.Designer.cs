﻿// <auto-generated />
using System;
using BurgersApp.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgersApp.Db.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220827234045_revert")]
    partial class revert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgersApp.Domain.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BurgerQuantityForOrder")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasMaxLength(512)
                        .HasColumnType("int");

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasMaxLength(512)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2022%2F03%2F11%2F49404-Juiciest-Hamburgers-Ever-mfs-052.jpg",
                            Ingredients = "Gluten free bun with seeds, Beef burger, Chicken ham slice, Vegetables(lettuce, tomato and pickle, Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Hamburger",
                            Price = 120
                        },
                        new
                        {
                            Id = 2,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://cdn.hswstatic.com/gif/cheeseburger-1.jpg",
                            Ingredients = "Gluten free bun with seeds, Beef burger, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Cheeseburger",
                            Price = 140
                        },
                        new
                        {
                            Id = 3,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://images-gmi-pmc.edge-generalmills.com/35268f51-42c0-40ec-9ce2-5ec8f689ebad.jpg",
                            Ingredients = "Gluten free bun with seeds, Beef burger, Bacon, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Baconburger",
                            Price = 130
                        },
                        new
                        {
                            Id = 4,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://www.chatelaine.com/wp-content/uploads/2020/06/CHE07_WEB_FD_BURGERS_1280x960_STEAKANDEGG.jpg",
                            Ingredients = "Gluten free bun with seeds, Beef burger, Chicken ham slice, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Eggburger",
                            Price = 150
                        },
                        new
                        {
                            Id = 5,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://thescranline.com/wp-content/uploads/2022/02/crispy-chicken-burger-WEB-01.jpg",
                            Ingredients = "Gluten free bun with seeds, Batter fried chicken fillet, Chicken ham slice, Melted cheddar, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Crispy Chicken",
                            Price = 150
                        },
                        new
                        {
                            Id = 6,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://images-gmi-pmc.edge-generalmills.com/00556a9b-e367-47d6-8fa8-33d1de78ae65.jpg",
                            Ingredients = "Gluten free bun with seeds, Chicken fillet, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Chicken Sandwich",
                            Price = 120
                        },
                        new
                        {
                            Id = 7,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://c8.alamy.com/comp/D1WJRT/cut-out-of-double-hamburger-D1WJRT.jpg",
                            Ingredients = "Gluten free bun with seeds, Two beef burgers, Chicken ham slice, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "x2burger",
                            Price = 160
                        },
                        new
                        {
                            Id = 8,
                            BurgerQuantityForOrder = 0,
                            Category = 1,
                            HasFries = false,
                            ImgSrc = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F19%2F2015%2F06%2F22%2Fclean-veggie-burgers-ck.jpg&q=60",
                            Ingredients = "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Vegetarian Burger",
                            Price = 120
                        },
                        new
                        {
                            Id = 9,
                            BurgerQuantityForOrder = 0,
                            Category = 1,
                            HasFries = false,
                            ImgSrc = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F9%2F2021%2F07%2F13%2FUltimate-Veggie-Burgers-FT-Recipe-0821.jpg&q=60",
                            Ingredients = "Gluten free bun with seeds, Soybean burger, Mushrooms, Melted cheddar cheese, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Vegetarian Cheeseburger",
                            Price = 140
                        },
                        new
                        {
                            Id = 10,
                            BurgerQuantityForOrder = 0,
                            Category = 1,
                            HasFries = false,
                            ImgSrc = "https://images.ctfassets.net/lzukox2jf57a/2QwanILGms0aw04S4k4E6s/aa64ac85fe171a3ee616799b127fe366/optimized-fried_egg_burger-4.jpg?fm=jpg&fl=progressive&q=90&fit=crop&w=1679&h=1118",
                            Ingredients = "Gluten free bun with seeds, Soybean burger, Mushrooms, Fried egg, Vegetables(lettuce, tomato and pickle), Sauces",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Vegetarian Eggburger",
                            Price = 150
                        },
                        new
                        {
                            Id = 11,
                            BurgerQuantityForOrder = 0,
                            Category = 2,
                            HasFries = false,
                            ImgSrc = "https://www.myfoodandhappiness.com/wp-content/uploads/2017/08/The-Green-Warrior-Burger-2.jpg",
                            Ingredients = "Gluten free bun with seeds, Soybean burger, Mushrooms, Vegetables(lettuce, tomato and pickle), Vegan sauces",
                            IsVegan = true,
                            IsVegetarian = true,
                            Name = "Vegan Burger",
                            Price = 120
                        },
                        new
                        {
                            Id = 12,
                            BurgerQuantityForOrder = 0,
                            Category = 2,
                            HasFries = false,
                            ImgSrc = "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg",
                            Ingredients = "Gluten free bun with seeds, Soybean burger, Mushrooms, Tofu cheese, Vegetables(lettuce, tomato and pickle), Vegan sauces",
                            IsVegan = true,
                            IsVegetarian = true,
                            Name = "Vegan Cheeseburger",
                            Price = 150
                        },
                        new
                        {
                            Id = 13,
                            BurgerQuantityForOrder = 0,
                            Category = 0,
                            HasFries = false,
                            ImgSrc = "https://shivanilovesfood.com/wp-content/uploads/2019/08/Crispy-Tofu-Burgers-1.jpg",
                            Ingredients = "test",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "forcrudtesting",
                            Price = 9999
                        });
                });

            modelBuilder.Entity("BurgersApp.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("ClosesAt")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("OpensAt")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Boulevard Ilirija 9999, Tetovo",
                            ClosesAt = "23:00",
                            Name = "PseudoBurgers Tetovo",
                            OpensAt = "09:00"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Gjorche Petrov 9999, Gjorche Petrov, Skopje",
                            ClosesAt = "22:00",
                            Name = "PseudoBurgers Gjorche Petrov",
                            OpensAt = "10:00"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Boulevard Partizanski Odredi 9999, Center, Skopje",
                            ClosesAt = "00:00",
                            Name = "PseudoBurgers Center",
                            OpensAt = "08:00"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Boulevard Jane Sandanski 9999, Aerodrom, Skopje",
                            ClosesAt = "00:00",
                            Name = "PseudoBurgers Aerodrom",
                            OpensAt = "09:00"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Boulevard Turistichka 9999, Ohrid",
                            ClosesAt = "00:00",
                            Name = "PseudoBurgers Ohrid",
                            OpensAt = "08:00"
                        },
                        new
                        {
                            Id = 6,
                            Address = "ForCRUDTesting",
                            ClosesAt = "test",
                            Name = "ForCRUDTesting",
                            OpensAt = "test"
                        });
                });

            modelBuilder.Entity("BurgersApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgersApp.Domain.Models.Burger", b =>
                {
                    b.HasOne("BurgersApp.Domain.Models.Order", null)
                        .WithMany("Burgers")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("BurgersApp.Domain.Models.Order", b =>
                {
                    b.HasOne("BurgersApp.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BurgersApp.Domain.Models.Order", b =>
                {
                    b.Navigation("Burgers");
                });
#pragma warning restore 612, 618
        }
    }
}
