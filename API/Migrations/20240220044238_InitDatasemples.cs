using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitDatasemples : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Runtime = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Plot = table.Column<string>(nullable: true),
                    PosterUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Casts_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 1, "Tim Burton", "A couple of recently deceased ghosts contract the services of a \"bio-exorcist\" in order to remove the obnoxious new owners of their house.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUwODE3MDE0MV5BMl5BanBnXkFtZTgwNTk1MjI4MzE@._V1_SX300.jpg", "92", "Beetlejuice", "1988" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 94, "Richard Attenborough", "Gandhi's character is fully explained as a man of nonviolence. Through his patience, he is able to drive the British out of the subcontinent. And the stubborn nature of Jinnah and his commitment towards Pakistan is portrayed.", "http://ia.media-imdb.com/images/M/MV5BMzJiZDRmOWUtYjE2MS00Mjc1LTg1ZDYtNTQxYWJkZTg1OTM4XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg", "191", "Gandhi", "1982" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 95, "Guillermo del Toro", "As a war between humankind and monstrous sea creatures wages on, a former pilot and a trainee are paired up to drive a seemingly obsolete special weapon in a desperate effort to save the world from the apocalypse.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY3MTI5NjQ4Nl5BMl5BanBnXkFtZTcwOTU1OTU0OQ@@._V1_SX300.jpg", "131", "Pacific Rim", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 96, "Shane Black", "A murder mystery brings together a private eye, a struggling actress, and a thief masquerading as an actor.", "http://ia.media-imdb.com/images/M/MV5BMTY5NDExMDA3M15BMl5BanBnXkFtZTYwNTc2MzA3._V1_SX300.jpg", "103", "Kiss Kiss Bang Bang", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 97, "Phillip Noyce", "An older British reporter vies with a young U.S. doctor for the affections of a beautiful Vietnamese woman.", "http://ia.media-imdb.com/images/M/MV5BMjE2NTUxNTE3Nl5BMl5BanBnXkFtZTYwNTczMTg5._V1_SX300.jpg", "101", "The Quiet American", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 98, "Tom Tykwer, Lana Wachowski, Lilly Wachowski", "An exploration of how the actions of individual lives impact one another in the past, present and future, as one soul is shaped from a killer into a hero, and an act of kindness ripples across centuries to inspire a revolution.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTczMTgxMjc4NF5BMl5BanBnXkFtZTcwNjM5MTA2OA@@._V1_SX300.jpg", "172", "Cloud Atlas", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 99, "J.A. Bayona", "The story of a tourist family in Thailand caught in the destruction and chaotic aftermath of the 2004 Indian Ocean tsunami.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA5NTA3NzQ5Nl5BMl5BanBnXkFtZTcwOTYxNjY0OA@@._V1_SX300.jpg", "114", "The Impossible", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 93, "Tim Burton", "Nineteen-year-old Alice returns to the magical world from her childhood adventure, where she reunites with her old friends and learns of her true destiny: to end the Red Queen's reign of terror.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMwNjAxMTc0Nl5BMl5BanBnXkFtZTcwODc3ODk5Mg@@._V1_SX300.jpg", "108", "Alice in Wonderland", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 100, "Lewis Milestone", "A young soldier faces profound disillusionment in the soul-destroying horror of World War I.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNTM5OTg2NDY1NF5BMl5BanBnXkFtZTcwNTQ4MTMwNw@@._V1_SX300.jpg", "136", "All Quiet on the Western Front", "1930" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 102, "Jean-Marc Vallée", "In 1985 Dallas, electrician and hustler Ron Woodroof works around the system to help AIDS patients get the medication they need after he is diagnosed with the disease.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwMTA4MzgyNF5BMl5BanBnXkFtZTgwMjEyMjE0MDE@._V1_SX300.jpg", "117", "Dallas Buyers Club", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 103, "Julie Taymor", "A biography of artist Frida Kahlo, who channeled the pain of a crippling injury and her tempestuous marriage into her work.", "http://ia.media-imdb.com/images/M/MV5BMTMyODUyMDY1OV5BMl5BanBnXkFtZTYwMDA2OTU3._V1_SX300.jpg", "123", "Frida", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 104, "Richard Linklater", "A young man and woman meet on a train in Europe, and wind up spending one evening together in Vienna. Unfortunately, both know that this will probably be their only night together.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQyMTM3MTQxMl5BMl5BanBnXkFtZTcwMDAzNjQ4Mg@@._V1_SX300.jpg", "105", "Before Sunrise", "1995" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 105, "Bruce Robinson", "American journalist Paul Kemp takes on a freelance job in Puerto Rico for a local newspaper during the 1960s and struggles to find a balance between island culture and the expatriates who live there.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM5ODA4MjYxM15BMl5BanBnXkFtZTcwMTM3NTE5Ng@@._V1_SX300.jpg", "120", "The Rum Diary", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 106, "Edward Zwick", "An American military advisor embraces the Samurai culture he was hired to destroy after he is captured in battle.", "http://ia.media-imdb.com/images/M/MV5BMzkyNzQ1Mzc0NV5BMl5BanBnXkFtZTcwODg3MzUzMw@@._V1_SX300.jpg", "154", "The Last Samurai", "2003" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 107, "Roman Polanski", "A private detective hired to expose an adulterer finds himself caught up in a web of deceit, corruption and murder.", "https://images-na.ssl-images-amazon.com/images/M/MV5BN2YyNDE5NzItMjAwNC00MGQxLTllNjktZGIzMWFkZjA3OWQ0XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "130", "Chinatown", "1974" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 101, "Anthony Minghella", "At the close of WWII, a young nurse tends to a badly-burned plane crash victim. His past is shown in flashbacks, revealing an involvement in a fateful love affair.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNDg2OTcxNDE0OF5BMl5BanBnXkFtZTgwOTg2MDM0MDE@._V1_SX300.jpg", "162", "The English Patient", "1996" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 108, "John Michael McDonagh", "After he is threatened during a confession, a good-natured priest must battle the dark forces closing in around him.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc3MjQ1MjE2M15BMl5BanBnXkFtZTgwNTMzNjE4MTE@._V1_SX300.jpg", "102", "Calvary", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 92, "David O. Russell", "After a stint in a mental institution, former teacher Pat Solitano moves back in with his parents and tries to reconcile with his ex-wife. Things get more challenging when Pat meets Tiffany, a mysterious girl with problems of her own.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTI5NzA3MF5BMl5BanBnXkFtZTcwODExNTc0OA@@._V1_SX300.jpg", "122", "Silver Linings Playbook", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 90, "James McTeigue", "In a future British tyranny, a shadowy freedom fighter, known only by the alias of \"V\", plots to overthrow it with the help of a young woman.", "https://images-na.ssl-images-amazon.com/images/M/MV5BOTI5ODc3NzExNV5BMl5BanBnXkFtZTcwNzYxNzQzMw@@._V1_SX300.jpg", "132", "V for Vendetta", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 76, "Gore Verbinski", "Blacksmith Will Turner teams up with eccentric pirate \"Captain\" Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAyNDM4MTc2N15BMl5BanBnXkFtZTYwNDk0Mjc3._V1_SX300.jpg", "143", "Pirates of the Caribbean: The Curse of the Black Pearl", "2003" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 77, "Peter Jackson", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjE4MjA1NTAyMV5BMl5BanBnXkFtZTcwNzM1NDQyMQ@@._V1_SX300.jpg", "201", "The Lord of the Rings: The Return of the King", "2003" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 78, "Chan-wook Park", "After being kidnapped and imprisoned for 15 years, Oh Dae-Su is released, only to find that he must find his captor in 5 days.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTI3NTQyMzU5M15BMl5BanBnXkFtZTcwMTM2MjgyMQ@@._V1_SX300.jpg", "120", "Oldboy", "2003" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 79, "Lasse Hallström", "A woman and her daughter open a chocolate shop in a small French village that shakes up the rigid morality of the community.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA4MDI3NTQwMV5BMl5BanBnXkFtZTcwNjIzNDcyMQ@@._V1_SX300.jpg", "121", "Chocolat", "2000" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 80, "Martin Campbell", "Armed with a licence to kill, Secret Agent James Bond sets out on his first mission as 007 and must defeat a weapons dealer in a high stakes game of poker at Casino Royale, but things are not what they seem.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM5MjI4NDExNF5BMl5BanBnXkFtZTcwMDM1MjMzMQ@@._V1_SX300.jpg", "144", "Casino Royale", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 81, "Andrew Stanton", "In the distant future, a small waste-collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTczOTA3MzY2N15BMl5BanBnXkFtZTcwOTYwNjE2MQ@@._V1_SX300.jpg", "98", "WALL·E", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 91, "Andrew Niccol", "A genetically inferior man assumes the identity of a superior one in order to pursue his lifelong dream of space travel.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNDQxOTc0MzMtZmRlOS00OWQ5LWI2ZDctOTAwNmMwOTYxYzlhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "106", "Gattaca", "1997" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 82, "Martin Scorsese", "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption and the federal government.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SX300.jpg", "180", "The Wolf of Wall Street", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 84, "Billy Wilder", "A hack screenwriter writes a screenplay for a former silent-film star who has faded into Hollywood obscurity.", "http://ia.media-imdb.com/images/M/MV5BMTc3NDYzODAwNV5BMl5BanBnXkFtZTgwODg1MTczMTE@._V1_SX300.jpg", "110", "Sunset Boulevard", "1950" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 85, "Eric Steven Stahl", "A 17-year-old boy buys mini-cameras and displays the footage online at I-see-you.com. The cash rolls in as the site becomes a major hit. Everyone seems to have fun until it all comes crashing down....", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwMDUzNzA5Nl5BMl5BanBnXkFtZTcwMjQ2Njk3MQ@@._V1_SX300.jpg", "92", "I-See-You.Com", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 86, "Wes Anderson", "The adventures of Gustave H, a legendary concierge at a famous hotel from the fictional Republic of Zubrowka between the first and second World Wars, and Zero Moustafa, the lobby boy who becomes his most trusted friend.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMzM5NjUxOTEyMl5BMl5BanBnXkFtZTgwNjEyMDM0MDE@._V1_SX300.jpg", "99", "The Grand Budapest Hotel", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 87, "Garth Jennings", "Mere seconds before the Earth is to be demolished by an alien construction crew, journeyman Arthur Dent is swept off the planet by his friend Ford Prefect, a researcher penning a new edition of \"The Hitchhiker's Guide to the Galaxy.\"", "http://ia.media-imdb.com/images/M/MV5BMjEwOTk4NjU2MF5BMl5BanBnXkFtZTYwMDA3NzI3._V1_SX300.jpg", "109", "The Hitchhiker's Guide to the Galaxy", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 88, "Sergio Leone", "A former Prohibition-era Jewish gangster returns to the Lower East Side of Manhattan over thirty years later, where he once again must confront the ghosts and regrets of his old life.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "229", "Once Upon a Time in America", "1984" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 89, "Joseph Kosinski", "A veteran assigned to extract Earth's remaining resources begins to question what he knows about his mission and himself.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQwMDY0MTA4MF5BMl5BanBnXkFtZTcwNzI3MDgxOQ@@._V1_SX300.jpg", "124", "Oblivion", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 83, "Guillermo del Toro", "The mythical world starts a rebellion against humanity in order to rule the Earth, so Hellboy and his team must save the world from the rebellious creatures.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA5NzgyMjc2Nl5BMl5BanBnXkFtZTcwOTU3MDI3MQ@@._V1_SX300.jpg", "120", "Hellboy II: The Golden Army", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 109, "Richard Linklater", "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.", "http://ia.media-imdb.com/images/M/MV5BMTQ1MjAwNTM5Ml5BMl5BanBnXkFtZTYwNDM0MTc3._V1_SX300.jpg", "80", "Before Sunset", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 110, "Hayao Miyazaki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjYxMDcyMzIzNl5BMl5BanBnXkFtZTYwNDg2MDU3._V1_SX300.jpg", "125", "Spirited Away", "2001" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 111, "Régis Wargnier", "This story is set in 1930, at the time when French colonial rule in Indochina is ending. A widowed French woman who works in the rubber fields, raises a Vietnamese princess as if she was ...", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM1MTkzNzA3NF5BMl5BanBnXkFtZTYwNTI2MzU5._V1_SX300.jpg", "159", "Indochine", "1992" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 131, "Chris Wedge, Carlos Saldanha", "Set during the Ice Age, a sabertooth tiger, a sloth, and a wooly mammoth find a lost human infant, and they try to return him to his tribe.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjEyNzI1ODA0MF5BMl5BanBnXkFtZTYwODIxODY3._V1_SX300.jpg", "81", "Ice Age", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 132, "Peter Jackson", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle Earth from the Dark Lord Sauron.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNTEyMjAwMDU1OV5BMl5BanBnXkFtZTcwNDQyNTkxMw@@._V1_SX300.jpg", "178", "The Lord of the Rings: The Fellowship of the Ring", "2001" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 133, "Peter Jackson", "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTAyNDU0NjY4NTheQTJeQWpwZ15BbWU2MDk4MTY2Nw@@._V1_SX300.jpg", "179", "The Lord of the Rings: The Two Towers", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 134, "Alex Garland", "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breath-taking humanoid A.I.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg", "108", "Ex Machina", "2015" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 135, "James Marsh", "A look at the relationship between the famous physicist Stephen Hawking and his wife.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_SX300.jpg", "123", "The Theory of Everything", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 136, "N/A", "A English navigator becomes both a player and pawn in the complex political games in feudal Japan.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY1ODI4NzYxMl5BMl5BanBnXkFtZTcwNDA4MzUxMQ@@._V1_SX300.jpg", "60", "Shogun", "1980" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 130, "Baz Luhrmann", "A writer and wall street trader, Nick, finds himself drawn to the past and lifestyle of his millionaire neighbor, Jay Gatsby.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkxNTk1ODcxNl5BMl5BanBnXkFtZTcwMDI1OTMzOQ@@._V1_SX300.jpg", "143", "The Great Gatsby", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 137, "Tom McCarthy", "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_SX300.jpg", "128", "Spotlight", "2015" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 139, "Damien Chazelle", "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU4OTQ3MDUyMV5BMl5BanBnXkFtZTgwOTA2MjU0MjE@._V1_SX300.jpg", "107", "Whiplash", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 140, "Florian Henckel von Donnersmarck", "In 1984 East Berlin, an agent of the secret police, conducting surveillance on a writer and his lover, finds himself becoming increasingly absorbed by their lives.", "http://ia.media-imdb.com/images/M/MV5BNDUzNjYwNDYyNl5BMl5BanBnXkFtZTcwNjU3ODQ0MQ@@._V1_SX300.jpg", "137", "The Lives of Others", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 141, "Terry George", "Paul Rusesabagina was a hotel manager who housed over a thousand Tutsi refugees during their struggle against the Hutu militia in Rwanda.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTI2MzQyNTc1M15BMl5BanBnXkFtZTYwMjExNjc3._V1_SX300.jpg", "121", "Hotel Rwanda", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 142, "Ridley Scott", "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_SX300.jpg", "144", "The Martian", "2015" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 143, "Robert Mulligan", "Atticus Finch, a lawyer in the Depression-era South, defends a black man against an undeserved rape charge, and his kids against prejudice.", "http://ia.media-imdb.com/images/M/MV5BMjA4MzI1NDY2Nl5BMl5BanBnXkFtZTcwMTcyODc5Mw@@._V1_SX300.jpg", "129", "To Kill a Mockingbird", "1962" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 144, "Quentin Tarantino", "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA1MTc1NTg5NV5BMl5BanBnXkFtZTgwOTM2MDEzNzE@._V1_SX300.jpg", "187", "The Hateful Eight", "2015" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 138, "Alfred Hitchcock", "A San Francisco detective suffering from acrophobia investigates the strange activities of an old friend's wife, all the while becoming dangerously obsessed with her.", "http://ia.media-imdb.com/images/M/MV5BNzY0NzQyNzQzOF5BMl5BanBnXkFtZTcwMTgwNTk4OQ@@._V1_SX300.jpg", "128", "Vertigo", "1958" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 129, "Peter Jackson", "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_SX300.jpg", "169", "The Hobbit: An Unexpected Journey", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 128, "Wolfgang Petersen", "An adaptation of Homer's great epic, the film follows the assault on Troy by the united Greek forces and chronicles the fates of the men involved.", "http://ia.media-imdb.com/images/M/MV5BMTk5MzU1MDMwMF5BMl5BanBnXkFtZTcwNjczODMzMw@@._V1_SX300.jpg", "163", "Troy", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 127, "Pierre Coffin, Chris Renaud", "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY3NjY0MTQ0Nl5BMl5BanBnXkFtZTcwMzQ2MTc0Mw@@._V1_SX300.jpg", "95", "Despicable Me", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 112, "Alejandro G. Iñárritu", "Illustrated upon the progress of his latest Broadway play, a former popular actor's struggle to cope with his current life as a wasted actor is shown.", "https://images-na.ssl-images-amazon.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_SX300.jpg", "119", "Birdman or (The Unexpected Virtue of Ignorance)", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 113, "Richard Linklater", "The life of Mason, from early childhood to his arrival at college.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYzNDc2MDc0N15BMl5BanBnXkFtZTgwOTcwMDQ5MTE@._V1_SX300.jpg", "165", "Boyhood", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 114, "Sidney Lumet", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://images-na.ssl-images-amazon.com/images/M/MV5BODQwOTc5MDM2N15BMl5BanBnXkFtZTcwODQxNTEzNA@@._V1_SX300.jpg", "96", "12 Angry Men", "1957" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 115, "Morten Tyldum", "During World War II, mathematician Alan Turing tries to crack the enigma code with help from fellow mathematicians.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNDkwNTEyMzkzNl5BMl5BanBnXkFtZTgwNTAwNzk3MjE@._V1_SX300.jpg", "114", "The Imitation Game", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 116, "Christopher Nolan", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MjE@._V1_SX300.jpg", "169", "Interstellar", "2014" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 117, "Jean-Baptiste Andrea", "A frustrated, unemployed teacher joining forces with a scammer and his girlfriend in a blackmailing scheme.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY5NTc2NjYwOV5BMl5BanBnXkFtZTcwMzk5OTY0MQ@@._V1_SX300.jpg", "86", "Big Nothing", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 118, "Wolfgang Petersen", "The claustrophobic world of a WWII German U-boat; boredom, filth, and sheer terror.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjE5Mzk5OTQ0Nl5BMl5BanBnXkFtZTYwNzUwMTQ5._V1_SX300.jpg", "149", "Das Boot", "1981" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 119, "Andrew Adamson, Kelly Asbury, Conrad Vernon", "Princess Fiona's parents invite her and Shrek to dinner to celebrate her marriage. If only they knew the newlyweds were both ogres.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTk4MTMwNjI4M15BMl5BanBnXkFtZTcwMjExMzUyMQ@@._V1_SX300.jpg", "93", "Shrek 2", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 120, "Frank Miller, Robert Rodriguez, Quentin Tarantino", "A film that explores the dark and miserable town, Basin City, and tells the story of three different people, all caught up in violent corruption.", "https://images-na.ssl-images-amazon.com/images/M/MV5BODZmYjMwNzEtNzVhNC00ZTRmLTk2M2UtNzE1MTQ2ZDAxNjc2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "124", "Sin City", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 121, "Alexander Payne", "An aging, booze-addled father makes the trip from Montana to Nebraska with his estranged son in order to claim a million-dollar Mega Sweepstakes Marketing prize.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU2Mjk2NDkyMl5BMl5BanBnXkFtZTgwNTk0NzcyMDE@._V1_SX300.jpg", "115", "Nebraska", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 122, "Andrew Adamson, Vicky Jenson", "After his swamp is filled with magical creatures, an ogre agrees to rescue a princess for a villainous lord in order to get his land back.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTk2NTE1NTE0M15BMl5BanBnXkFtZTgwNjY4NTYxMTE@._V1_SX300.jpg", "90", "Shrek", "2001" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 123, "Doug Liman", "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxMzcxNzQzOF5BMl5BanBnXkFtZTcwMzQxNjUyMw@@._V1_SX300.jpg", "120", "Mr. & Mrs. Smith", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 124, "Michael Cristofer", "A woman along with her lover, plan to con a rich man by marrying him and on earning his trust running away with all his money. Everything goes as planned until she actually begins to fall in love with him.", "https://images-na.ssl-images-amazon.com/images/M/MV5BODg3Mjg0MDY4M15BMl5BanBnXkFtZTcwNjY5MDQ2NA@@._V1_SX300.jpg", "116", "Original Sin", "2001" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 125, "Mike Mitchell", "Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpel rules supreme.", "http://ia.media-imdb.com/images/M/MV5BMTY0OTU1NzkxMl5BMl5BanBnXkFtZTcwMzI2NDUzMw@@._V1_SX300.jpg", "93", "Shrek Forever After", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 126, "Richard Linklater", "We meet Jesse and Celine nine years on in Greece. Almost two decades have passed since their first meeting on that train bound for Vienna.", "http://ia.media-imdb.com/images/M/MV5BMjA5NzgxODE2NF5BMl5BanBnXkFtZTcwNTI1NTI0OQ@@._V1_SX300.jpg", "109", "Before Midnight", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 75, "Paul Haggis", "Los Angeles citizens with vastly separate lives collide in interweaving stories of race, loss and redemption.", "https://images-na.ssl-images-amazon.com/images/M/MV5BOTk1OTA1MjIyNV5BMl5BanBnXkFtZTcwODQxMTkyMQ@@._V1_SX300.jpg", "112", "Crash", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 74, "Rob Marshall", "Jack Sparrow and Barbossa embark on a quest to find the elusive fountain of youth, only to discover that Blackbeard and his daughter are after it too.", "http://ia.media-imdb.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_SX300.jpg", "136", "Pirates of the Caribbean: On Stranger Tides", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 73, "Gore Verbinski", "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIyNjkxNzEyMl5BMl5BanBnXkFtZTYwMjc3MDE3._V1_SX300.jpg", "169", "Pirates of the Caribbean: At World's End", "2007" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 72, "Martin Scorsese", "Greed, deception, money, power, and murder occur between two best friends, a mafia underboss and a casino owner, for a trophy wife over a gambling empire.", "http://ia.media-imdb.com/images/M/MV5BMTcxOWYzNDYtYmM4YS00N2NkLTk0NTAtNjg1ODgwZjAxYzI3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg", "178", "Casino", "1995" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 21, "Darren Aronofsky", "A committed dancer wins the lead role in a production of Tchaikovsky's \"Swan Lake\" only to find herself struggling to maintain her sanity.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_SX300.jpg", "108", "Black Swan", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 22, "Christopher Nolan", "A thief, who steals corporate secrets through use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg", "148", "Inception", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 23, "Michael Cimino", "An in-depth examination of the ways in which the U.S. Vietnam War impacts and disrupts the lives of people in a small industrial town in Pennsylvania.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYzYmRmZTQtYjk2NS00MDdlLTkxMDAtMTE2YTM2ZmNlMTBkXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "183", "The Deer Hunter", "1978" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 24, "Kevin Smith", "Holden and Banky are comic book artists. Everything's going good for them until they meet Alyssa, also a comic book artist. Holden falls for her, but his hopes are crushed when he finds out she's gay.", "https://images-na.ssl-images-amazon.com/images/M/MV5BZDM3MTg2MGUtZDM0MC00NzMwLWE5NjItOWFjNjA2M2I4YzgxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "113", "Chasing Amy", "1997" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 25, "Quentin Tarantino", "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.", "http://ia.media-imdb.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_SX300.jpg", "165", "Django Unchained", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 26, "Jonathan Demme", "A young F.B.I. cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer who skins his victims.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ2NzkzMDI4OF5BMl5BanBnXkFtZTcwMDA0NzE1NA@@._V1_SX300.jpg", "118", "The Silence of the Lambs", "1991" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 20, "Alex Cox", "Morbid biographical story of Sid Vicious, bassist with British punk group the Sex Pistols, and his girlfriend Nancy Spungen. When the Sex Pistols break up after their fateful US tour, ...", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjExNjA5NzY4M15BMl5BanBnXkFtZTcwNjQ2NzI5NA@@._V1_SX300.jpg", "112", "Sid and Nancy", "1986" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 27, "Sam Mendes", "A sexually frustrated suburban father has a mid-life crisis after becoming infatuated with his daughter's best friend.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjM4NTI5NzYyNV5BMl5BanBnXkFtZTgwNTkxNTYxMTE@._V1_SX300.jpg", "122", "American Beauty", "1999" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 29, "Alan Parker", "Billy Hayes, an American college student, is caught smuggling drugs out of Turkey and thrown into prison.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQyMDA5MzkyOF5BMl5BanBnXkFtZTgwOTYwNTcxMTE@._V1_SX300.jpg", "121", "Midnight Express", "1978" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 30, "Quentin Tarantino", "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkxMTA5OTAzMl5BMl5BanBnXkFtZTgwNjA5MDc3NjE@._V1_SX300.jpg", "154", "Pulp Fiction", "1994" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 31, "Guy Ritchie", "A botched card game in London triggers four friends, thugs, weed-growers, hard gangsters, loan sharks and debt collectors to collide with each other in a series of unexpected events, all for the sake of weed, cash and two antique shotguns.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTAyN2JmZmEtNjAyMy00NzYwLThmY2MtYWQ3OGNhNjExMmM4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "107", "Lock, Stock and Two Smoking Barrels", "1998" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 32, "Paul McGuigan", "A case of mistaken identity lands Slevin into the middle of a war being plotted by two of the city's most rival crime bosses: The Rabbi and The Boss. Slevin is under constant surveillance by relentless Detective Brikowski as well as the infamous assassin Goodkat and finds himself having to hatch his own ingenious plot to get them before they get him.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMzc1OTEwMTk4OF5BMl5BanBnXkFtZTcwMTEzMDQzMQ@@._V1_SX300.jpg", "110", "Lucky Number Slevin", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 33, "Alfred Hitchcock", "A wheelchair-bound photographer spies on his neighbours from his apartment window and becomes convinced one of them has committed murder.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "112", "Rear Window", "1954" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 34, "Guillermo del Toro", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "", "118", "Pan's Labyrinth", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 28, "Guy Ritchie", "Unscrupulous boxing promoters, violent bookmakers, a Russian gangster, incompetent amateur robbers, and supposedly Jewish jewelers fight to track down a priceless stolen diamond.", "http://ia.media-imdb.com/images/M/MV5BMTA2NDYxOGYtYjU1Mi00Y2QzLTgxMTQtMWI1MGI0ZGQ5MmU4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "102", "Snatch", "2000" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 19, "Brian De Palma", "In Miami in 1980, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAzOTM4MzEwNl5BMl5BanBnXkFtZTgwMzU1OTc1MDE@._V1_SX300.jpg", "170", "Scarface", "1983" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 18, "Danny Boyle", "Twenty-something Richard travels to Thailand and finds himself in possession of a strange map. Rumours state that it leads to a solitary beach paradise, a tropical bliss - excited and intrigued, he sets out to find it.", "https://images-na.ssl-images-amazon.com/images/M/MV5BN2ViYTFiZmUtOTIxZi00YzIxLWEyMzUtYjQwZGNjMjNhY2IwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "119", "The Beach", "2000" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 17, "Carol Reed", "Pulp novelist Holly Martins travels to shadowy, postwar Vienna, only to find himself investigating the mysterious death of an old friend, Harry Lime.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjMwNzMzMTQ0Ml5BMl5BanBnXkFtZTgwNjExMzUwNjE@._V1_SX300.jpg", "93", "The Third Man", "1949" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 2, "Francis Ford Coppola", "The Cotton Club was a famous night club in Harlem. The story follows the people that visited the club, those that ran it, and is peppered with the Jazz music that made it so famous.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU5ODAyNzA4OV5BMl5BanBnXkFtZTcwNzYwNTIzNA@@._V1_SX300.jpg", "127", "The Cotton Club", "1984" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 3, "Frank Darabont", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://images-na.ssl-images-amazon.com/images/M/MV5BODU4MjU4NjIwNl5BMl5BanBnXkFtZTgwMDU2MjEyMDE@._V1_SX300.jpg", "142", "The Shawshank Redemption", "1994" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 4, "Peter Faiman", "An American reporter goes to the Australian outback to meet an eccentric crocodile poacher and invites him to New York City.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTg0MTU1MTg4NF5BMl5BanBnXkFtZTgwMDgzNzYxMTE@._V1_SX300.jpg", "97", "Crocodile Dundee", "1986" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 5, "Bryan Singer", "A dramatization of the 20 July assassination and political coup plot by desperate renegade German Army officers against Hitler during World War II.", "http://ia.media-imdb.com/images/M/MV5BMTg3Njc2ODEyN15BMl5BanBnXkFtZTcwNTAwMzc3NA@@._V1_SX300.jpg", "121", "Valkyrie", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 6, "Brad Bird, Jan Pinkava", "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_SX300.jpg", "111", "Ratatouille", "2007" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 7, "Fernando Meirelles, Kátia Lund", "Two boys growing up in a violent neighborhood of Rio de Janeiro take different paths: one becomes a photographer, the other a drug dealer.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA4ODQ3ODkzNV5BMl5BanBnXkFtZTYwOTc4NDI3._V1_SX300.jpg", "130", "City of God", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 8, "Christopher Nolan", "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNThiYjM3MzktMDg3Yy00ZWQ3LTk3YWEtN2M0YmNmNWEwYTE3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "113", "Memento", "2000" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 9, "Olivier Nakache, Eric Toledano", "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.", "http://ia.media-imdb.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_SX300.jpg", "112", "The Intouchables", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 10, "Matthew Vaughn", "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_SX300.jpg", "127", "Stardust", "2007" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 11, "Mel Gibson", "As the Mayan kingdom faces its decline, the rulers insist the key to prosperity is to build more temples and offer human sacrifices. Jaguar Paw, a young man captured for sacrifice, flees to avoid his fate.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNTM1NjYyNTY5OV5BMl5BanBnXkFtZTcwMjgwNTMzMQ@@._V1_SX300.jpg", "139", "Apocalypto", "2006" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 12, "Martin Scorsese", "A mentally unstable Vietnam War veteran works as a night-time taxi driver in New York City where the perceived decadence and sleaze feeds his urge for violent action, attempting to save a preadolescent prostitute in the process.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNGQxNDgzZWQtZTNjNi00M2RkLWExZmEtNmE1NjEyZDEwMzA5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "113", "Taxi Driver", "1976" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 13, "Ethan Coen, Joel Coen", "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_SX300.jpg", "122", "No Country for Old Men", "2007" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 14, "Jorge Blanco, Javier Abad, Marcos Martínez", "An alien civilization is invaded by Astronaut Chuck Baker, who believes that the planet was uninhabited. Wanted by the military, Baker must get back to his ship before it goes into orbit without him.", "http://ia.media-imdb.com/images/M/MV5BMTUyOTAyNTA5Ml5BMl5BanBnXkFtZTcwODU2OTM0Mg@@._V1_SX300.jpg", "91", "Planet 51", "2009" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 15, "Rian Johnson", "In 2074, when the mob wants to get rid of someone, the target is sent into the past, where a hired gun awaits - someone like Joe - who one day learns the mob wants to 'close the loop' by sending back Joe's future self for assassination.", "http://ia.media-imdb.com/images/M/MV5BMTY3NTY0MjEwNV5BMl5BanBnXkFtZTcwNTE3NDA1OA@@._V1_SX300.jpg", "119", "Looper", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 16, "Tim Burton, Mike Johnson", "When a shy groom practices his wedding vows in the inadvertent presence of a deceased young woman, she rises from the grave assuming he has married her.", "http://ia.media-imdb.com/images/M/MV5BMTk1MTY1NjU4MF5BMl5BanBnXkFtZTcwNjIzMTEzMw@@._V1_SX300.jpg", "77", "Corpse Bride", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 35, "Martin Scorsese", "In 1954, a U.S. marshal investigates the disappearance of a murderess who escaped from a hospital for the criminally insane.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMxMTIyNzMxMV5BMl5BanBnXkFtZTcwOTc4OTI3Mg@@._V1_SX300.jpg", "138", "Shutter Island", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 145, "Asghar Farhadi", "A married couple are faced with a difficult decision - to improve the life of their child by moving to another country or to stay in Iran and look after a deteriorating parent who has Alzheimer's disease.", "http://ia.media-imdb.com/images/M/MV5BMTYzMzU4NDUwOF5BMl5BanBnXkFtZTcwMTM5MjA5Ng@@._V1_SX300.jpg", "123", "A Separation", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 36, "Quentin Tarantino", "After a simple jewelry heist goes terribly wrong, the surviving criminals begin to suspect that one of them is a police informant.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNjE5ZDJiZTQtOGE2YS00ZTc5LTk0OGUtOTg2NjdjZmVlYzE2XkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_SX300.jpg", "99", "Reservoir Dogs", "1992" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 38, "Woody Allen", "While on a trip to Paris with his fiancée's family, a nostalgic screenwriter finds himself mysteriously going back to the 1920s everyday at midnight.", "http://ia.media-imdb.com/images/M/MV5BMTM4NjY1MDQwMl5BMl5BanBnXkFtZTcwNTI3Njg3NA@@._V1_SX300.jpg", "94", "Midnight in Paris", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 58, "Alfred Hitchcock", "A hapless New York advertising executive is mistaken for a government agent by a group of foreign spies, and is pursued across the country while he looks for a way to survive.", "http://ia.media-imdb.com/images/M/MV5BMjQwMTQ0MzgwNl5BMl5BanBnXkFtZTgwNjc4ODE4MzE@._V1_SX300.jpg", "136", "North by Northwest", "1959" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 59, "Eric Darnell, Tom McGrath", "The animals try to fly back to New York City, but crash-land on an African wildlife refuge, where Alex is reunited with his parents.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjExMDA4NDcwMl5BMl5BanBnXkFtZTcwODAxNTQ3MQ@@._V1_SX300.jpg", "89", "Madagascar: Escape 2 Africa", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 60, "Pierre Coffin, Chris Renaud", "When Gru, the world's most super-bad turned super-dad has been recruited by a team of officials to stop lethal muscle and a host of Gru's own, He has to fight back with new gadgetry, cars, and more minion madness.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjExNjAyNTcyMF5BMl5BanBnXkFtZTgwODQzMjQ3MDE@._V1_SX300.jpg", "98", "Despicable Me 2", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 61, "Oliver Hirschbiegel", "Traudl Junge, the final secretary for Adolf Hitler, tells of the Nazi dictator's final days in his Berlin bunker at the end of WWII.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM1OTI1MjE2Nl5BMl5BanBnXkFtZTcwMTEwMzc4NA@@._V1_SX300.jpg", "156", "Downfall", "2004" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 62, "Eric Darnell, Tom McGrath", "Spoiled by their upbringing with no idea what wild life is really like, four animals from New York Central Zoo escape, unwittingly assisted by four absconding penguins, and find themselves in Madagascar, among a bunch of merry lemurs", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY4NDUwMzQxMF5BMl5BanBnXkFtZTcwMDgwNjgyMQ@@._V1_SX300.jpg", "86", "Madagascar", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 63, "Eric Darnell, Tom McGrath, Conrad Vernon", "Alex, Marty, Gloria and Melman are still fighting to get home to their beloved Big Apple. Their journey takes them through Europe where they find the perfect cover: a traveling circus, which they reinvent - Madagascar style.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTIzNzk2MF5BMl5BanBnXkFtZTcwMDcwMzQxNw@@._V1_SX300.jpg", "93", "Madagascar 3: Europe's Most Wanted", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 57, "Alfred Hitchcock", "A Phoenix secretary embezzles $40,000 from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMDI3OWRmOTEtOWJhYi00N2JkLTgwNGItMjdkN2U0NjFiZTYwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "109", "Psycho", "1960" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 64, "Bobcat Goldthwait", "On a mission to rid society of its most repellent citizens, terminally ill Frank makes an unlikely accomplice in 16-year-old Roxy.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQwMTc1MzA4NF5BMl5BanBnXkFtZTcwNzQwMTgzNw@@._V1_SX300.jpg", "105", "God Bless America", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 66, "Roman Polanski", "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.", "http://ia.media-imdb.com/images/M/MV5BMTc4OTkyOTA3OF5BMl5BanBnXkFtZTYwMDIxNjk5._V1_SX300.jpg", "150", "The Pianist", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 67, "Frank Marshall", "Uruguayan rugby team stranded in the snow swept Andes are forced to use desperate measures to survive after a plane crash.", "", "120", "Alive", "1993" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 68, "Michael Curtiz", "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjQwNDYyNTk2N15BMl5BanBnXkFtZTgwMjQ0OTMyMjE@._V1_SX300.jpg", "102", "Casablanca", "1942" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 69, "Ridley Scott", "In 1970s America, a detective works to bring down the drug empire of Frank Lucas, a heroin kingpin from Manhattan, who is smuggling the drug into the country from the Far East.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkyNzY5MDA5MV5BMl5BanBnXkFtZTcwMjg4MzI3MQ@@._V1_SX300.jpg", "157", "American Gangster", "2007" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 70, "Steven Spielberg", "The true story of Frank Abagnale Jr. who, before his 19th birthday, successfully conned millions of dollars' worth of checks as a Pan Am pilot, doctor, and legal prosecutor.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_SX300.jpg", "141", "Catch Me If You Can", "2002" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 71, "Tony Kaye", "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did.", "https://images-na.ssl-images-amazon.com/images/M/MV5BZjA0MTM4MTQtNzY5MC00NzY3LWI1ZTgtYzcxMjkyMzU4MDZiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg", "119", "American History X", "1998" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 65, "David Fincher", "Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea, and the co-founder who was later squeezed out of the business.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM2ODk0NDAwMF5BMl5BanBnXkFtZTcwNTM1MDc2Mw@@._V1_SX300.jpg", "120", "The Social Network", "2010" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 56, "Woody Allen", "At a turning point in his life, a former tennis pro falls for an actress who happens to be dating his friend and soon-to-be brother-in-law.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMzNzY4MzE5NF5BMl5BanBnXkFtZTcwMzQ1MDMzMQ@@._V1_SX300.jpg", "119", "Match Point", "2005" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 55, "Sofia Coppola", "A faded movie star and a neglected young woman form an unlikely bond after crossing paths in Tokyo.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTI2NDI5ODk4N15BMl5BanBnXkFtZTYwMTI3NTE3._V1_SX300.jpg", "101", "Lost in Translation", "2003" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 54, "Danny Boyle, Loveleen Tandan", "A Mumbai teen reflects on his upbringing in the slums when he is accused of cheating on the Indian Version of \"Who Wants to be a Millionaire?\"", "http://ia.media-imdb.com/images/M/MV5BMTU2NTA5NzI0N15BMl5BanBnXkFtZTcwMjUxMjYxMg@@._V1_SX300.jpg", "120", "Slumdog Millionaire", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 39, "Tom Hooper", "In 19th-century France, Jean Valjean, who for decades has been hunted by the ruthless policeman Javert after breaking parole, agrees to care for a factory worker's daughter. The decision changes their lives forever.", "http://ia.media-imdb.com/images/M/MV5BMTQ4NDI3NDg4M15BMl5BanBnXkFtZTcwMjY5OTI1OA@@._V1_SX300.jpg", "158", "Les Misérables", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 40, "Curtis Hanson", "As corruption grows in 1950s LA, three policemen - one strait-laced, one brutal, and one sleazy - investigate a series of murders with their own brand of justice.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNWEwNDhhNWUtYWMzNi00ZTNhLWFiZDAtMjBjZmJhMTU0ZTY2XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "138", "L.A. Confidential", "1997" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 41, "Bennett Miller", "Oakland A's general manager Billy Beane's successful attempt to assemble a baseball team on a lean budget by employing computer-generated analysis to acquire new players.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAxOTU3Mzc1M15BMl5BanBnXkFtZTcwMzk1ODUzNg@@._V1_SX300.jpg", "133", "Moneyball", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 42, "Todd Phillips", "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing. They make their way around the city in order to find their friend before his wedding.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU1MDA1MTYwMF5BMl5BanBnXkFtZTcwMDcxMzA1Mg@@._V1_SX300.jpg", "100", "The Hangover", "2009" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 43, "Paolo Sorrentino", "Jep Gambardella has seduced his way through the lavish nightlife of Rome for decades, but after his 65th birthday and a shock from the past, Jep looks past the nightclubs and parties to find a timeless landscape of absurd, exquisite beauty.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ0ODg1OTQ2Nl5BMl5BanBnXkFtZTgwNTc2MDY1MDE@._V1_SX300.jpg", "141", "The Great Beauty", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 44, "Clint Eastwood", "Disgruntled Korean War veteran Walt Kowalski sets out to reform his neighbor, a Hmong teenager who tried to steal Kowalski's prized possession: a 1972 Gran Torino.", "http://ia.media-imdb.com/images/M/MV5BMTQyMTczMTAxMl5BMl5BanBnXkFtZTcwOTc1ODE0Mg@@._V1_SX300.jpg", "116", "Gran Torino", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 45, "Adam Elliot", "A tale of friendship between two unlikely pen pals: Mary, a lonely, eight-year-old girl living in the suburbs of Melbourne, and Max, a forty-four-year old, severely obese man living in New York.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ1NDIyNTA1Nl5BMl5BanBnXkFtZTcwMjc2Njk3OA@@._V1_SX300.jpg", "92", "Mary and Max", "2009" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 46, "Robert Zemeckis", "An airline pilot saves almost all his passengers on his malfunctioning airliner which eventually crashed, but an investigation into the accident reveals something troubling.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxMjI1OTMxNl5BMl5BanBnXkFtZTcwNjc3NTY1OA@@._V1_SX300.jpg", "138", "Flight", "2012" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 47, "Milos Forman", "A criminal pleads insanity after getting into trouble again and once in the mental institution rebels against the oppressive nurse and rallies up the scared patients.", "https://images-na.ssl-images-amazon.com/images/M/MV5BYmJkODkwOTItZThjZC00MTE0LWIxNzQtYTM3MmQwMGI1OWFiXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg", "133", "One Flew Over the Cuckoo's Nest", "1975" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 48, "Darren Aronofsky", "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkzODMzODYwOF5BMl5BanBnXkFtZTcwODM2NjA2NQ@@._V1_SX300.jpg", "102", "Requiem for a Dream", "2000" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 49, "Peter Weir", "An insurance salesman/adjuster discovers his entire life is actually a television show.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMDIzODcyY2EtMmY2MC00ZWVlLTgwMzAtMjQwOWUyNmJjNTYyXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "103", "The Truman Show", "1998" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 50, "Michel Hazanavicius", "A silent movie star meets a young dancer, but the arrival of talking pictures sends their careers in opposite directions.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMzk0NzQxMTM0OV5BMl5BanBnXkFtZTcwMzU4MDYyNQ@@._V1_SX300.jpg", "100", "The Artist", "2011" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 51, "Robert Zemeckis", "Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.", "https://images-na.ssl-images-amazon.com/images/M/MV5BYThjM2MwZGMtMzg3Ny00NGRkLWE4M2EtYTBiNWMzOTY0YTI4XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg", "142", "Forrest Gump", "1994" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 52, "Peter Jackson", "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug. Bilbo Baggins is in possession of a mysterious and magical ring.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMzU0NDY0NDEzNV5BMl5BanBnXkFtZTgwOTIxNDU1MDE@._V1_SX300.jpg", "161", "The Hobbit: The Desolation of Smaug", "2013" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 53, "Woody Allen", "Two girlfriends on a summer holiday in Spain become enamored with the same painter, unaware that his ex-wife, with whom he has a tempestuous relationship, is about to re-enter the picture.", "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU2NDQ4MTg2MV5BMl5BanBnXkFtZTcwNDUzNjU3MQ@@._V1_SX300.jpg", "96", "Vicky Cristina Barcelona", "2008" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 37, "Stanley Kubrick", "A family heads to an isolated hotel for the winter where an evil and spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from the past and of the future.", "http://ia.media-imdb.com/images/M/MV5BODMxMjE3NTA4Ml5BMl5BanBnXkFtZTgwNDc0NTIxMDE@._V1_SX300.jpg", "146", "The Shining", "1980" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Plot", "PosterUrl", "Runtime", "Title", "Year" },
                values: new object[] { 146, "Adam McKay", "Four denizens in the world of high-finance predict the credit and housing bubble collapse of the mid-2000s, and decide to take on the big banks for their greed and lack of foresight.", "https://images-na.ssl-images-amazon.com/images/M/MV5BNDc4MThhN2EtZjMzNC00ZDJmLThiZTgtNThlY2UxZWMzNjdkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "130", "The Big Short", "2015" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d0e22361-e7f6-496d-a18a-12955eb80ed7"), 1, "Alec Baldwin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68a76b23-a828-445d-8ff0-3f63c2aad476"), 97, " Brendan Fraser" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b9eef140-88fe-45e4-9fda-45378b7cfe61"), 97, " Do Thi Hai Yen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7e2d3930-6348-47ae-9f98-949f17c098e1"), 97, " Rade Serbedzija" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c7f9ddb1-8c5b-42ca-a1db-b6fcec5d11d2"), 98, "Tom Hanks" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ff31fc82-0fc5-4ed2-a0cb-faf6a734926f"), 98, " Halle Berry" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bed9a396-8958-4c4e-8994-38133817e2cd"), 98, " Jim Broadbent" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d742b9c9-3bbf-43c6-91f7-0265d4eebdd8"), 97, "Michael Caine" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("679a22f8-cd03-40e9-800d-674dad3870c9"), 98, " Hugo Weaving" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9dc1454e-7c15-4bf2-b12f-59987084adfc"), 99, " Ewan McGregor" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("12d1b47f-4345-4bf1-8319-95910a09703d"), 99, " Tom Holland" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c357510d-edf5-41ba-bdc6-37be0c94e419"), 99, " Samuel Joslin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d6883da0-603e-43c9-b62f-56d93858d9ad"), 100, "Louis Wolheim" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ec38ed8b-775c-4a37-83dd-5e9052f9af64"), 100, " Lew Ayres" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("749f35de-47f0-43eb-822f-e332b36ddd65"), 100, " John Wray" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c35f7387-992d-479a-a904-302a6b301e44"), 99, "Naomi Watts" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e93b2c57-87ac-4342-9631-e29cd94bc52a"), 100, " Arnold Lucy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cf14e012-0332-417f-9c57-58842f7b53d9"), 96, " Corbin Bernsen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f91be6c2-b3fe-4d75-b879-19ff6ca44e2b"), 96, " Val Kilmer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5a4ff32e-5b5b-461b-8442-fc69ffefef09"), 92, " Jacki Weaver" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a9e42017-8b3b-421b-b0bc-c0e946c9fd2d"), 93, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("616bc7fd-336b-4018-8c8e-1edda005da48"), 93, " Mia Wasikowska" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a5351604-0a48-42d4-8a06-d2832a159ae5"), 93, " Helena Bonham Carter" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d4e3cfc8-b532-4e38-8933-dbbef27c214e"), 93, " Anne Hathaway" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d2d29ab1-538e-4d89-a523-db182bc69f4c"), 94, "Ben Kingsley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("eab2cd13-a402-48c4-a43d-f3dd7741bae2"), 96, " Michelle Monaghan" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f9e502a7-b2ab-4ad3-a19e-e5e8ee3c21d5"), 94, " Candice Bergen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5a44f516-55a4-46eb-b28b-db7a1337d285"), 94, " John Gielgud" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7e4bc13f-8b25-4fd2-b51f-d55a5b6154ac"), 95, "Charlie Hunnam" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("81bd6311-76c5-4e09-bc80-d2530fa95ff5"), 95, " Diego Klattenhoff" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("428a495c-23c0-4b44-a865-dd92dc24d51d"), 95, " Idris Elba" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d7185032-8cd9-4791-b0be-10c52e56ee58"), 95, " Rinko Kikuchi" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("744a84f3-7d46-4c6c-b29f-d39cdc5df8dc"), 96, "Robert Downey Jr." });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1bde9b58-e1cd-458a-b16a-61fe9497a40e"), 94, " Edward Fox" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a20697b1-2349-4fb3-b236-56c6b46d7fa2"), 101, "Ralph Fiennes" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("25efe108-1d1f-44c9-bb76-ee81c2881386"), 101, " Juliette Binoche" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("aed75eac-ae6b-4c5d-8c35-074ac62b2efa"), 101, " Willem Dafoe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c6be9403-a8cc-439f-9ef6-155619e018ab"), 106, " William Atherton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e147efbd-2ba5-46b4-9faa-3da8efa78bb8"), 106, " Chad Lindberg" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("00676895-c18f-4117-b6b3-c1bca72e4048"), 107, "Jack Nicholson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8b4168b4-c5e5-48d8-89ae-ebf33b7ac0b8"), 107, " Faye Dunaway" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f128d7d0-d9bc-442a-a832-e7b43ae316b3"), 107, " John Huston" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("468362e2-70eb-466f-b94e-6ebd6a9027d0"), 107, " Perry Lopez" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2d5e6b78-45e0-4be2-95e4-f6fb152144fd"), 106, " Tom Cruise" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("038d9d6b-4f49-4c55-8894-9ab93c7d8429"), 108, "Brendan Gleeson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2a9ea86a-7178-4429-a2c4-27198a870cc5"), 108, " Kelly Reilly" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7d39fb81-4e83-4ec6-8ebc-e4c86db7e505"), 108, " Aidan Gillen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("09f596d5-9725-4fee-8ed0-780100a6dea9"), 109, "Ethan Hawke" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("560e255e-302b-44b3-86a0-723775c8d091"), 109, " Julie Delpy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("be198fc5-cd29-4a7b-9802-358aaba00902"), 109, " Vernon Dobtcheff" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("130605e4-069c-4bb3-8718-0a38808a7374"), 109, " Louise Lemoine Torrès" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("054e3473-4152-45bc-9ab8-eb9fb51e4a78"), 108, " Chris O'Dowd" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e88b136a-f55e-4860-8f48-516c6e536faa"), 106, "Ken Watanabe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3fc0856c-5385-40d7-88ca-f19eaba36d80"), 105, " Amber Heard" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e7d1b0ce-f4ca-448d-94d3-e2c888d7ac6d"), 105, " Michael Rispoli" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c849ff78-1029-46f2-8d72-238feb06f881"), 101, " Kristin Scott Thomas" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2d85d6b7-245b-4f6a-8b63-fbf3b13298d4"), 102, "Matthew McConaughey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6626a83d-bdfa-473c-8d76-a19aae3af3fe"), 102, " Jennifer Garner" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("92ec009d-d2e2-48a3-b5c8-f8827a249877"), 102, " Jared Leto" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0eb359d0-4d3f-4e48-b54a-1f53305dccdf"), 102, " Denis O'Hare" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("20c49447-2c90-42a3-b77d-63c01887743e"), 103, "Salma Hayek" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("eb99c8bf-4b66-4b67-9348-ebb8e87c8df2"), 103, " Mía Maestro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7b3ac170-a3dc-4602-a2b0-21dd0e28a95a"), 103, " Alfred Molina" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bb25771a-0841-48db-8de2-79852e27ebaf"), 103, " Antonio Banderas" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c176b22c-4243-459b-9cee-05428b4a8a93"), 104, "Ethan Hawke" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0a40c2b5-6fe6-48ba-8e2d-098ad20cc308"), 104, " Julie Delpy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7e120ea8-a93f-4ed9-a927-c24068e2c95c"), 104, " Andrea Eckert" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("17286d77-1296-41f0-ae0f-5af72574bed0"), 104, " Hanno Pöschl" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b9f2219b-2ee4-41c8-952a-3a9db8872a35"), 105, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("28fda84a-6fb4-49f9-945c-f82b442376ca"), 105, " Aaron Eckhart" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("74cf1833-6371-4354-bc24-7d3e6262b2e8"), 92, " Robert De Niro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0b442034-173b-4d2a-84d8-e2c138a8c1f3"), 110, "Rumi Hiiragi" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1542cbb4-964c-4fe6-b6ba-6ca07f67da16"), 92, " Jennifer Lawrence" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ac4057f0-984b-47ea-83b8-3ff70d4daca4"), 91, " Xander Berkeley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("69ea0c52-5290-4202-b6b8-d20e3e03a7f7"), 79, "Alfred Molina" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fc8ff0d8-8a12-4241-879b-db0a0d1f8564"), 79, " Carrie-Anne Moss" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fec0a552-24cf-4d3f-9312-6d2513cb3838"), 79, " Aurelien Parent Koenig" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4f834d71-e6c4-472f-80f4-c9a9285db404"), 79, " Antonio Gil" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e469f5a6-af7b-46e0-9ed3-29536c42dab7"), 80, "Daniel Craig" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c26c69ee-2619-420b-b352-4d920fda5096"), 80, " Eva Green" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cc68e98d-0f30-4b9d-be48-1110980e6f7a"), 78, " Dae-han Ji" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bb0ca41f-cdc6-4cc7-ac79-c4c5b1111265"), 80, " Mads Mikkelsen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a8b13be7-2ffd-4308-950d-f1bbac812140"), 81, "Ben Burtt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f9b23d85-284f-4681-9021-7848a89349d8"), 81, " Elissa Knight" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0ee6b149-2310-434c-882f-f9ea3c5dd4e2"), 81, " Jeff Garlin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0bf6eb78-8993-4598-9e33-85fb30c2357f"), 81, " Fred Willard" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ef4411ff-b318-4d9b-b8a0-b5364b187732"), 82, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d66165f4-4df8-4a67-9dd5-6cd898520d97"), 82, " Jonah Hill" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("61a7a8fc-5dc0-4a99-a05b-f316b467f63f"), 80, " Judi Dench" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("af2a0a57-2228-4724-a84d-62f68d6991e6"), 82, " Margot Robbie" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d865dbda-705a-45d8-80ca-85ccff589fc6"), 78, " Hye-jeong Kang" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("aa90c1da-442f-48a3-a042-18f838dc2c56"), 78, "Min-sik Choi" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1182b592-0276-467d-9a86-76089fdbcef3"), 74, " Geoffrey Rush" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e1d73df8-9fdb-45c7-a138-b0000b7bfc30"), 74, " Ian McShane" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4edaacfb-5906-435b-b153-6c528347a245"), 75, "Karina Arroyave" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cbd2c6e5-ead5-405c-b890-2a6318cd1858"), 75, " Dato Bakhtadze" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f4852a32-a78b-4484-91e1-c3d016445782"), 75, " Sandra Bullock" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b2de364b-8331-4ffa-b88b-b038582ab4de"), 75, " Don Cheadle" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0dab488d-7614-4775-9b33-b23b77e6adec"), 78, " Ji-tae Yu" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c4d50320-6beb-4851-b32c-e410434931b3"), 76, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("413eda2d-2b70-4fc8-83ee-6744aae5d0ff"), 76, " Orlando Bloom" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c8a3533c-57d0-432d-97c4-84ce0155aac6"), 76, " Keira Knightley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8a48b172-c451-4b3d-b954-aef10865e695"), 77, "Noel Appleby" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3999eda9-f980-489c-b41b-6bb34aaf2c41"), 77, " Ali Astin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1122b03b-a1d8-4488-b868-fcdd4c9dfe48"), 77, " Sean Astin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f6536965-1887-49fc-ba5e-3717077524b9"), 77, " David Aston" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("231b782d-0d48-4039-9c0a-adba5098eefc"), 76, " Geoffrey Rush" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("adde4d76-ffc8-49c9-9618-c76b7f26da52"), 82, " Matthew McConaughey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("631bbec6-1a9f-4cd1-b677-10a10c04e069"), 83, "Ron Perlman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("05cdd84f-4e01-48a6-b52c-3f56101206cc"), 83, " Selma Blair" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5ab99336-8250-4ff5-a9c7-4cabe66c4f33"), 88, " James Woods" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("451811e5-06b4-44b9-9872-5287667f29ba"), 88, " Elizabeth McGovern" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("be8b4b0b-ab25-4861-8a45-da558401bbfb"), 88, " Joe Pesci" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9d33cb78-c088-43b9-990c-899f64c1cd71"), 89, "Tom Cruise" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("049581d0-df12-4a32-86c2-4212cd6c1718"), 89, " Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1f200255-5f65-4cd8-be86-613926d09023"), 89, " Olga Kurylenko" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6c69deb7-2ef0-41ca-8ebe-f5f25dfe97d9"), 88, "Robert De Niro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5130eb48-3e83-456c-9018-f299ce9f0d70"), 89, " Andrea Riseborough" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d9a1ad53-da12-491b-9cc9-77a26ff370e2"), 90, " Hugo Weaving" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cf178655-589f-4c7d-b8b4-317e4403f4de"), 90, " Stephen Rea" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("137cdbff-53f5-44e8-9474-4e0f926d64a9"), 90, " Stephen Fry" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c5504c85-80b2-45e6-9372-cae3d426e199"), 91, "Ethan Hawke" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("115531e0-5485-4f3b-b01c-86882d5431e0"), 91, " Uma Thurman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("73f64ddc-bf2d-4a06-b2f8-716119659a1d"), 91, " Gore Vidal" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("62f46417-d6dd-424c-bda1-187125d88438"), 90, "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("56ad30c9-4e53-4fea-b674-2434db2d8f23"), 87, " Yasiin Bey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d948e498-1b60-468e-92ce-62090e20dbaa"), 87, " Warwick Davis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bbce77cb-c41e-4421-a562-25b4c9417e64"), 87, " Anna Chancellor" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b8aef6b2-8ecc-4522-b098-3f98423f5871"), 83, " Doug Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b933e67a-585e-45b3-ac5c-df1075cd4d1f"), 83, " John Alexander" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("749cc21a-e40d-4dda-bdb6-d29ac4f39b9f"), 84, "William Holden" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f459f278-399d-440f-ad13-9598673b74d9"), 84, " Gloria Swanson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7ac2d053-300f-4383-8fd9-94af42300af4"), 84, " Erich von Stroheim" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3ac137fa-9409-44e3-b0e7-ddb1e979c6b8"), 84, " Nancy Olson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d182472d-7845-4fdd-8c0f-846858f49598"), 85, "Beau Bridges" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("59c061c3-8dfa-426a-8702-f9351c7b94ff"), 85, " Rosanna Arquette" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("766f1cc4-eac3-4a76-bf79-625030becee8"), 85, " Mathew Botuchis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3e4430d0-0c5c-4e86-b995-e42445d40d8b"), 85, " Shiri Appleby" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0a7fe410-292e-4299-a0f1-9fc31fcbbb39"), 86, "Ralph Fiennes" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5949f280-1b0e-4341-8c43-2faac48da3ab"), 86, " F. Murray Abraham" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("576682a8-f376-4e66-b526-3dd0980bdc7f"), 86, " Mathieu Amalric" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d56f4ca0-0adb-4bee-b0cb-abad5d5b012f"), 86, " Adrien Brody" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("647aca17-73cd-4bec-aa83-5181b396c6e9"), 87, "Bill Bailey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a20c2048-e855-4ca2-9a7e-0cb9f84dbafd"), 92, "Bradley Cooper" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5c48972a-6eae-43af-9d88-387e5bd247da"), 74, " Penélope Cruz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8b01f7a8-61ad-4510-81bc-1a7e0bed8891"), 110, " Miyu Irino" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3f211a5a-c756-4777-bea6-83b377dbf40d"), 110, " Takashi Naitô" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2fafe9c6-c504-4257-ac59-83fcb30ef47d"), 133, " Sala Baker" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3e62bbd0-c248-4fbc-b445-ff8bbbfd49c7"), 134, "Domhnall Gleeson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bfe54ef2-9250-498e-ab92-5b5d0d082651"), 134, " Corey Johnson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e54abbad-e9a0-462a-ba86-85331b2f5e15"), 134, " Oscar Isaac" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("612b6218-b774-4da0-b33d-0ddaa2eb9068"), 134, " Alicia Vikander" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("69c530c7-b27d-4d03-807a-f7d880e3ca6b"), 135, "Eddie Redmayne" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d4acf079-da39-4737-8ce7-aedc1559eadd"), 133, " John Bach" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6a2f7643-57aa-4ed9-ba41-05cf6bcee161"), 135, " Felicity Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b91fd3be-5954-4d0f-8b2e-669448fe61a7"), 135, " Sophie Perry" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4425d515-1b00-438c-8727-3363a60bba99"), 136, "Richard Chamberlain" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("62c49b54-ea47-45d3-b427-2a76ee93979c"), 136, " Toshirô Mifune" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("89a01913-c67a-4148-8b7e-3f0e1c0fc681"), 136, " Yôko Shimada" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d9ae3680-bc0a-439e-9222-7e879df8982f"), 136, " Furankî Sakai" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dac4a466-2fd0-4545-ace9-a4788c3edfe0"), 137, "Mark Ruffalo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4368c275-7fdd-4f5e-85a7-658ed3a651e3"), 135, " Tom Prior" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("064bfa9e-2a0f-4d40-8a14-9cbb96c406ba"), 137, " Michael Keaton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b5e45236-b473-459e-bf74-4a0c9781be3f"), 133, " Sean Astin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("62fa3e6a-1fdb-4857-955b-4cb4d6b27391"), 132, " Sala Baker" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e502bbc2-154c-4d6b-9d3b-9ae9e8fd0222"), 129, " Martin Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4bd48df0-451a-4226-b2dd-4cd479e5f59a"), 129, " Richard Armitage" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e5c56f29-36b3-45f7-b0b0-38d6ee3b1670"), 129, " Ken Stott" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6fda2655-e72f-4108-b779-078b12327724"), 130, "Lisa Adam" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("168afe1c-485a-4b74-9e80-d109b37c1a84"), 130, " Frank Aldridge" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ce41b1d2-3862-4468-a018-93159ddcf2ed"), 130, " Amitabh Bachchan" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8f182ce7-346f-43e1-acef-9a2f42a10f7b"), 133, "Bruce Allpress" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b758758f-bdb2-4bf1-90c7-282c75d360f8"), 130, " Steve Bisley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b2973e41-6d8e-4072-9baa-1ee7685e2e26"), 131, " John Leguizamo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("46af1625-70cd-4b93-8ae0-6aab4fc288a6"), 131, " Denis Leary" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("93e109b6-19a6-4e7b-9a4c-a9df08a5fecd"), 131, " Goran Visnjic" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("69263280-0f0e-45d6-8d8d-6bbc91d76113"), 132, "Alan Howard" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5d4eef75-7f95-42d9-a72d-211ccf43fab4"), 132, " Noel Appleby" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f96dafc6-dfec-4d71-a0d1-92173e19b53c"), 132, " Sean Astin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("69642773-008b-4891-88f3-f6174447db32"), 131, "Ray Romano" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("214b91dd-91d2-4a7e-a026-6ffe29a85498"), 137, " Rachel McAdams" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d334bc8d-eb77-4763-926d-79a2e8878cec"), 137, " Liev Schreiber" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c7471738-e3b4-4c1d-ab20-77a9875f0ab1"), 138, "James Stewart" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("54ccbd02-952f-4afe-bd08-00106a80fbba"), 143, "Gregory Peck" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("90b30fd8-35e0-4127-ac72-a2d585b63f20"), 143, " John Megna" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("579f736a-a775-4e05-ac8d-027b70675558"), 143, " Frank Overton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a4461885-5fb9-4fb1-aa44-42d39e0560a5"), 143, " Rosemary Murphy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68f5d171-0ae3-4e10-aad2-feb3764b028e"), 144, "Samuel L. Jackson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("42118abd-9e28-40e7-a767-e5fbbbe2c807"), 144, " Kurt Russell" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cd70bd2d-2aad-4d3b-a3d6-3df8b3759eb7"), 142, " Jeff Daniels" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("017d174f-833f-4526-95dc-aa28ab217814"), 144, " Jennifer Jason Leigh" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ad621fbe-e848-4e80-abda-f5323cdad786"), 145, "Peyman Moaadi" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("64cce850-908a-45f6-9aac-cfe8c44153f4"), 145, " Leila Hatami" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b17ddc3f-e68b-49ad-bc56-5672a48a3f5c"), 145, " Sareh Bayat" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6b0020bb-a058-4c3c-ba5d-a2939952ca92"), 145, " Shahab Hosseini" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6bb836b0-5eb1-4916-abd5-35d61fd6638a"), 146, "Ryan Gosling" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("45044919-5c66-432e-86a3-60aea28df21b"), 146, " Rudy Eisenzopf" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9fc2ecd0-6410-44ae-a3e3-004eb6ea190d"), 144, " Walton Goggins" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c43e9b35-1118-4a5a-aa67-1918d8ae9d58"), 142, " Kristen Wiig" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9b23e88c-9c4a-4b90-9949-6ba385c3ddf6"), 142, " Jessica Chastain" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7faf3426-4910-41d4-b959-579564af74c2"), 142, "Matt Damon" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a8787921-1716-4eb1-9665-3fe8295e05e3"), 138, " Kim Novak" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("aafaee88-8233-42de-b5b2-5e709d60ea57"), 138, " Barbara Bel Geddes" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0df4296d-a0a1-423a-b33e-6f5527047fb2"), 138, " Tom Helmore" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6d6e9f06-ca79-49da-bc26-06a9476e0466"), 139, "Miles Teller" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dbe89355-3980-42b3-88a6-780e473e2349"), 139, " J.K. Simmons" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("792f58dc-4c1b-459e-980c-b6f0be559989"), 139, " Paul Reiser" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5e0e1068-1c5b-44d2-a21e-415553c1828b"), 139, " Melissa Benoist" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("05fabac8-318d-41ee-aa92-4a4722955929"), 140, "Martina Gedeck" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c8e0a013-3a5f-40e3-b51f-b6f56fc21ea7"), 140, " Ulrich Mühe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d8c87c0c-b5c2-4a16-b1e0-94b96334fafb"), 140, " Sebastian Koch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("da2c62ac-b7dc-4d6e-8982-82cb9d775a05"), 140, " Ulrich Tukur" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8069f495-e527-4c7f-9176-65e66fa5f103"), 141, "Xolani Mali" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d81577de-cdf3-4440-8654-f682ca35c624"), 141, " Don Cheadle" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f571d8fc-b370-4669-9aef-7b3af7a59c87"), 141, " Desmond Dube" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f18b983a-5d09-4e68-af4f-f2f5533e4b53"), 141, " Hakeem Kae-Kazim" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1ebc6b82-7320-461d-9423-26c4ae1ea434"), 129, "Ian McKellen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("63da687f-c48b-4950-9ad9-b3a97f77996f"), 110, " Mari Natsuki" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("681cef8b-6e60-481e-9354-0ec17d19e318"), 128, " Adoni Maropis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8b66342c-d4c2-4c7c-9786-d0dc1feb0a3c"), 128, " Brian Cox" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dc315ce1-eb0b-4adf-8469-28847fb7b902"), 115, " Matthew Goode" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("78564b09-c9de-4b1d-abdc-ba944c89c257"), 115, " Rory Kinnear" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("78e8b09a-ea89-4fd8-a505-ed7c2375262d"), 116, "Ellen Burstyn" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("831b2caa-ec8a-49ef-a134-f4a9c3a405f7"), 116, " Matthew McConaughey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8d1103d0-e568-47f6-9df9-aad28298e9a7"), 116, " Mackenzie Foy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e8378946-1055-4fd1-8314-9bd0331ef3ce"), 116, " John Lithgow" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ca84180c-8322-4644-9d34-4132ee0ac257"), 115, " Keira Knightley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fd8aa01e-8b89-486e-81d0-10709772a8d2"), 117, "David Schwimmer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("08405fd5-aefa-49ff-8ab0-e0cefac3a672"), 117, " Alice Eve" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("51e7aa06-600e-4854-9250-865354c42cde"), 117, " Natascha McElhone" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3366dc52-8810-4ef8-affc-83e4eb35abb4"), 118, "Jürgen Prochnow" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("49750a53-c5c6-4a16-a823-94715f0c7a4a"), 118, " Herbert Grönemeyer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8cafa8c1-f02e-4421-8483-6b0542bed232"), 118, " Klaus Wennemann" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c7ad85a2-5b2c-4da7-979a-1959bd606e2b"), 118, " Hubertus Bengsch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a4f472fd-a9bc-4061-b428-4ed7654e8ada"), 117, " Simon Pegg" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c6c39100-b7e7-43f3-814b-61b573681751"), 119, "Mike Myers" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ded48199-ddb3-4d70-8374-fd9c219852a8"), 115, "Benedict Cumberbatch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("edc8682e-6203-4a40-a2bf-f20c5665454c"), 114, " Lee J. Cobb" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e8b2debb-ffc7-4b30-b491-26c34eac2c8e"), 111, "Catherine Deneuve" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("11e727bd-cac2-40e3-bc5d-2b77e4624c6f"), 111, " Vincent Perez" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fceaa569-d776-452e-8476-fdc778923273"), 111, " Linh Dan Pham" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("daa3da17-5632-4b84-be3d-54471f5fb31f"), 111, " Jean Yanne" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("23066b5d-f210-44ff-b228-956d9cfe8bf8"), 112, "Michael Keaton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("03f4ef40-2de5-4bde-9484-1cf074f7d76d"), 112, " Emma Stone" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5addcedf-39c1-42e6-b859-351258c319ca"), 114, " E.G. Marshall" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("19748c6f-e132-4585-8523-4a6a0c193b45"), 112, " Kenny Chin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7510b417-18e2-4068-b175-562ddb8edf32"), 113, "Ellar Coltrane" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9c1c0c3f-b7cd-4691-81a2-66f2a22d2b8f"), 113, " Patricia Arquette" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8f097512-8d4c-45b0-b2cf-aa76a9492369"), 113, " Elijah Smith" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ea3d2966-aa13-4bae-8a50-de0d1bdff46f"), 113, " Lorelei Linklater" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2b016e26-ecc0-48b9-a03e-2e598b6e1b76"), 114, "Martin Balsam" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ad05fe78-d6d1-441f-8370-7164e283ceb3"), 114, " John Fiedler" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e979e9e5-1198-4e47-9a52-3cfe7aa4b47b"), 112, " Jamahl Garrison-Lowe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("71913fdf-62ff-430c-bb80-d913eb6dd985"), 119, " Eddie Murphy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dade2bf3-699a-4195-b502-e79ac3f2eb87"), 119, " Cameron Diaz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("903b663e-ec77-438c-902a-1dc6b66f1bd0"), 119, " Julie Andrews" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("72a34d41-be29-4b9b-89dd-cb75e73c3bc2"), 124, " Jack Thompson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b3ad41d3-273e-46e4-bb7f-16e639196a38"), 125, "Mike Myers" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ec2f656a-ac4f-4340-b4ae-aec3e6127179"), 125, " Eddie Murphy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e7e10bfe-f48d-4404-af9a-e8ff36ecbb8a"), 125, " Cameron Diaz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c36d4d3f-d114-4387-b0d2-b6ec3200cc66"), 125, " Antonio Banderas" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2d975ead-a9c2-4e2c-bf97-ffebaed03154"), 126, "Ethan Hawke" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("24c51067-97bc-4b39-82ae-956fcd1cea58"), 124, " Thomas Jane" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ec2ea56b-0ca8-4ecf-b8b6-fe7a56d44bfc"), 126, " Julie Delpy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("77e84611-36a1-4973-b84a-6763d3b9f2b1"), 126, " Jennifer Prior" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("eaeece06-f674-4a19-9045-0c5f20726986"), 127, "Steve Carell" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("97099c2e-68b5-44ee-9ab6-57590d6deeb1"), 127, " Jason Segel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8d966147-43c0-42d9-b9a7-f8111bfd7710"), 127, " Russell Brand" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7e6b96ca-2077-4dcc-adb4-375773e472ef"), 127, " Julie Andrews" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5ac28653-02d2-4a93-a96b-38c76c1f2865"), 128, "Julian Glover" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cd4f8c08-84b6-44e9-bcd1-98277d88c0ae"), 126, " Seamus Davey-Fitzpatrick" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0ba30252-e535-46fc-bbce-435abc26f99f"), 124, " Angelina Jolie" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3324d068-f82f-41ff-b939-6c71045ce016"), 124, "Antonio Banderas" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("98f4b699-ccaf-41e1-83b2-ac1595d172ee"), 123, " Adam Brody" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e651d3fb-85fa-496c-b93b-08444f08c5c1"), 120, "Jessica Alba" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f832cb84-f643-46d5-b871-da5a77a35ab8"), 120, " Devon Aoki" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("255af511-f501-4f1c-bdb7-b39e38821134"), 120, " Alexis Bledel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e2703bf7-875e-41b9-b03f-1b012d2ad4b8"), 120, " Powers Boothe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d7e7f3ea-8602-487a-b88b-27b082612318"), 121, "Bruce Dern" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e9fc064f-a55d-4590-baff-fded4c54a6e9"), 121, " Will Forte" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2514de2e-1375-46a3-9dd8-e4732eff4cc1"), 121, " June Squibb" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("78a78097-63b2-484e-8039-fb82e1aa2377"), 121, " Bob Odenkirk" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("14bd4a9e-c8ff-4168-bedd-53e02c6a2fa1"), 122, "Mike Myers" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68f86a00-0330-4e8f-b332-92de0e93da0a"), 122, " Eddie Murphy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0174ba78-dffc-4a43-96be-363b2abaa544"), 122, " Cameron Diaz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("87769031-7b19-417c-9c24-6749bc93352c"), 122, " John Lithgow" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a493e396-3d13-4082-b3b0-81a2185b45ab"), 123, "Brad Pitt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c075ff7f-42ab-4321-8923-b4b6d5d8e639"), 123, " Angelina Jolie" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("083a0b8d-4109-4206-a1d6-9a272dbfd84e"), 123, " Vince Vaughn" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("beef32b4-2b02-4a4e-8fb6-00871fe25e53"), 128, " Nathan Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("424f6802-8566-4638-bedd-e2d271a7139d"), 74, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d0755988-3ef9-4cc5-ba78-0042b033b68d"), 73, " Keira Knightley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("90469831-e3d0-4196-89f9-bfb6de615941"), 73, " Orlando Bloom" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("009ef7d4-62e7-4dcf-aa74-381c8255a1af"), 24, "Ethan Suplee" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fefe5317-3cd4-4716-83a2-7ccf3b531172"), 24, " Ben Affleck" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6a901653-c3ba-4388-9fbe-5c28f6769fef"), 24, " Scott Mosier" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("309a9f88-516a-4dda-b90d-30eaaefcc7a2"), 24, " Jason Lee" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("50dfcba4-ea73-4024-bdec-b6afc92e7340"), 25, "Jamie Foxx" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e6b6e7b3-1cf4-4595-b882-40f46b1e1375"), 25, " Christoph Waltz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dabd5239-77b9-461a-9ea4-0f8c1919d596"), 23, " Christopher Walken" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cef50b70-90b7-4270-9323-6938a6b2f161"), 25, " Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("75743a0b-f549-4ece-a49a-ea32ab273eb2"), 26, "Jodie Foster" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("33dfe746-5b82-4e04-8ed0-aca340cd3e5b"), 26, " Lawrence A. Bonney" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c3b82eb5-6075-4ee2-a359-7979b5223dc2"), 26, " Kasi Lemmons" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1e3f54ee-aae4-49af-be85-54d89f942332"), 26, " Lawrence T. Wrentz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9df1e771-8df0-4eb0-ad01-3fc70ebca7d8"), 27, "Kevin Spacey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c28230f4-00d5-4062-a0e1-cdf077d10c3a"), 27, " Annette Bening" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("462203ea-9142-4bbe-9154-2842b6bcf7e1"), 25, " Kerry Washington" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9b66f84e-0e4a-48ff-8028-b85c29700b27"), 27, " Thora Birch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("edbb78df-cfdb-4907-bc72-b60b3f1d63fd"), 23, " John Savage" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("96eee8f0-df39-44eb-b11f-67d4185cd717"), 23, "Robert De Niro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5998255c-582a-4970-9a04-38558e17827e"), 19, " Michelle Pfeiffer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("890417be-2513-4949-92c7-11f6fe70c857"), 19, " Mary Elizabeth Mastrantonio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7c5a8d70-f76f-4552-8322-95da8a7a0b37"), 20, "Gary Oldman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("017899db-a863-4bff-a946-cf60e454f4ec"), 20, " Chloe Webb" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f22be3c1-bb14-4003-b833-0230f4065f82"), 20, " David Hayman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dac5617d-f7d7-427e-bce0-81df5d36cb3b"), 20, " Debby Bishop" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("18df4090-0a9a-413a-ac96-fc002ccf5891"), 23, " John Cazale" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("979dd321-4044-450a-8b26-28ab5c072bdb"), 21, "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a8dd3441-0a38-4b96-97c4-8ce63bfcdc44"), 21, " Vincent Cassel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("de50ffbf-8cb4-4a2a-a681-0472e65300b6"), 21, " Barbara Hershey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1d3b0905-47ea-41cc-9158-098ed0ac8247"), 22, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("41d0ffce-04ef-422f-9920-f09aad2061f4"), 22, " Joseph Gordon-Levitt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("06f1db46-5378-498c-8d57-2be64379615a"), 22, " Ellen Page" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fd192b14-a8f8-4302-9a77-1732bdea2082"), 22, " Tom Hardy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("af97f5bc-4278-40fa-b767-3d2d2d549176"), 21, " Mila Kunis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a9b58868-ddce-41c0-835e-2a2d7546a996"), 27, " Wes Bentley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3e8165ce-8233-40fe-b7d6-ac8f994de338"), 28, "Benicio Del Toro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a11035eb-6ebf-4071-b452-63dfeb71ed2b"), 28, " Dennis Farina" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dfe240f4-76f4-4986-a64e-e027491e18a4"), 33, " Grace Kelly" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e660d64a-8c5b-4390-8909-0c561736415e"), 33, " Wendell Corey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b425f851-b47c-4455-ad3c-b533a26b33f3"), 33, " Thelma Ritter" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1ad0ace6-ed30-4d93-99c0-3e9f20e62a06"), 34, "Ivana Baquero" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5197eaff-a036-474e-a8df-259071c51627"), 34, " Sergi López" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("472fd76d-2e1f-4e69-9efa-1dcc40eb8840"), 34, " Maribel Verdú" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ac48e323-54ef-455b-9368-2a0acde9dd75"), 33, "James Stewart" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5594e4de-488c-4cff-88e7-ee7be1d4fdd5"), 34, " Doug Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("90d59d25-88f0-4e8e-b140-684f8d0a06ee"), 35, " Mark Ruffalo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7f551434-8d4f-42a4-8553-eab29bc8e72a"), 35, " Ben Kingsley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("29e3c70c-491b-4e14-849c-af1265b80b14"), 35, " Max von Sydow" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("58256233-5700-4b0b-b915-eedb73c527b4"), 36, "Harvey Keitel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ead75674-da50-4240-9615-c31e1d120bb5"), 36, " Tim Roth" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("35a87147-c764-43fd-b9d9-5fa9654a5fc7"), 36, " Michael Madsen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c1b0a0da-bd93-4189-a211-d45ac379fbf4"), 35, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("808c9002-d3e3-4bd9-8579-3a3cf8b7d1ed"), 32, " Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("178778b5-412b-4916-80dc-eecefb0d9697"), 32, " Lucy Liu" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8bfc1c2b-7120-4a6c-900e-b2de11ecb522"), 32, " Bruce Willis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c2a0344c-7833-4b29-8a04-1ed13afddc82"), 28, " Vinnie Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ad89a567-917a-4b38-a8f3-6bbaf1bb900f"), 28, " Brad Pitt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("77c75ecd-ac63-4452-941c-b8630086114d"), 29, "Brad Davis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4b7c2f71-5516-46e4-a67e-71eba22fd4d4"), 29, " Irene Miracle" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c41840b0-4a22-4c29-99e6-ed3fe66478f1"), 29, " Bo Hopkins" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2662e026-4326-48c1-89bb-afd1c9813945"), 29, " Paolo Bonacelli" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("be2a7073-d974-4816-9bd2-b871b42d8853"), 30, "Tim Roth" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c3cb1a20-0834-4fe8-a922-a79a728088fc"), 30, " Amanda Plummer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9e044d77-a118-48d1-ac31-09595ceefee4"), 30, " Laura Lovelace" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("13256000-0a0a-4b5a-8dbd-17b5083d1e35"), 30, " John Travolta" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f0e523e0-bd33-479b-b76a-3c4864a0d8fd"), 31, "Jason Flemyng" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d2e4c0b6-caf6-46e2-b145-bf36ad219c7f"), 31, " Dexter Fletcher" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8d0b8d38-dab9-4a17-bcf7-2417f99883df"), 31, " Nick Moran" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b80b390b-46e2-4cf0-b34b-509ffc3a7890"), 31, " Jason Statham" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("843eaeb2-12bc-4f2d-bdd6-9466d5868e83"), 32, "Josh Hartnett" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c8b73ad5-c8a7-4814-bc00-2f67a0cf4187"), 19, " Steven Bauer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3e4e1cd2-d2b7-432c-a8da-981b8daa9b82"), 36, " Chris Penn" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b5d0e1e5-b8b2-40c6-8de4-a775a7e6977c"), 19, "Al Pacino" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ca4bf81d-298e-4fb9-8a32-4af12cc802ad"), 18, " Patcharawan Patarakijjanon" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b03b491d-95b8-4510-969b-2f36412d8d74"), 5, " Tom Wilkinson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8ee7584f-3c60-4f09-852a-c7d963e28d38"), 6, "Patton Oswalt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("289dbdcd-f8e8-4db2-ad18-1e0e0f307201"), 6, " Ian Holm" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("26fdc051-913e-46e6-af91-19c7fac687ce"), 6, " Lou Romano" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e837a786-19ef-441b-8968-ab1237ee79b0"), 6, " Brian Dennehy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5b7a8f61-997a-47bc-ad37-d2fd8f0e00e1"), 7, "Alexandre Rodrigues" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("41a12e50-2015-45b0-9f39-1178d1b248fe"), 5, " Bill Nighy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("78e05fcb-db08-4c95-bd40-9798c2a90afd"), 7, " Leandro Firmino" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0144742c-efab-480c-94da-e97adea63457"), 7, " Douglas Silva" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f53970c4-8eaf-4b87-8eb0-39743eb4d882"), 8, "Guy Pearce" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8542453e-5e25-45e7-9e36-1f733582338d"), 8, " Carrie-Anne Moss" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1d95d2fa-9799-4e32-8dcf-4411d66f2f31"), 8, " Joe Pantoliano" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9fe4974e-af24-4bcb-8db2-735b3bea75c3"), 8, " Mark Boone Junior" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ceee757f-34db-46ea-b07d-227d27eb77b5"), 9, "François Cluzet" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f6d02c04-264c-4568-a08f-8788e0acd10b"), 7, " Phellipe Haagensen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("eb4cbd74-a507-49b4-9273-6fedbd26c1f1"), 9, " Omar Sy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8bffdd68-23c9-4d22-bcb9-f1d41cf647ec"), 5, " Kenneth Branagh" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cf13ce70-12d3-4f3a-a0b8-c9010e45f3ca"), 4, " David Gulpilil" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b9b54787-6827-414c-afad-efd6cb1ee2ad"), 1, " Geena Davis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ae22b9c9-ab22-447d-9bd1-696eb7b556fa"), 1, " Annie McEnroe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("912b2e71-7d14-4aee-a69e-2cfaf2cdd642"), 1, " Maurice Page" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bddab2d8-226f-433e-8f38-8f0c59fcd01f"), 2, "Richard Gere" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d584a146-7bc2-4b0c-9761-b6e22153cc9f"), 2, " Gregory Hines" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("67506c9a-73c3-4f8d-ab28-1bfeb884c0a2"), 2, " Diane Lane" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("555606ba-9be9-43d4-b7f1-80fdccac1682"), 5, "Tom Cruise" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("463b641f-0dad-4b04-9141-67593459bf3d"), 2, " Lonette McKee" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("89b33c00-c231-4e4b-bfad-600ce524d0f7"), 3, " Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4dbd65be-0cad-4462-98dc-f1a9a08b35ba"), 3, " Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6ed9f31c-cdda-4c27-8066-1efe2a0990fd"), 3, " William Sadler" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("118d676c-83f3-4bad-ac45-25ec0019b039"), 4, "Paul Hogan" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6d12fc89-422d-4c6f-b2ae-fa302741d626"), 4, " Linda Kozlowski" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("57d8a523-5188-49be-b132-f90e7f3c8169"), 4, " John Meillon" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("98a58f2f-4ac3-4f54-bf68-075ea40c68f8"), 3, "Tim Robbins" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5754893e-2d8d-4e6b-a6f2-816a268a5ce5"), 9, " Anne Le Ny" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ecf7e8d7-eb57-4357-b66d-5f7b4171cb53"), 9, " Audrey Fleurot" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("eeb43c64-4a27-44ec-900f-3f81638d011a"), 10, "Ian McKellen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("329aa4c7-a45c-452c-8300-27d18c2f6582"), 15, "Joseph Gordon-Levitt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("25d23b41-a466-4c19-a114-d81d714755c0"), 15, " Bruce Willis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b1d21c9e-b0ec-4709-aee3-c2950c632d4c"), 15, " Emily Blunt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1eb49045-5a04-4877-9fab-8a2ec8fbf72b"), 15, " Paul Dano" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ff627824-c500-4a80-8c62-c19866a31e4a"), 16, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("513683c8-1856-44c7-a03e-8a48c64d6f3b"), 16, " Helena Bonham Carter" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c6b7f973-9141-4bed-901d-4c037bb9f4ef"), 14, " Dwayne Johnson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1e912c9b-3d46-4d7e-9bf8-e2d41debb36a"), 16, " Emily Watson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a28d74f8-f039-4152-bed7-e1a8f9cd3322"), 17, "Joseph Cotten" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6ce0cad0-2c40-4768-8a76-29febcccde99"), 17, " Alida Valli" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8aabd98d-f072-4d04-8e10-7f2ca3ff0c12"), 17, " Orson Welles" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cff2e2ff-b595-4e98-a544-b7c036f9f9de"), 17, " Trevor Howard" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0dd798d2-724a-493f-85e4-68b5d5a71dda"), 18, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cbc57188-1d5a-4014-a72b-8147d59bd474"), 18, " Daniel York" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("17046827-418c-4b36-9b2b-5d90fd7db490"), 16, " Tracey Ullman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a2810a64-eaec-4a8b-86ba-df36b5f40d12"), 14, " Gary Oldman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("444e5f2c-8b1b-4de0-bf15-77f53cc8d78a"), 14, " John Cleese" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("377bae2e-0fa6-470f-bd20-90e9a8f46ad2"), 14, "Jessica Biel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b935fc7a-8957-43e1-8bcb-2e980148dbef"), 10, " Bimbo Hart" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3bd56fd4-57d4-4b22-9a14-418d6889b728"), 10, " Alastair MacIntosh" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f2bbccba-454a-47cb-8fe9-ca8e4931fc65"), 10, " David Kelly" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0554a259-8a14-4faf-a152-f9a93a656dbc"), 11, "Rudy Youngblood" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("36759e86-94ae-46b3-92f9-d33255065fff"), 11, " Dalia Hernández" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e5ab7657-bab8-4bbf-bca2-23a42532ea43"), 11, " Jonathan Brewer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d7858a55-dac5-41fd-b3ad-7da00083cad9"), 11, " Morris Birdyellowhead" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("22652344-4f40-46f1-9e91-b2a897232fe6"), 12, "Diahnne Abbott" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6629b935-fcbd-42c4-baff-5ea829a41e28"), 12, " Frank Adu" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c64c5add-9dd8-4f50-ac26-40cf320a650e"), 12, " Victor Argo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d71f2d25-2303-465e-8988-9ad9b6b2190d"), 12, " Gino Ardito" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4367eda2-6dbd-4d60-abc9-d0f1e35eb505"), 13, "Tommy Lee Jones" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("78d71beb-5495-4d54-899f-37f368491473"), 13, " Javier Bardem" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4a71b72e-e254-4f2d-9cb6-3f4831cd7a36"), 13, " Josh Brolin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ecf4cfbb-0852-4471-8734-05eec281ffb7"), 13, " Woody Harrelson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bb9cc6b1-ac1b-4858-b562-74961b7d9577"), 18, " Virginie Ledoyen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68ac630c-ae96-494f-8f74-2453d137ed03"), 37, "Jack Nicholson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6064da15-1111-4175-b7d5-982696c08471"), 37, " Shelley Duvall" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a4813edf-0bf0-47ad-bb7a-876aab4cec28"), 37, " Danny Lloyd" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fcd9e099-2ade-4fbb-8ede-269d49447c7a"), 60, " Miranda Cosgrove" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("be4ba872-704c-4e80-b928-c9065959b178"), 61, "Bruno Ganz" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c58bd3d5-c3f2-4a87-afff-68b2354cc082"), 61, " Alexandra Maria Lara" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("de97aec2-54c3-4da5-b49e-ea1222071e61"), 61, " Corinna Harfouch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c3adf03b-c9e4-430e-887f-1d2583ba5e33"), 61, " Ulrich Matthes" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6c6923ba-f316-4f07-b8c0-bcc4ec7cee76"), 62, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3dff0d35-f54e-4ee7-9413-80806735f5a3"), 60, " Benjamin Bratt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8297d71a-aa03-47d6-b776-5da86da02d7c"), 62, " Chris Rock" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("99326201-6c3e-4af4-b312-afebea0ecd59"), 62, " Jada Pinkett Smith" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9b12f2d6-fca0-4223-abd9-3d0636fecbc8"), 63, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("51d17b4c-9a85-448b-87e7-b6c5c29f35a6"), 63, " Chris Rock" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d28fdd4f-c18d-4a11-83c8-4905cb78fc42"), 63, " David Schwimmer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dd16a919-bc45-45c2-8db3-0d67e61cf31c"), 63, " Jada Pinkett Smith" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5eecb894-515e-4be6-879b-3572c85916b4"), 64, "Joel Murray" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1dfaea50-7172-489b-a087-2feadcccac91"), 62, " David Schwimmer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f7d4dda9-d81e-4b55-9881-7a43b0ac7868"), 64, " Tara Lynne Barr" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e73add21-4729-4732-bcdd-f92dd9ba2910"), 60, " Kristen Wiig" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("64c7aba2-1d72-40f8-8e9d-2e45ded832b2"), 59, " Jada Pinkett Smith" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("79b5e359-2e61-44c8-808e-58f85cd16d26"), 56, " Alexander Armstrong" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9a0a87ae-e90d-4f0b-bf04-77ad30eba374"), 56, " Paul Kaye" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8f30f5d1-f330-41ec-a0e3-f350e56ccb8d"), 56, " Matthew Goode" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a5f2b4df-8610-49ba-b269-a96355c1e5d9"), 57, "Anthony Perkins" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2fee60a3-6d28-4994-b6ec-6fbc5b9970c9"), 57, " Vera Miles" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8931d619-c47f-4d25-aee2-448d5593e6a0"), 57, " John Gavin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d8c0d414-5af2-4472-88e2-e31206d27f3b"), 60, "Steve Carell" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8db922c2-4024-490b-be8b-8a988fc8dca5"), 57, " Janet Leigh" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("94170bc7-d249-4949-bb84-e97d24a31b8e"), 58, " Eva Marie Saint" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5d7f4d2b-1e0d-41bc-9c00-581e6c970845"), 58, " James Mason" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("acae9109-d955-44c4-a530-2f6f72505165"), 58, " Jessie Royce Landis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("245dcf58-6daa-4fb5-8eee-5a2b54303735"), 59, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b633cf36-c043-4c71-ac70-7685841f226d"), 59, " Chris Rock" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a48aba38-9865-462e-9c88-3d30334fa95b"), 59, " David Schwimmer" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("20dbc566-8c2a-4629-a6c3-18793e1f940c"), 58, "Cary Grant" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b018d6bc-ce40-4ff9-992c-976827a77506"), 64, " Melinda Page Hamilton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1ebf1f06-9a09-4f1a-bea9-32470a8f607f"), 64, " Mackenzie Brooke Smith" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c78827da-fd55-4f8a-9506-27d8b18a1e41"), 65, "Jesse Eisenberg" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("074d1807-ed1b-49ac-bd41-eec0e55bc8a7"), 70, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9fd89d24-3509-4dd9-a484-cc80c3b87dd2"), 70, " Tom Hanks" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("18cbd0be-b10e-46ba-9193-3e6a64add698"), 70, " Christopher Walken" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6270af2a-f64e-4628-a3f7-c9914ee6e114"), 70, " Martin Sheen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7b08b4fd-f667-455a-9455-a5ffab734807"), 71, "Edward Norton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3c17ed8c-bb35-4f99-95fc-57f15ac657b4"), 71, " Edward Furlong" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("fcbfe0e2-1992-4145-9449-219d7722ecea"), 69, " Josh Brolin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ae6415b6-284a-4141-a77d-a4607f4c3afb"), 71, " Beverly D'Angelo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7b5d5992-65e0-43e4-b7cb-e6189d607d9e"), 72, "Robert De Niro" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3aecb464-bde0-42a1-8e60-aafb1d5540f6"), 72, " Sharon Stone" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("612571cb-0fe6-4f3f-9b26-35dce5d7118a"), 72, " Joe Pesci" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b33cd7fb-20a5-4c8b-a42a-b3d0baf8ed65"), 72, " James Woods" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a9944941-5a23-4cc7-b3d4-a2629723b3c3"), 73, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4a716c50-6719-430b-a7c4-b60dfc25d517"), 73, " Geoffrey Rush" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("08812748-cc0d-4cd3-8be3-891db3af343d"), 71, " Jennifer Lien" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ac3bbeec-1a7b-4254-8082-bafd8f44d65f"), 69, " Chiwetel Ejiofor" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("57176698-dc22-45c4-a12b-4e56ab7097d2"), 69, " Russell Crowe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("64b2c894-e77a-4f8c-b4d4-36595e667ea0"), 69, "Denzel Washington" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("27bd2b55-8f10-4793-ad6a-2e80e1bc7e1b"), 65, " Rooney Mara" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ecd63ce0-0484-4e7c-a66f-c5cb1ef2215c"), 65, " Bryan Barter" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("350ad9c4-bb8e-43bd-869c-57218c9fdd9e"), 65, " Dustin Fitzsimons" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c3ff3676-87bf-4e9a-9a9d-ef2add0be78c"), 66, "Adrien Brody" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b932f603-e3d4-436a-9170-ac1982486317"), 66, " Emilia Fox" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("da46a34e-cf0a-4e1e-85bf-29525f81e8ea"), 66, " Michal Zebrowski" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cd4ce6c9-f5d3-4a97-9868-ee0a5b4a2cff"), 66, " Ed Stoppard" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1d83debc-65ee-4a1a-83a6-bcedcb07e6e9"), 67, "Ethan Hawke" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d0976475-4d0c-4383-8dda-2c29416f2aa6"), 67, " Vincent Spano" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("edffd015-e620-4997-9315-1248c46fa616"), 67, " Josh Hamilton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d9027f77-2f1c-4d56-8f1e-b71c4db7c06b"), 67, " Bruce Ramsay" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("53f9e734-0a09-46ec-90aa-0d61d1ce08c5"), 68, "Humphrey Bogart" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("302b6e4d-8e0d-425e-968e-014200e1dbd3"), 68, " Ingrid Bergman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cd4662f4-d09b-4008-bc43-3952ba40606c"), 68, " Paul Henreid" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d9eba523-361e-4643-9c43-62c1fa8a52d7"), 68, " Claude Rains" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e091cbbd-85a8-4379-aab2-72b3be785135"), 56, "Jonathan Rhys Meyers" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b28fbe80-ebed-4ee7-84ab-c6ba768f0572"), 55, " Kazuyoshi Minamimagoe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ceb8da1b-25a5-4aac-9f0d-780652017723"), 55, " Akiko Takeshita" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6e8f07ff-2eff-4735-9519-e45421165d5d"), 55, " Bill Murray" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("02f350cd-5805-4d27-846e-7852e92c9259"), 42, " Zach Galifianakis" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3178683f-cb87-4e9e-8ed3-b70f9ce5a8da"), 42, " Justin Bartha" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d9fdc342-1747-4c6d-b090-af1eb4d6a397"), 43, "Toni Servillo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("61140608-2425-4863-84a8-b18179c117c9"), 43, " Carlo Verdone" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("afd13e4b-56cd-4976-8842-d63683b318b0"), 43, " Sabrina Ferilli" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("67a8751b-27fc-4c97-8c6b-c8ba98d34211"), 43, " Carlo Buccirosso" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("55605a62-b49e-46b7-9d98-a102a8c78a88"), 42, " Ed Helms" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ecaff6df-7960-4a00-bf04-44e63565aecd"), 44, "Clint Eastwood" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9e5af20d-cf04-4e47-bce1-24781d0a636b"), 44, " Bee Vang" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("18e58137-f46d-4c5b-a641-8ddcd63b1af0"), 44, " Ahney Her" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("895372a8-1e3a-4b8f-8b33-123c6b027f09"), 45, "Toni Collette" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c45e05fe-633a-4e69-ac8c-8d1b086d5f18"), 45, " Philip Seymour Hoffman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("276c8999-09ac-4974-87f3-2fd443e6d576"), 45, " Barry Humphries" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2d6589ae-975f-4eee-be51-9f5f319d07a3"), 45, " Eric Bana" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("956e078f-1a65-4aad-8873-44ab35fb9901"), 44, " Christopher Carley" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("269e2405-038f-4297-9d9f-a8f9dd3d95ee"), 42, "Bradley Cooper" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("66d7f8c4-b1e8-4eb8-8311-ac954f085965"), 41, " Robin Wright" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("642d21d5-a34f-4263-b81f-d2a0780fde3c"), 41, " Philip Seymour Hoffman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("04d94400-91f2-45c4-9e30-65c76023c582"), 37, " Scatman Crothers" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0381666c-ed2c-4f83-9735-7c8a65d5e436"), 38, "Owen Wilson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1039cabd-2502-45d0-9da2-a3163012dbec"), 38, " Rachel McAdams" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("2215ffca-bc8f-4a13-a867-93b42cc4f0c5"), 38, " Kurt Fuller" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ad58aa91-9578-488c-a215-e45eff613141"), 38, " Mimi Kennedy" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6009b917-af5e-400f-b2d4-8f0c54435a17"), 39, "Hugh Jackman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e3950e14-2792-41d3-976e-8aff284adf9e"), 39, " Russell Crowe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6bb46545-366f-452b-92ed-dad81a70a694"), 39, " Anne Hathaway" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("ff425073-f5ca-4f4a-8ae4-4239caf63b20"), 39, " Amanda Seyfried" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3bd26b6b-df88-4ca6-811e-828c71bf54e6"), 40, "Kevin Spacey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68388b1a-72b0-479b-9cfe-8c64599aeb39"), 40, " Russell Crowe" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7081452d-0f06-463a-af24-ac347b731b2d"), 40, " Guy Pearce" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("048ace31-fb19-4465-9a3e-06bceec9852c"), 40, " James Cromwell" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("a4def391-6f42-4d9d-b1f4-0ef0768f4d44"), 41, "Brad Pitt" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("897a7415-1af3-420f-9555-7bc36e39bcff"), 41, " Jonah Hill" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("6bab4e41-5f8a-4de5-bfa2-51cd750892cd"), 46, "Nadine Velazquez" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("4e518d1a-574a-421f-9141-3e773cec0f2f"), 146, " Casey Groves" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("299b5cd1-5bb0-4b36-9e95-fea4b601e5d7"), 46, " Denzel Washington" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("5e5aa98a-5d12-4225-b235-f3b798d7376a"), 46, " Adam C. Edwards" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8d23644a-335e-4ef0-9e77-02cf4d3a33a3"), 51, " Michael Conner Humphreys" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("66063a3f-788f-4567-8188-442efc506a97"), 52, "Ian McKellen" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1d3b6090-4cd0-4852-83b5-e7fcb0a8088c"), 52, " Martin Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("c579a701-07b2-4049-a0ef-d73acdafdd7e"), 52, " Richard Armitage" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("60be4285-35f4-4643-89a3-2de964ece15e"), 52, " Ken Stott" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("95a358b3-c301-4c17-a176-788402c50d37"), 53, "Rebecca Hall" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("7579dbb4-8bff-4727-8fd7-4ef5bbd8f1f0"), 51, " Sally Field" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("68d8f2df-b464-42a3-857f-3f837d40b9ba"), 53, " Scarlett Johansson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f82ff2ee-53fd-4fe1-b3e1-f741616672a0"), 53, " Chris Messina" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("26ecaf98-9551-42a2-940e-badec6d6e7fa"), 54, "Dev Patel" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("3916cbc6-b03b-4456-8c4b-890196dbd060"), 54, " Saurabh Shukla" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("60eef432-1282-4674-b939-08bc4b35f77a"), 54, " Anil Kapoor" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f47c8dd1-5613-478f-89a7-d8982775a488"), 54, " Rajendranath Zutshi" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("28aa1602-af7b-4e3c-9e37-919f36d212f0"), 55, "Scarlett Johansson" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0b326895-a01f-4cdb-b8e1-32a3b4ab1c47"), 53, " Christopher Evan Welch" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("e16c728d-26f2-41ef-99ee-4f27abf01308"), 51, " Rebecca Williams" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0ea9139b-a2ce-451f-92d5-ee3f0a7650e2"), 51, "Tom Hanks" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9bb1c44a-2072-4c4f-94d9-dc26b063ae94"), 50, " James Cromwell" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("d47ed8f2-b8f4-414e-9123-fb06c49c1003"), 47, "Michael Berryman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("435aa185-9336-43fa-ab49-9244dda8e1e9"), 47, " Peter Brocco" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("0a6fec7a-04e3-449e-8112-e47326ec59b6"), 47, " Dean R. Brooks" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("42f075a1-aaa4-46e0-86e4-8590a077e7fa"), 47, " Alonzo Brown" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("b6984f9e-a8ec-421b-8a6f-f140e3767fd4"), 48, "Ellen Burstyn" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("60cf40b0-4766-4132-9f64-8542e3599508"), 48, " Jared Leto" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("42b2e508-7da9-4573-9c4a-fa3501d84b23"), 48, " Jennifer Connelly" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("bea608ea-f7cf-447d-bfd9-d834a00aa72d"), 48, " Marlon Wayans" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("46d1d31b-1746-4ded-83a2-5117631234c3"), 49, "Jim Carrey" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("9483958f-2451-49ac-abbe-365b40a6ee67"), 49, " Laura Linney" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("f4dfa2e7-f1ef-475f-8795-a47b5fd2f123"), 49, " Noah Emmerich" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("cb7781d7-8847-4ac7-9c53-a82aa19f3152"), 49, " Natascha McElhone" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("dee4fc1b-8fb9-45e3-b19b-7774be956ec4"), 50, "Jean Dujardin" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("98c61be7-70e3-409a-9913-92e90d158eae"), 50, " Bérénice Bejo" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("841ccde0-8205-4f07-af37-f39a893ced14"), 50, " John Goodman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("8baad5bc-0e08-44bb-969b-bce0804d933e"), 46, " Carter Cabassa" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("1bc38618-3d37-4b02-93d2-fee85d5051ee"), 146, " Charlie Talbert" });

            migrationBuilder.CreateIndex(
                name: "IX_Casts_MovieId",
                table: "Casts",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieId",
                table: "Genres",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
