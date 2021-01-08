﻿using System;
using System.Collections.Generic;
using System.Linq;
using Songs;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>(n);

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            // with WHERE
            //List<Song> filtered = songs.Where(s => s.TypeList == typeList).ToList();

            //foreach (Song song in filtered)
            //{
            //    Console.WriteLine(song.Name);
            //}
        }
    }
}
