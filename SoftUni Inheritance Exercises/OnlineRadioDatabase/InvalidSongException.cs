using System;

namespace OnlineRadioDatabase
{
    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}
