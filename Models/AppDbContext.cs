using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.IO;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;

namespace eTickets.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Hero_Movie>().HasKey(am => new
            {
                am.HeroId,
                am.MovieId
            });

            modelBuilder.Entity<Hero_Movie>().HasOne(m => m.Movie).WithMany(am => am.Heroes_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Hero_Movie>().HasOne(m => m.Hero).WithMany(am => am.Heroes_Movies).HasForeignKey(m => m.HeroId);


            //  data for Hero
            modelBuilder.Entity<Hero>().HasData(
            new Hero
            {
                Id = 1,
                ProfilePictureURL = "Tom Hardy.jfif",
                FullName = "Tom Hardy",
                Biography = @"Tom Hardy, an English actor renowned for his versatility, 
     captivates audiences with his intense performances."

            },
           new Hero
           {
               Id = 2,
               ProfilePictureURL = "Jonah Hill.jfif",
               FullName = "Jonah Hill",
               Biography = @"Jonah Hill is an American actor acclaimed for comedic brilliance,' 
    seamlessly transitioning to riveting dramatic roles '"
           },


           new Hero
           {
               Id = 3,
               ProfilePictureURL = "Michael Cera.jfif",
               FullName = "Michael Cera",
               Biography = @"Michael Cera is a Canadian actor known for his endearing awkwardness and comedic timing, 
     harming audiences in films."
           },
           new Hero
           {
               Id = 4,
               ProfilePictureURL = "Tim Robbins.jfif",
               FullName = "Tim Robbins",
               Biography = @"Tim Robbins is an American actor recognized for his roles 
    in 'The Shawshank Redemption' and 'Mystic River,'showcasing his versatility and depth as a performer."
           },
           new Hero
           {
               Id = 5,
               ProfilePictureURL = "Morgan Freeman.jfif",
               FullName = "Morgan Freeman",
               Biography = @"Morgan Freeman is an iconic American actor known for his authoritative presence 
    and memorable performances in films."
           },

           new Hero
           {
               Id = 6,
               ProfilePictureURL = "Tom Hanks.jfif",
               FullName = "Tom Hanks",
               Biography = @"Tom Hanks is an iconic American actor celebrated for his versatility 
    and captivating performances."
           },
           new Hero
           {
               Id = 7,
               ProfilePictureURL = "Tim Allen.jfif",
               FullName = "Tim Allen",
               Biography = @"Tim Allen is an American actor known for his comedic talent."
           },
           new Hero
           {
               Id = 8,
               ProfilePictureURL = "Jack Nicholson.jfif",
               FullName = "Jack Nicholson",
               Biography = @"Jack Nicholson is a legendary American actor known for his iconic roles 
   ,'captivating audiences with his intense performances and unique on-screen presence."
           },
           new Hero
           {
               Id = 9,
               ProfilePictureURL = "Christian Bale.jfif",
               FullName = "Christian Bale",
               Biography = @"Christian Bale, a British actor, embodies characters with remarkable intensity and commitment, 
     showcasing his range from iconic superhero roles to complex, psychologically rich performances."
           },
           new Hero
           {
               Id = 10,
               ProfilePictureURL = "Bradley Cooper.jfif",
               FullName = "Bradley Cooper",
               Biography = @"Bradley Cooper is an American actor known for his versatility, 
    starring in acclaimed films ,"

           },
           new Hero
           {
               Id = 11,
               ProfilePictureURL = "Ed Helms.jfif",
               FullName = "Ed Helms",
               Biography = @"Ed Helms, an American actor, is celebrated for his comedic talent, portraying Stu in 'The Hangover' 
     trilogy and Andy Bernard in 'The Office,'showcasing his versatile and humorous performances."
           },
           new Hero
           {
               Id = 12,
               ProfilePictureURL = "Zach Galifianakis.jfif",
               FullName = "Zach Galifianakis",
               Biography = @"Zach Galifianakis is an American actor known for his eccentric comedic style, 
    particularly in films."
           },

           new Hero
           {
               Id = 13,
               ProfilePictureURL = "Fred Rogers.jfif",
               FullName = " Fred Rogers",
               Biography = @" Fred Rogers, his gentle demeanor and compassionate spirit enriched the hearts of viewers 
    through 'Mister Rogers' Neighborhood,' fostering kindness and empathy in generations of children and adults alike."
           }

            );

            //  data for Producer
            modelBuilder.Entity<Producer>().HasData(


           new Producer
           {
               Id = 1,
               ProfilePictureURL = "George Miller.jfif",
               FullName = "George Miller",
               Biography = @"George Miller  is an Australian filmmaker celebrated for directing the groundbreaking 
    'Mad Max' series, showcasing his visionary storytelling and influence in the action genre."
           },
           new Producer
           {
               Id = 2,
               ProfilePictureURL = "Judd Apatow.jfif",
               FullName = "Judd Apatow",
               Biography = @"Judd Apatow is an American filmmaker known for his comedic genius, directing 
    and producing hit comedies."
           },
           new Producer
           {
               Id = 3,
               ProfilePictureURL = "Niki Marvin.jfif",
               FullName = "Niki Marvin",
               Biography = @"Niki Marvin, a film producer, has garnered acclaim for her work,
    demonstrating a keen eye for talent and a commitment to bringing compelling stories to the screen."







           },
           new Producer
           {
               Id = 4,
               ProfilePictureURL = "Luc Jacquet.jfif",
               FullName = "Luc Jacquet",
               Biography = @"Luc Jacquet is a French filmmaker acclaimed for his captivating nature documentaries, notably the 
    Academy Award-winning 'March of the Penguins.'"
           },


           new Producer
           {
               Id = 5,
               ProfilePictureURL = "Pixar Animation Studios.jfif",
               FullName = "Pixar Animation Studios",
               Biography = @"Pixar Animation Studios is a renowned animation studio celebrated for its revolutionary storytelling 
    and groundbreaking computer-animated films, captivating audiences worldwide with its imaginative and heartfelt storytelling."
           },
           new Producer
           {
               Id = 6,
               ProfilePictureURL = "Stanley Kubrick.jfif",
               FullName = "Stanley Kubrick",
               Biography = @"Stanley Kubrick was a visionary filmmaker renowned for his meticulous attention to detail and profound 
    storytelling, creating cinematic masterpieces ."
           },
           new Producer
           {
               Id = 7,
               ProfilePictureURL = "Christopher Nolan.jfif",
               FullName = "Christopher Nolan",
               Biography = @"Christopher Nolan is a visionary filmmaker celebrated for his innovative storytelling and captivating 
    narratives, directing iconic films ."
           },
           new Producer
           {
               Id = 8,
               ProfilePictureURL = "Todd Phillips.jfif",
               FullName = "Todd Phillips",
               Biography = @"Todd Phillips, a filmmaker known for his edgy comedies,
    rose to prominence with 'The Hangover' trilogy,
    showcasing his unique blend of humor and storytelling prowess."
           },
           new Producer
           {
               Id = 9,
               ProfilePictureURL = "Wendy Finerman.jfif",
               FullName = "Wendy Finerman",
               Biography = @"Wendy Finerman, a renowned film producer, 
    has earned accolades for her exceptional storytelling and her ability to bring compelling narratives to life on the big screen."
           },
           new Producer
           {
               Id = 10,
               ProfilePictureURL = "Morgan Neville.jfif",
               FullName = "Morgan Neville",
               Biography = @"Morgan Neville, a renowned documentary filmmaker, captures the essence of his subjects,
    crafting compelling narratives that resonate globally."
           }


            );

            // data for Cinema
            modelBuilder.Entity<Cinema>().HasData(
            new Cinema
            {
                Id = 1,
                Logo = "Multiplex Cinemas.jfif",
                Name = "Multiplex Cinemas",
                Description = @"You can watch all types of movies including horror.
     They typically have multiple screens and show a wide variety of films."
            },

            new Cinema
            {
                Id = 2,
                Logo = "Independent Cinemas.jfif",
                Name = "Independent Cinemas",
                Description = @"Independent cinemas, 
      tucked in local neighborhoods, 
      curate diverse films beyond blockbusters, 
     fostering community and showcasing thought-provoking cinema."

            },

           new Cinema
           {
               Id = 3,
               Logo = "IMAX Theaters.jfif",
               Name = "IMAX Theaters",
               Description = @"IMAX theaters are known for their large screens and immersive sound systems, 
    making them ideal for action-packed movies.'"
           },

           new Cinema
           {
               Id = 4,
               Logo = "Specialty Cinemas.jfif",
               Name = "Specialty Cinemas",
               Description = @"Some cinemas specialize in specific genres or types of films,
     such as comedy clubs for comedy movies and art-house theaters for indie and foreign films."
           },
           new Cinema
           {
               Id = 5,
               Logo = "Children's Cinemas.jfif",
               Name = "Children's Cinemas",
               Description = @"Movies like 'Toy Story' are popular choices for children's cinemas,
     which cater to families and young audiences with kid-friendly amenities and activities."
           },


           new Cinema
           {
               Id = 6,
               Logo = "Drive-In Cinemas.jfif",
               Name = "Drive-In Cinemas",
               Description = @"Drive-in cinemas offer a nostalgic outdoor movie-watching experience,
    ideal for enjoying films comfortably from your car."
           }




             );

            // data for Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "Mad Max",
                    Description = @"Mad Max:Fury Road is an intense action film set in a post-apocalyptic world, 
         where a reluctant hero and a fierce warrior rebel against a tyrannical ruler in a high-octane battle for survival.",
                    Price = 10.0,
                    ImageURL = "Mad Max.jfif",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(8),
                    MovieCategory = MovieCategory.Action,
                    CinemaId = 3,
                    ProducerId = 1
                },

            new Movie
            {
                Id = 2,
                Name = "Superbad",
                Description = @"Superbad is a hilarious coming-of-age comedy film about two high school friends
     on a wild adventure to secure alcohol for a party, leading to outrageous antics and unexpected challenges.",
                Price = 20.0,
                ImageURL = "Superbad.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(12),
                MovieCategory = MovieCategory.Comedy,
                CinemaId = 4,
                ProducerId = 2
            },

            new Movie
            {
                Id = 3,
                Name = "The Shawshank Redemption",
                Description = @"The Shawshank Redemption follows Andy Dufresne, a banker wrongfully convicted of murder,
    as he navigates prison life, finding solace and redemption through perseverance and friendship.",
                Price = 30.0,
                ImageURL = "The Shawshank Redemption.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(58),
                MovieCategory = MovieCategory.Drama,
                CinemaId = 2,
                ProducerId = 3
            },


            new Movie
            {
                Id = 4,
                Name = "March of the Penguins",
                Description = @"March of the Penguins is a captivating documentary showcasing the journey of emperor penguins in the Antarctic,
    revealing their resilience and determination in extreme conditions.",
                Price = 20.0,
                ImageURL = "March of the Penguins.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(38),
                MovieCategory = MovieCategory.Documentary,
                CinemaId = 2,
                ProducerId = 4
            },
            new Movie
            {
                Id = 5,
                Name = "Toy Story",
                Description = @"Toy Story is a heartwarming animated adventure film following the journey 
    of toys led by Woody and Buzz Lightyear.",
                Price = 20.0,
                ImageURL = "Toy Story.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(48),
                MovieCategory = MovieCategory.Cartoon,
                CinemaId = 5,
                ProducerId = 5
            },

            new Movie
            {
                Id = 6,
                Name = "The Shining",
                Description = @"The Shining is a psychological horror film directed by Stanley Kubrick, 
    adapted from Stephen King's novel.",
                Price = 20.0,
                ImageURL = "The Shining.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(36),
                MovieCategory = MovieCategory.Horror,
                CinemaId = 1,
                ProducerId = 6
            },
            new Movie
            {
                Id = 7,
                Name = "The Dark Knight",
                Description = @"The Dark Knight is a thrilling superhero epic pitting Batman against the Joker,
    featuring Heath Ledger's iconic portrayal.",
                Price = 150.0,
                ImageURL = "The Dark Knight.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(18),
                MovieCategory = MovieCategory.Action,
                CinemaId = 3,
                ProducerId = 7
            },
            new Movie
            {
                Id = 8,
                Name = "The Hangover",
                Description = @"The Hangover is a raucous comedy following a wild bachelor party in Las Vegas,
     as the groomsmen attempt to piece together the events of the night before.",
                Price = 90.0,
                ImageURL = "The Hangover.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(25),
                MovieCategory = MovieCategory.Comedy,
                CinemaId = 4,
                ProducerId = 8
            },
            new Movie
            {
                Id = 9,
                Name = "Forrest Gump",
                Description = @"Forrest Gump is a heartwarming tale following the remarkable life of Forrest Gump, 
    a simple yet extraordinary man who unwittingly finds himself at the center of key moments in American history.",
                Price = 10.0,
                ImageURL = "Forrest Gump.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7),
                MovieCategory = MovieCategory.Drama,
                CinemaId = 2,
                ProducerId = 9
            },
            new Movie
            {
                Id = 10,
                Name = "Won't You Be My Neighbor?",
                Description = @"Won't You Be My Neighbor? is a heartfelt documentary exploring Fred Rogers' legacy,
    celebrating his message of kindness and empathy in ""Mister Rogers' Neighborhood.",
                Price = 20.0,
                ImageURL = "Won't_You_Be_My_Neighbor.jfif",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(28),
                MovieCategory = MovieCategory.Documentary,
                CinemaId = 2,
                ProducerId = 10
            }


                        );
            // Data for Hero_Movie relationship
            modelBuilder.Entity<Hero_Movie>().HasData(
                // Hero 1 is associated with Movie 1
                new Hero_Movie { HeroId = 1, MovieId = 1 },

                // Hero 2 and Hero 3 are associated with Movie 2
                new Hero_Movie { HeroId = 2, MovieId = 2 },
                new Hero_Movie { HeroId = 3, MovieId = 2 },

                // Hero 7 and Hero 5 are associated with Movie 3
                new Hero_Movie { HeroId = 7, MovieId = 3 },
                new Hero_Movie { HeroId = 5, MovieId = 3 },

                // Hero 5 is associated with Movie 4
                new Hero_Movie { HeroId = 5, MovieId = 4 },

                // Hero 7 and Hero 6 are associated with Movie 5
                new Hero_Movie { HeroId = 7, MovieId = 5 },
                new Hero_Movie { HeroId = 6, MovieId = 5 },

                // Hero 8 is associated with Movie 6
                new Hero_Movie { HeroId = 8, MovieId = 6 },

                // Hero 9 is associated with Movie 7
                new Hero_Movie { HeroId = 9, MovieId = 7 },

                // Hero 10, Hero 11, and Hero 12 are associated with Movie 8
                new Hero_Movie { HeroId = 10, MovieId = 8 },
                new Hero_Movie { HeroId = 11, MovieId = 8 },
                new Hero_Movie { HeroId = 12, MovieId = 8 },

                // Hero 6 is associated with Movie 9
                new Hero_Movie { HeroId = 6, MovieId = 9 },

                // Hero 13 is associated with Movie 10
                new Hero_Movie { HeroId = 13, MovieId = 10 }
            );


            modelBuilder.Entity<PrivacyPolicy>().HasData(new PrivacyPolicy
            {
                Id = 1,
                Content = @"
        <p>This Privacy Policy outlines how eTicket Movies collects, uses, maintains, and protects personal identification information obtained from users during the purchase of movie tickets and related services on our website.</p>

        <h3>Collection of Personal Identification Information:</h3>

        <p>We may collect personal identification information from users in various ways, including but not limited to, when users visit our site, register on the site, place an order, subscribe to the newsletter, respond to a survey, fill out a form, and in connection with other activities, services, features, or resources we make available on our site. Users may be asked for, as appropriate, name, email address, mailing address, phone number, and credit card information.</p>

        <h3>Use of Personal Identification Information:</h3>

        <p>We collect and use users' personal information for the following purposes:</p>
        <ul>
            <li><strong>To process transactions:</strong> We may use the information users provide about themselves when placing an order only to provide service to that order. We do not share this information with outside parties except to the extent necessary to provide the service.</li>
            <li><strong>To send periodic emails:</strong> We may use the email address to send users information and updates pertaining to their order. It may also be used to respond to their inquiries, questions, and/or other requests. If users decide to opt-in to our mailing list, they will receive emails that may include company news, updates, etc. If at any time the user would like to unsubscribe from receiving future emails, we include detailed unsubscribe instructions at the bottom of each email.</li>
        </ul>

        <h3>Protection of Personal Identification Information:</h3>

        <p>We adopt appropriate data collection and processing practices and security measures to protect against unauthorized access, alteration, disclosure, or destruction of users' personal information, username, password, transaction information, and data stored on our site.</p>
    "
            });
            base.OnModelCreating(modelBuilder);
        }
        

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Hero_Movie> Heroes_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }

    }
}
