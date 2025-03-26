using System;
using System.Diagnostics;

namespace modul6_103022300069
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            // Precondition
            Debug.Assert(username != null, "Precondition: Username tidak boleh kosong");
            Debug.Assert(username.Length <= 100, "Precondition: Panjang username maksimal 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                try
                {
                    checked
                    {
                        totalVideoPlayCount += uploadedVideos[i].getPlaycount();
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nError: total play count melebihi batas integer");
                }
            }

            return totalVideoPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            // Precondition
            Debug.Assert(video != null, "Precondition: Video yang ditambahkan tidak boleh kosong");
            Debug.Assert(video.getPlaycount() <= int.MaxValue, "Precondition: Video yang ditambahkan punya playCount yang melebihi batas bilangan integer maksimum");

            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            // Postcondition
            Console.WriteLine("User: " + username);
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("Review film  " + (i+1) + " judul: " + uploadedVideos[i].getTitle() + " oleh M. Hafizh Al Kautsar");
            }
            Console.WriteLine("Total play count adalah : " + GetTotalVideoPlayCount());
        }
    }
}
