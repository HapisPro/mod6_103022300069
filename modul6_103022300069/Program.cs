using modul6_103022300069;
using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Hapis");
        SayaTubeVideo[] film = { new SayaTubeVideo("Interstellar"), new SayaTubeVideo("Avenger"),
        new SayaTubeVideo("Spidermen"), new SayaTubeVideo("Batman"), new SayaTubeVideo("Iron man"),
        new SayaTubeVideo("Thor"), new SayaTubeVideo("Loki"), new SayaTubeVideo("Supermen"),
        new SayaTubeVideo("Joker") };

        for (int i = 0; i < film.Length; i++)
        {
            Random rand = new Random();
            int playCount = rand.Next(0, 25000000);
            film[i].IncreasePlayCount(playCount);
            user.AddVideo(film[i]);
        }

        user.PrintAllVideoPlaycount();
    }
}