namespace SpotifyP21;

using SpotifyP21.Data;
using SpotifyP21.Entities;

public static class DataSeeder
{
    public static void SeedData(SpotifyContext context)
    {
        if (!context.Genres.Any())
        {
            var genres = new List<Genre>
            {
                new Genre { Title = "Rock" },
                new Genre { Title = "Pop" },
                new Genre { Title = "Jazz" },
                new Genre { Title = "Hip-Hop" },
                new Genre { Title = "Electronic" },
                new Genre { Title = "Classical" },
                new Genre { Title = "Country" },
                new Genre { Title = "Blues" },
                new Genre { Title = "Reggae" },
                new Genre { Title = "Folk" }
            };
            context.Genres.AddRange(genres);
            context.SaveChanges();
        }

        if (!context.Groups.Any())
        {
            var groups = new List<Group>
            {
                new Group { Title = "The Beatles" },
                new Group { Title = "Queen" },
                new Group { Title = "Miles Davis" },
                new Group { Title = "Nirvana" },
                new Group { Title = "Michael Jackson" },
                new Group { Title = "Daft Punk" },
                new Group { Title = "Beethoven" },
                new Group { Title = "Johnny Cash" },
                new Group { Title = "B.B. King" },
                new Group { Title = "Bob Marley" }
            };
            context.Groups.AddRange(groups);
            context.SaveChanges();
        }

        if (!context.Albums.Any())
        {
            var albums = new List<Album>
            {
                new Album
                {
                    Title = "Abbey Road",
                    Photo = "abbey_road.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "The Beatles").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Come Together" },
                        new Song { Title = "Something" },
                        new Song { Title = "Maxwell's Silver Hammer" },
                        new Song { Title = "Oh! Darling" },
                        new Song { Title = "Octopus's Garden" },
                        new Song { Title = "I Want You (She's So Heavy)" },
                        new Song { Title = "Here Comes the Sun" },
                        new Song { Title = "Because" },
                        new Song { Title = "You Never Give Me Your Money" },
                        new Song { Title = "Sun King" },
                        new Song { Title = "Mean Mr. Mustard" },
                        new Song { Title = "Polythene Pam" },
                        new Song { Title = "She Came In Through the Bathroom Window" },
                        new Song { Title = "Golden Slumbers" },
                        new Song { Title = "Carry That Weight" },
                        new Song { Title = "The End" },
                        new Song { Title = "Her Majesty" }
                    }
                },
                new Album
                {
                    Title = "A Night at the Opera",
                    Photo = "night_at_the_opera.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Queen").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Death on Two Legs (Dedicated to...)" },
                        new Song { Title = "Lazing on a Sunday Afternoon" },
                        new Song { Title = "I'm in Love with My Car" },
                        new Song { Title = "You're My Best Friend" },
                        new Song { Title = "39" },
                        new Song { Title = "Sweet Lady" },
                        new Song { Title = "Seaside Rendezvous" },
                        new Song { Title = "The Prophet's Song" },
                        new Song { Title = "Love of My Life" },
                        new Song { Title = "Good Company" },
                        new Song { Title = "Bohemian Rhapsody" },
                        new Song { Title = "God Save the Queen" }
                    }
                },
                new Album
                {
                    Title = "Kind of Blue",
                    Photo = "kind_of_blue.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Jazz").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Miles Davis").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "So What" },
                        new Song { Title = "Freddie Freeloader" },
                        new Song { Title = "Blue in Green" },
                        new Song { Title = "All Blues" },
                        new Song { Title = "Flamenco Sketches" }
                    }
                },
                new Album
                {
                    Title = "Nevermind",
                    Photo = "nevermind.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Nirvana").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Smells Like Teen Spirit" },
                        new Song { Title = "In Bloom" },
                        new Song { Title = "Come as You Are" },
                        new Song { Title = "Breed" },
                        new Song { Title = "Lithium" },
                        new Song { Title = "Polly" },
                        new Song { Title = "Territorial Pissings" },
                        new Song { Title = "Drain You" },
                        new Song { Title = "Lounge Act" },
                        new Song { Title = "Stay Away" },
                        new Song { Title = "On a Plain" },
                        new Song { Title = "Something in the Way" }
                    }
                },
                new Album
                {
                    Title = "Thriller",
                    Photo = "thriller.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Pop").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Michael Jackson").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Wanna Be Startin' Somethin'" },
                        new Song { Title = "Baby Be Mine" },
                        new Song { Title = "The Girl Is Mine" },
                        new Song { Title = "Thriller" },
                        new Song { Title = "Beat It" },
                        new Song { Title = "Billie Jean" },
                        new Song { Title = "Human Nature" },
                        new Song { Title = "P.Y.T. (Pretty Young Thing)" },
                        new Song { Title = "The Lady in My Life" }
                    }
                },
                new Album
                {
                    Title = "Discovery",
                    Photo = "discovery.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Electronic").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Daft Punk").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "One More Time" },
                        new Song { Title = "Aerodynamic" },
                        new Song { Title = "Digital Love" },
                        new Song { Title = "Harder, Better, Faster, Stronger" },
                        new Song { Title = "Crescendolls" },
                        new Song { Title = "Nightvision" },
                        new Song { Title = "Superheroes" },
                        new Song { Title = "High Life" },
                        new Song { Title = "Something About Us" },
                        new Song { Title = "Voyager" },
                        new Song { Title = "Veridis Quo" },
                        new Song { Title = "Short Circuit" },
                        new Song { Title = "Face to Face" },
                        new Song { Title = "Too Long" }
                    }
                },
                new Album
                {
                    Title = "Symphony No. 9",
                    Photo = "symphony_no_9.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Classical").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Beethoven").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Allegro ma non troppo, un poco maestoso" },
                        new Song { Title = "Molto vivace" },
                        new Song { Title = "Adagio molto e cantabile" },
                        new Song { Title = "Presto" }
                    }
                },
                new Album
                {
                    Title = "At Folsom Prison",
                    Photo = "at_folsom_prison.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Country").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Johnny Cash").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Folsom Prison Blues" },
                        new Song { Title = "Dark as a Dungeon" },
                        new Song { Title = "I Still Miss Someone" },
                        new Song { Title = "Cocaine Blues" },
                        new Song { Title = "25 Minutes to Go" },
                        new Song { Title = "Orange Blossom Special" },
                        new Song { Title = "The Long Black Veil" },
                        new Song { Title = "Send a Picture of Mother" },
                        new Song { Title = "The Wall" },
                        new Song { Title = "Dirty Old Egg-Sucking Dog" },
                        new Song { Title = "Flushed from the Bathroom of Your Heart" },
                        new Song { Title = "Jackson" },
                        new Song { Title = "Give My Love to Rose" },
                        new Song { Title = "I Got Stripes" },
                        new Song { Title = "The Legend of John Henry's Hammer" },
                        new Song { Title = "Green, Green Grass of Home" },
                        new Song { Title = "Greystone Chapel" }
                    }
                },
                new Album
                {
                    Title = "Live at the Regal",
                    Photo = "live_at_the_regal.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Blues").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "B.B. King").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Every Day I Have the Blues" },
                        new Song { Title = "Sweet Sixteen" },
                        new Song { Title = "How Blue Can You Get?" },
                        new Song { Title = "Please Love Me" },
                        new Song { Title = "You Upset Me Baby" },
                        new Song { Title = "Worry, Worry" },
                        new Song { Title = "Woke Up This Morning" },
                        new Song { Title = "You Done Lost Your Good Thing Now" },
                        new Song { Title = "Help the Poor" }
                    }
                },
                new Album
                {
                    Title = "Exodus",
                    Photo = "exodus.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Reggae").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Bob Marley").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Natural Mystic" },
                        new Song { Title = "So Much Things to Say" },
                        new Song { Title = "Guiltiness" },
                        new Song { Title = "The Heathen" },
                        new Song { Title = "Exodus" },
                        new Song { Title = "Jamming" },
                        new Song { Title = "Waiting in Vain" },
                        new Song { Title = "Turn Your Lights Down Low" },
                        new Song { Title = "Three Little Birds" },
                        new Song { Title = "One Love/People Get Ready" }
                    }
                }
            };
            context.Albums.AddRange(albums);
            context.SaveChanges();
        }
    }
}
