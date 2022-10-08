using System;
namespace AllenEcommerceBlazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         Title = "The Hunger Games",
                         Description = "The Hunger Games is a 2008 dystopian novel by the American writer Suzanne Collins. It is written in the perspective of 16-year-old Katniss Everdeen, who lives in the future, post-apocalyptic nation of Panem in North America. The Capitol, a highly advanced metropolis, exercises political control over the rest of the nation. The Hunger Games is an annual event in which one boy and one girl aged 12–18 from each of the twelve districts surrounding the Capitol are selected by lottery to compete in a televised battle royale to the death.",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/dc/The_Hunger_Games.jpg",
                         Price = 5000.13m
                     },
                     new Product
                     {
                         Id = 2,
                         Title = "Where the Crawdads Sing",
                         Description = "Where the Crawdads Sing is a 2018 coming-of-age[2][3][4] murder mystery[3] novel by American author Delia Owens.[5] The story follows two timelines that slowly intertwine. The first timeline describes the life and adventures of a young girl named Kya as she grows up isolated in the marshes of North Carolina. The second timeline follows an investigation into the apparent murder of Chase Andrews, a local celebrity of Barkley Cove, a fictional coastal town of North Carolina.[1][5][6]",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Where_The_Crawdads_Sing_Book_Cover.jpg",
                         Price = 3999.99m
                     }, new Product
                     {
                         Id = 3,
                         Title = "The Great Gatsby",
                         Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
                         ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/440px-The_Great_Gatsby_Cover_1925_Retouched.jpg",
                         Price = 1999.99m
                     }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}

