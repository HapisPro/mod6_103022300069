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

        // Test berhasil
        for (int i = 0; i < film.Length; i++)
        {
            Random rand = new Random();
            int playCount = rand.Next(0, 25000000);
            film[i].IncreasePlayCount(playCount);
            user.AddVideo(film[i]);
        }
        user.PrintAllVideoPlaycount();

        // Test prekondisi gagal judul
        SayaTubeVideo gagalVideo = new SayaTubeVideo(null);

        // Test prekondisi penambahan max playcount
        film[2].IncreasePlayCount(26000000);

        // Test prekondisi penambahan video null
        user.AddVideo(null);

        // Test prekondisi username kosong
        SayaTubeUser gagalUser = new SayaTubeUser(null);

        // Test overflow batas integer pada play count
        for (int i = 0; i < 86; i++)
        {
            film[5].IncreasePlayCount(25000000);
        }
    }
}