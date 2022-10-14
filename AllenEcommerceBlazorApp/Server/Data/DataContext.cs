    using System;
namespace AllenEcommerceBlazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        //seeding table on SQL
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId , ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
               .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });



            modelBuilder.Entity<ProductType>().HasData(
                     new ProductType { Id = 1, Name = "Default" },
                     new ProductType { Id = 2, Name = "Paperback" },
                     new ProductType { Id = 3, Name = "E-Book" },
                     new ProductType { Id = 4, Name = "Comics" },
                     new ProductType { Id = 5, Name = "Stream" },
                     new ProductType { Id = 6, Name = "Blu-ray" },
                     new ProductType { Id = 7, Name = "VHS" },
                     new ProductType { Id = 8, Name = "PC" },
                     new ProductType { Id = 9, Name = "PlayStation" },
                     new ProductType { Id = 10, Name = "Xbox" }
                 );


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                 new Category
                 {
                     Id = 2,
                     Name = "Movies",
                     Url = "movies"
                 },
                  new Category
                  {
                      Id = 3,
                      Name = "Video Games",
                      Url = "video-games"
                  }
                );

            modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         Title = "The Hunger Games",
                         Description = "The Hunger Games is a 2008 dystopian novel by the American writer Suzanne Collins. It is written in the perspective of 16-year-old Katniss Everdeen, who lives in the future, post-apocalyptic nation of Panem in North America. The Capitol, a highly advanced metropolis, exercises political control over the rest of the nation. The Hunger Games is an annual event in which one boy and one girl aged 12–18 from each of the twelve districts surrounding the Capitol are selected by lottery to compete in a televised battle royale to the death.",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/dc/The_Hunger_Games.jpg",
                         Featured = true,
                  
                         CategoryId = 1
                     },
                     new Product
                     {
                         Id = 2,
                         Title = "Where the Crawdads Sing",
                         Description = "Where the Crawdads Sing is a 2018 coming-of-age[2][3][4] murder mystery[3] novel by American author Delia Owens.[5] The story follows two timelines that slowly intertwine. The first timeline describes the life and adventures of a young girl named Kya as she grows up isolated in the marshes of North Carolina. The second timeline follows an investigation into the apparent murder of Chase Andrews, a local celebrity of Barkley Cove, a fictional coastal town of North Carolina.[1][5][6]",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Where_The_Crawdads_Sing_Book_Cover.jpg",
                        
                         CategoryId = 1
                     }, new Product
                     {
                         Id = 3,
                         Title = "The Great Gatsby",
                         Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/440px-The_Great_Gatsby_Cover_1925_Retouched.jpg",
                       
                         CategoryId = 1
                     },
                     new Product
                     {
                         Id = 4,
                         CategoryId = 2,
                         Title = "The Matrix",
                         Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                         Featured = true
          
                     },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Title = "Back to the Future",
                        Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                      

                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        Title = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                      

                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                       

                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                      
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                        Featured = true
                     

                    },
                    new Product
                    {
                        Id = 10,
                        CategoryId = 3,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                       
                    },
                    new Product
                    {
                        Id = 11,
                        CategoryId = 3,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                      
                    }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
             new ProductVariant
             {
                 ProductId = 1,
                 ProductTypeId = 2,
                 Price = 1999.99m,
                 OriginalPrice = 2999.99m
             },
             new ProductVariant
             {
                 ProductId = 1,
                 ProductTypeId = 3,
                 Price = 3007.99m
             },
             new ProductVariant
             {
                 ProductId = 1,
                 ProductTypeId = 4,
                 Price = 3009.99m,
                 OriginalPrice = 4229.99m
             },
             new ProductVariant
             {
                 ProductId = 2,
                 ProductTypeId = 2,
                 Price = 5007.99m,
                 OriginalPrice = 7314.99m
             },
             new ProductVariant
             {
                 ProductId = 3,
                 ProductTypeId = 2,
                 Price = 3006.99m
             },
             new ProductVariant
             {
                 ProductId = 4,
                 ProductTypeId = 5,
                 Price = 2390.99m
             },
             new ProductVariant
             {
                 ProductId = 4,
                 ProductTypeId = 6,
                 Price = 9000.99m
             },
             new ProductVariant
             {
                 ProductId = 4,
                 ProductTypeId = 7,
                 Price = 1019.99m
             },
             new ProductVariant
             {
                 ProductId = 5,
                 ProductTypeId = 5,
                 Price = 3000.99m,
             },
             new ProductVariant
             {
                 ProductId = 6,
                 ProductTypeId = 5,
                 Price = 4000.99m
             },
             new ProductVariant
             {
                 ProductId = 7,
                 ProductTypeId = 8,
                 Price = 1009.99m,
                 OriginalPrice = 2009.99m
             },
             new ProductVariant
             {
                 ProductId = 7,
                 ProductTypeId = 9,
                 Price = 3069.99m
             },
             new ProductVariant
             {
                 ProductId = 7,
                 ProductTypeId = 10,
                 Price = 4009.99m,
                 OriginalPrice = 5009.99m
             },
             new ProductVariant
             {
                 ProductId = 8,
                 ProductTypeId = 8,
                 Price = 1009.99m,
                 OriginalPrice = 2004.99m,
             },
             new ProductVariant
             {
                 ProductId = 9,
                 ProductTypeId = 8,
                 Price = 1004.99m
             },
             new ProductVariant
             {
                 ProductId = 10,
                 ProductTypeId = 1,
                 Price = 10259.99m,
                 OriginalPrice = 15299m
             },
             new ProductVariant
             {
                 ProductId = 11,
                 ProductTypeId = 1,
                 Price = 8000.99m,
                 OriginalPrice = 9399m
             }
         );


        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<ProductVariant> ProductVariants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }


        public DbSet<Address> Addresses { get; set; }
    }
}

