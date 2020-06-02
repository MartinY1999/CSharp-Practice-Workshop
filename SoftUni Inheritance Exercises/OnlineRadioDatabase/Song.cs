using System;
using System.Linq;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string name;
        private int longevity;
        public string Artist
        {
            get => artist;
            private set
            {
                if (value.Length < 3 || value.Length > 20 || string.IsNullOrWhiteSpace(value))
                    throw new InvalidArtistNameException();
                artist = value;
            }
        }
        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 3 || value.Length > 30 || string.IsNullOrWhiteSpace(value))
                    throw new InvalidSongNameException();
                name = value;
            }
        }
        public int Longevity
        {
            get => longevity;
            private set
            {
                if (value < 0 || value > 899)
                    throw new InvalidSongLengthException();
                longevity = value;
            }
        }
        public Song(string artist, string name, int longevity)
        {
            Artist = artist;
            Name = name;
            Longevity = longevity;
        }

        public static Song CreateSong()
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            if (input.Length < 3 || input.Any(x => string.IsNullOrWhiteSpace(x) == true))
                throw new InvalidSongException();
            string artist = input[0];
            string name = input[1];
            int longevity = Song.GetTimeLength(input[2]);
            return new Song(artist, name, longevity);
        }

        private static int GetTimeLength(string element)
        {
            string[] parts = element.Split(':');
            int minutes = int.Parse(parts[0]);
            int seconds = int.Parse(parts[1]);
            return Song.TotalTime(minutes, seconds);
        }
        private static int TotalTime(int minutes, int seconds)
        {
            if (minutes < 0 || minutes > 14)
                throw new InvalidSongMinutesException();
            else if (seconds < 0 || seconds > 59)
                throw new InvalidSongSecondsException();
            else
                return minutes * 60 + seconds;
        }
    }
}
