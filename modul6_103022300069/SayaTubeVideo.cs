using System;

namespace modul6_103022300069
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public int getPlaycount()
        {
            return playCount;
        }

        public String getTitle()
        {
            return title;
        }
        
        public void PrintVideoDetails()
        {
            Console.WriteLine("Judul: " + this.title);
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
