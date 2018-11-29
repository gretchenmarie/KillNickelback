using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string )> goodSongs = new List<(string, string)>();

            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
            {
            ("Nickelback", "How you remind me"),
            ("Nickelback", " Far away"),
            ("Janes Addiction", "Mountain Song"),
            ("Ministry", "Jesus built my hotrod"),
            ("white zombie", "Dragula"),
            ("nine inch nails", "closer"),
            ("primus", "my name is mud"),
            };
            /* foreach ((string artist, string song) in allSongs) ;
             {
                 allSongs.Add(song);
             }*/

            foreach (var song in allSongs) 
            {
                if (song.artist != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            // Display all unique model names
            foreach ((string songName, string artistName) song in goodSongs)
            {
                Console.WriteLine($"this is a good song, {song.songName}, by {song.artistName}!");
            }
        }
    }
}
