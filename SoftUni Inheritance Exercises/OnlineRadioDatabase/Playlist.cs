using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OnlineRadioDatabase
{
    public class Playlist
    {
        private List<Song> Songs { get; set; } = new List<Song>();
        public void AddSongs(Song current)
        {
            this.Songs.Add(current);
            Console.WriteLine("Song added.");
        }
        public void ReturnTimeResult()
        {
            int totalSeconds = 0;
            Songs.ForEach(x => totalSeconds += x.Longevity);
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
        public void PrintAddedSongs()
        {
            Console.WriteLine($"Songs added: {this.Songs.Count}");
        }
    }
}
