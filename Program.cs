namespace Module4_db
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                Program program = new Program();
                program.AddInstance(context);

            }
        }

        public void AddInstance(ApplicationContext context)
        {
            //songs

            var song1 = new Song()
            {
                Title = "my first song",
                ReleasedDate = DateTime.Parse("08-09-2002 00:00:00"),
                Duration = "2.34",
                GenreId = 1,
                ArtistId = 2
            };
            var song2 = new Song()
            {
                Title = "Panda",
                ReleasedDate = DateTime.Parse("10-10-2004 00:00:00"),
                Duration = "1.44",
                GenreId = 2,
                ArtistId = 3
            };
            var song3 = new Song()
            {
                Title = "dog",
                ReleasedDate = DateTime.Parse("18-01-2012 00:00:00"),
                Duration = "3.55",
                GenreId = 1,
                ArtistId = 2
            };
            var song4 = new Song()
            {
                Title = "dog",
                ReleasedDate = DateTime.Parse("18-01-2012 00:00:00"),
                Duration = "3.55",
                GenreId = 3,
                ArtistId = 1
            };

            //artists

            var artist1 = new Artist()
            {
                Name = "max",
                DateOfBirth = DateTime.Parse("18-01-2002 00:00:00"),
                Phone = "+380444823631",
                Email = "fodpsfpods@gmai;l.con",
                SongId = 2,
            };
            var artist2 = new Artist()
            {
                Name = "Doon",
                DateOfBirth = DateTime.Parse("12-11-2012 00:00:00"),
                Phone = "+38044531",
                Email = "fodpsfpods@gmai;l.con",
                InstagramUrl = "dsd!@https//das",
                SongId = 1,
            };
            var artist3 = new Artist()
            {
                Name = "Kacl",
                DateOfBirth = DateTime.Parse("18-01-2004 00:00:00"),
                SongId = 2,
            };
            var artist4 = new Artist()
            {
                Name = "Kacl",
                DateOfBirth = DateTime.Parse("18-01-2004 00:00:00"),
                SongId = 3,
            };

            // genre

            var genre1 = new Genre()
            {
                Title = "pop"
            };
            var genre2 = new Genre()
            {
                Title = "harf rap"
            };
            var genre3 = new Genre()
            {
                Title = "rock"
            };

            // adder

            //context.Artists.Add(artist1);
            //context.Artists.Add(artist2);
            //context.Artists.Add(artist3);
            //context.Artists.Add(artist4);

            //context.SaveChanges();


            context.Genres.Add(genre3);
            context.Genres.Add(genre1);
            context.Genres.Add(genre2);

            context.SaveChanges();


            context.Songs.Add(song1);
            context.Songs.Add(song3);
            context.Songs.Add(song2);
            context.Songs.Add(song4);
            context.SaveChanges();


        }
    }
}