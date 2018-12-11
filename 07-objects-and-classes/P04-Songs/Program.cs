using System;
using System.Collections.Generic;

namespace P04_Songs
{
    public class Songs
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            int songsNumber = int.Parse(Console.ReadLine());
            var songs = new List<Songs>();

            for (int i = 0; i < songsNumber; i++)
            {
                var input = Console.ReadLine().Split("_");
                string type = input[0];
                string name = input[1];
                string time = input[2];

                Songs song = new Songs();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                foreach (Songs song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
