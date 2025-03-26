using System;

namespace modul6_103022300069
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
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
                totalVideoPlayCount += uploadedVideos[i].getPlaycount();
            }

            return totalVideoPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Review film  " + (i+1) + " judul: " + uploadedVideos[i].getTitle() + " oleh M. Hafizh Al Kautsar");
            }
            Console.WriteLine("Total play count adalah : " + GetTotalVideoPlayCount());
        }
    }
}
