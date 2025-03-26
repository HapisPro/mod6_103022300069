using System;
using System.Diagnostics;

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

            // Precondition
            Debug.Assert(title != null, "Precondition: Title tidak boleh kosong");
            Debug.Assert(title.Length <= 200, "Precondition: Panjang title maksimal 200 karakter");
         
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            // Precondition
            Debug.Assert(count > 0 && count <= 25000000, "Precondition: Play count harus antara 1-25.000.000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nException: Play count melebihi batas integer");
            }
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
