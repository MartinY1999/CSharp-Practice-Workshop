using System;

namespace OnlineRadioDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Playlist playlist = new Playlist();
            for (int i = 1; i <= N; i++)
            {
                try
                {
                    Song currentSong = Song.CreateSong();
                    playlist.AddSongs(currentSong);
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                    continue;
                }
            }
            playlist.PrintAddedSongs();
            playlist.ReturnTimeResult();
            Console.ReadLine();
        }
    }
}
