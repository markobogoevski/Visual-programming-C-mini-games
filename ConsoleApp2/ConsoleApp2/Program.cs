using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Song
    {
        public string Name { get; set; }
        public int TimeDuration { get; set; }
        public double Rating { get; set; }

        public Song(string name, int timeDuration, double rating)
        {
            Name = name;
            TimeDuration = timeDuration;
            Rating = rating;
        }

        public override bool Equals(object obj)
        {
            var song = obj as Song;
            return song != null &&
                   Name == song.Name &&
                   TimeDuration == song.TimeDuration &&
                   Rating == song.Rating;
        }

        public override int GetHashCode()
        {
            var hashCode = -281573630;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + TimeDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + Rating.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Song name: {0} , song lenght: {1} , song rating : {2}", Name, TimeDuration, Rating);
        }
    }

    class SongNotFoundException:Exception
    {
        public String message { get; set; }
        public SongNotFoundException(String message) : base(message) { this.message = message; }
        public string getMessage() { return message; }
    }

    class Album
    {
        public List<Song> songList { get; set; }
        public string Name { get; set; }
        public int yearOfPublishment { get; set; }

        public Album(string name, int yearOfPublishment)
        {
            songList = new List<Song>();
            Name = name;
            this.yearOfPublishment = yearOfPublishment;
        }

        public void addSong(string name,int duration,float rating)
        {
            Song song = new Song(name, duration, rating);
            songList.Add(song);
        }
        public void addSong(Song song)
        {
            songList.Add(song);
        }

        public void deleteSong(Song song)
        {
            songList.Remove(song);
        }

        public Song findSong(String songName)
        {
            Song song = null;
            foreach (Song song1 in songList)
                if (song1.Name.Equals(songName,StringComparison.Ordinal))
                    song = song1;

            if (song == null)
                throw new SongNotFoundException("Not found "+songName);

            return song;
        }

        public override bool Equals(object obj)
        {
            var album = obj as Album;
            return album != null &&
                   EqualityComparer<List<Song>>.Default.Equals(songList, album.songList) &&
                   Name == album.Name &&
                   yearOfPublishment == album.yearOfPublishment;
        }

        public override int GetHashCode()
        {
            var hashCode = -1115104410;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Song>>.Default.GetHashCode(songList);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + yearOfPublishment.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format("Album name: {0} , album year: {1} ", Name, yearOfPublishment) + "\n");
            stringBuilder.Append("Songs: \n");
            foreach (Song song in songList)
                stringBuilder.Append(song);

            return stringBuilder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
