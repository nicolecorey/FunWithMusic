using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Alternative,
            Classic,
            Punk,
            Metal,
            Indie
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private decimal Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, decimal length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(decimal length)
            {
                Length = length;
            }
           
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the track?");
            decimal tempLength = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("A - alternative\nM = metal\nC - classic\nP - Punk \nI - Indie");
            Genre tempGenre = Genre.Alternative;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'C':
                    tempGenre = Genre.Classic;
                    break;
                case 'P':
                    tempGenre = Genre.Punk;
                    break;
                case 'I':
                    tempGenre = Genre.Indie;
                    break;
            }


            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

            Music newMusic = music;
            newMusic.setTitle ("Rocket");
            newMusic.setLength (Convert.ToDecimal("6.37"));

            Console.WriteLine("Here's the details of your favorite song:");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here's the next song on that album:");
            Console.WriteLine($"{newMusic.Display()}");
        }

        
    }
}
