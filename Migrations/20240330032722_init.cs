using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCategory = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heroes_Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes_Movies", x => new { x.HeroId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Heroes_Movies_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_Movies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "You can watch all types of movies including horror.\r\n     They typically have multiple screens and show a wide variety of films.", "Multiplex Cinemas.jfif", "Multiplex Cinemas" },
                    { 2, "Independent cinemas, \r\n      tucked in local neighborhoods, \r\n      curate diverse films beyond blockbusters, \r\n     fostering community and showcasing thought-provoking cinema.", "Independent Cinemas.jfif", "Independent Cinemas" },
                    { 3, "IMAX theaters are known for their large screens and immersive sound systems, \r\n    making them ideal for action-packed movies.'", "IMAX Theaters.jfif", "IMAX Theaters" },
                    { 4, "Some cinemas specialize in specific genres or types of films,\r\n     such as comedy clubs for comedy movies and art-house theaters for indie and foreign films.", "Specialty Cinemas.jfif", "Specialty Cinemas" },
                    { 5, "Movies like 'Toy Story' are popular choices for children's cinemas,\r\n     which cater to families and young audiences with kid-friendly amenities and activities.", "Children's Cinemas.jfif", "Children's Cinemas" },
                    { 6, "Drive-in cinemas offer a nostalgic outdoor movie-watching experience,\r\n    ideal for enjoying films comfortably from your car.", "Drive-In Cinemas.jfif", "Drive-In Cinemas" }
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Biography", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Tom Hardy, an English actor renowned for his versatility, \r\n     captivates audiences with his intense performances.", "Tom Hardy", "Tom Hardy.jfif" },
                    { 2, "Jonah Hill is an American actor acclaimed for comedic brilliance,' \r\n    seamlessly transitioning to riveting dramatic roles '", "Jonah Hill", "Jonah Hill.jfif" },
                    { 3, "Michael Cera is a Canadian actor known for his endearing awkwardness and comedic timing, \r\n     harming audiences in films.", "Michael Cera", "Michael Cera.jfif" },
                    { 4, "Tim Robbins is an American actor recognized for his roles \r\n    in 'The Shawshank Redemption' and 'Mystic River,'showcasing his versatility and depth as a performer.", "Tim Robbins", "Tim Robbins.jfif" },
                    { 5, "Morgan Freeman is an iconic American actor known for his authoritative presence \r\n    and memorable performances in films.", "Morgan Freeman", "Morgan Freeman.jfif" },
                    { 6, "Tom Hanks is an iconic American actor celebrated for his versatility \r\n    and captivating performances.", "Tom Hanks", "Tom Hanks.jfif" },
                    { 7, "Tim Allen is an American actor known for his comedic talent.", "Tim Allen", "Tim Allen.jfif" },
                    { 8, "Jack Nicholson is a legendary American actor known for his iconic roles \r\n   ,'captivating audiences with his intense performances and unique on-screen presence.", "Jack Nicholson", "Jack Nicholson.jfif" },
                    { 9, "Christian Bale, a British actor, embodies characters with remarkable intensity and commitment, \r\n     showcasing his range from iconic superhero roles to complex, psychologically rich performances.", "Christian Bale", "Christian Bale.jfif" },
                    { 10, "Bradley Cooper is an American actor known for his versatility, \r\n    starring in acclaimed films ,", "Bradley Cooper", "Bradley Cooper.jfif" },
                    { 11, "Ed Helms, an American actor, is celebrated for his comedic talent, portraying Stu in 'The Hangover' \r\n     trilogy and Andy Bernard in 'The Office,'showcasing his versatile and humorous performances.", "Ed Helms", "Ed Helms.jfif" },
                    { 12, "Zach Galifianakis is an American actor known for his eccentric comedic style, \r\n    particularly in films.", "Zach Galifianakis", "Zach Galifianakis.jfif" },
                    { 13, " Fred Rogers, his gentle demeanor and compassionate spirit enriched the hearts of viewers \r\n    through 'Mister Rogers' Neighborhood,' fostering kindness and empathy in generations of children and adults alike.", " Fred Rogers", "Fred Rogers.jfif" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Biography", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "George Miller  is an Australian filmmaker celebrated for directing the groundbreaking \r\n    'Mad Max' series, showcasing his visionary storytelling and influence in the action genre.", "George Miller", "George Miller.jfif" },
                    { 2, "Judd Apatow is an American filmmaker known for his comedic genius, directing \r\n    and producing hit comedies.", "Judd Apatow", "Judd Apatow.jfif" },
                    { 3, "Niki Marvin, a film producer, has garnered acclaim for her work,\r\n    demonstrating a keen eye for talent and a commitment to bringing compelling stories to the screen.", "Niki Marvin", "Niki Marvin.jfif" },
                    { 4, "Luc Jacquet is a French filmmaker acclaimed for his captivating nature documentaries, notably the \r\n    Academy Award-winning 'March of the Penguins.'", "Luc Jacquet", "Luc Jacquet.jfif" },
                    { 5, "Pixar Animation Studios is a renowned animation studio celebrated for its revolutionary storytelling \r\n    and groundbreaking computer-animated films, captivating audiences worldwide with its imaginative and heartfelt storytelling.", "Pixar Animation Studios", "Pixar Animation Studios.jfif" },
                    { 6, "Stanley Kubrick was a visionary filmmaker renowned for his meticulous attention to detail and profound \r\n    storytelling, creating cinematic masterpieces .", "Stanley Kubrick", "Stanley Kubrick.jfif" },
                    { 7, "Christopher Nolan is a visionary filmmaker celebrated for his innovative storytelling and captivating \r\n    narratives, directing iconic films .", "Christopher Nolan", "Christopher Nolan.jfif" },
                    { 8, "Todd Phillips, a filmmaker known for his edgy comedies,\r\n    rose to prominence with 'The Hangover' trilogy,\r\n    showcasing his unique blend of humor and storytelling prowess.", "Todd Phillips", "Todd Phillips.jfif" },
                    { 9, "Wendy Finerman, a renowned film producer, \r\n    has earned accolades for her exceptional storytelling and her ability to bring compelling narratives to life on the big screen.", "Wendy Finerman", "Wendy Finerman.jfif" },
                    { 10, "Morgan Neville, a renowned documentary filmmaker, captures the essence of his subjects,\r\n    crafting compelling narratives that resonate globally.", "Morgan Neville", "Morgan Neville.jfif" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 1, 3, "Mad Max:Fury Road is an intense action film set in a post-apocalyptic world, \r\n         where a reluctant hero and a fierce warrior rebel against a tyrannical ruler in a high-octane battle for survival.", new DateTime(2024, 4, 7, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2719), "Mad Max.jfif", 1, "Mad Max", 10.0, 1, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2709) },
                    { 2, 4, "Superbad is a hilarious coming-of-age comedy film about two high school friends\r\n     on a wild adventure to secure alcohol for a party, leading to outrageous antics and unexpected challenges.", new DateTime(2024, 4, 11, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2728), "Superbad.jfif", 2, "Superbad", 20.0, 2, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2727) },
                    { 3, 2, "The Shawshank Redemption follows Andy Dufresne, a banker wrongfully convicted of murder,\r\n    as he navigates prison life, finding solace and redemption through perseverance and friendship.", new DateTime(2024, 5, 27, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2731), "The Shawshank Redemption.jfif", 3, "The Shawshank Redemption", 30.0, 3, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2730) },
                    { 4, 2, "March of the Penguins is a captivating documentary showcasing the journey of emperor penguins in the Antarctic,\r\n    revealing their resilience and determination in extreme conditions.", new DateTime(2024, 5, 7, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2734), "March of the Penguins.jfif", 4, "March of the Penguins", 20.0, 4, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2733) },
                    { 5, 5, "Toy Story is a heartwarming animated adventure film following the journey \r\n    of toys led by Woody and Buzz Lightyear.", new DateTime(2024, 5, 17, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2736), "Toy Story.jfif", 5, "Toy Story", 20.0, 5, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2736) },
                    { 6, 1, "The Shining is a psychological horror film directed by Stanley Kubrick, \r\n    adapted from Stephen King's novel.", new DateTime(2024, 5, 5, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2739), "The Shining.jfif", 6, "The Shining", 20.0, 6, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2738) },
                    { 7, 3, "The Dark Knight is a thrilling superhero epic pitting Batman against the Joker,\r\n    featuring Heath Ledger's iconic portrayal.", new DateTime(2024, 4, 17, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2742), "The Dark Knight.jfif", 1, "The Dark Knight", 150.0, 7, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2741) },
                    { 8, 4, "The Hangover is a raucous comedy following a wild bachelor party in Las Vegas,\r\n     as the groomsmen attempt to piece together the events of the night before.", new DateTime(2024, 4, 24, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2744), "The Hangover.jfif", 2, "The Hangover", 90.0, 8, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2744) },
                    { 9, 2, "Forrest Gump is a heartwarming tale following the remarkable life of Forrest Gump, \r\n    a simple yet extraordinary man who unwittingly finds himself at the center of key moments in American history.", new DateTime(2024, 4, 6, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2747), "Forrest Gump.jfif", 3, "Forrest Gump", 10.0, 9, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2746) },
                    { 10, 2, "Won't You Be My Neighbor? is a heartfelt documentary exploring Fred Rogers' legacy,\r\n    celebrating his message of kindness and empathy in \"Mister Rogers' Neighborhood.", new DateTime(2024, 4, 27, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2750), "Won't_You_Be_My_Neighbor.jfif", 4, "Won't You Be My Neighbor?", 20.0, 10, new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2749) }
                });

            migrationBuilder.InsertData(
                table: "Heroes_Movies",
                columns: new[] { "HeroId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 6, 9 },
                    { 7, 3 },
                    { 7, 5 },
                    { 8, 6 },
                    { 9, 7 },
                    { 10, 8 },
                    { 11, 8 },
                    { 12, 8 },
                    { 13, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_Movies_MovieId",
                table: "Heroes_Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes_Movies");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
