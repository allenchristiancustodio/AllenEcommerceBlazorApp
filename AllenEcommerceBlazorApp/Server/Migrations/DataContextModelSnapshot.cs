﻿// <auto-generated />
using AllenEcommerceBlazorApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllenEcommerceBlazorApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AllenEcommerceBlazorApp.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Hunger Games is a 2008 dystopian novel by the American writer Suzanne Collins. It is written in the perspective of 16-year-old Katniss Everdeen, who lives in the future, post-apocalyptic nation of Panem in North America. The Capitol, a highly advanced metropolis, exercises political control over the rest of the nation. The Hunger Games is an annual event in which one boy and one girl aged 12–18 from each of the twelve districts surrounding the Capitol are selected by lottery to compete in a televised battle royale to the death.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/dc/The_Hunger_Games.jpg",
                            Price = 5000.13m,
                            Title = "The Hunger Games"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Where the Crawdads Sing is a 2018 coming-of-age[2][3][4] murder mystery[3] novel by American author Delia Owens.[5] The story follows two timelines that slowly intertwine. The first timeline describes the life and adventures of a young girl named Kya as she grows up isolated in the marshes of North Carolina. The second timeline follows an investigation into the apparent murder of Chase Andrews, a local celebrity of Barkley Cove, a fictional coastal town of North Carolina.[1][5][6]",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Where_The_Crawdads_Sing_Book_Cover.jpg",
                            Price = 3999.99m,
                            Title = "Where the Crawdads Sing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/440px-The_Great_Gatsby_Cover_1925_Retouched.jpg",
                            Price = 1999.99m,
                            Title = "The Great Gatsby"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
