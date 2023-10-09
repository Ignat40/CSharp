using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace PlayList
{
    enum Genre
    {
        Rock,
        Jazz,
        Pop,
        Classical,
        HipHop,
        Counry,
        EDM
    }

    struct Songs
    {
        public string? Title;
        public string? Artist;
        public Genre SongGenre;
        public string? Duration; 
    }
    class Program
    {

        static readonly List<Songs> playList = new();
        public static void Main()
        {
            string? command; 

            while(true)
            {
                Console.WriteLine("Enter command -> {Add, Show, Remove, Exit}\n");
                command = Console.ReadLine()?.ToLower();

                //TRY & CATCH 
                //Whenever you feel like your
                //code might have a certain type of error.
                //you can use "try" to try the code you think might
                //have an error, the "catch" will be able to print the error. 

                try
                {
                    ProcesscCommand(command);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine($"An error occured: {ex.Message}");
                }
            }
        }
        static void ProcesscCommand(string? command)
        {
            if(command == "add")
            {
                AddSong();
            }
            else if(command == "show")
            {
                ShowPlaylist();
            }
            else if(command == "remove")
            {
                RemoveSong();
            }
            else if(command == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Unknown command. Try again: ");
            }
        }
        static void AddSong()
        {
            Songs newSong = new();
            Console.WriteLine("Enter song title: ");
            newSong.Title = Console.ReadLine();
            Console.WriteLine("Enter song artist: ");
            newSong.Artist = Console.ReadLine();
            Console.WriteLine("Enter song genre: ");
            Enum.TryParse(Console.ReadLine(), true, out Genre genre);
            newSong.SongGenre = genre;
            Console.WriteLine("Enter song duration: (HH:MM:SS)");
            string? duration = Console.ReadLine();

            if(duration != null)
            {
                string?[] parts = duration.Split(":");
                if(parts.Length == 3 && 
                int.TryParse(parts[0], out _) &&
                int.TryParse(parts[1], out _) &&
                int.TryParse(parts[2], out _)
                )
                {
                    newSong.Duration = duration;
                }
                else
                {
                    Console.WriteLine("Invalid duration format. Song not added.");
                }
            }

            playList.Add(newSong);

        }

        static void ShowPlaylist()
        {
            for (int i = 0; i < playList.Count; i++)
            {
                Songs song = playList[i];
                Console.WriteLine($"{i+1}. {song.Title} by {song.Artist} {song.SongGenre} - {song.Duration}");
            }
            Console.WriteLine($"Total duration of the song: {CalculateTotalDuration}");
        }
        static string CalculateTotalDuration()
        {
            int totalHours = 0;
            int tottalMins = 0;
            int totalSeconds = 0;

            foreach(var song in playList)
            {
                var timePats = song.Duration?.Split(":");
                if(timePats != null)
                {
                    totalHours += int.Parse(timePats[0]);
                    tottalMins += int.Parse(timePats[1]);
                    totalSeconds += int.Parse(timePats[1]);
                }

                totalHours += totalSeconds / 60;
                totalSeconds %= 60;
                totalHours += tottalMins / 60;
                tottalMins %= 60;

            }
            return $"{totalHours:D2}:{tottalMins:D2}:{totalSeconds:D2}";
        }

        static void RemoveSong()
        {
            ShowPlaylist();
            Console.WriteLine("Enter the number of the song you want to remove: ");
            if(int.TryParse(Console.ReadLine(), out int index) &&
                index >= 1 && index <= playList.Count
            )
            {
                playList.RemoveAt(index -1);
                Console.WriteLine("Song removed.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}