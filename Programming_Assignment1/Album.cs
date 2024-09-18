using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment1
{
    class Album
    {



        private string albumName;
        private string artistName;
        private int numOfTracks;
        



        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome To Your Album Collection");
            Console.WriteLine();

            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            DisplayAlbumInfo();

            
        }

        

        private void ReadAlbumName()
        {
            Console.WriteLine();
            Console.WriteLine("What's the Album Name?");
            albumName = Console.ReadLine();
            Console.WriteLine();

        }

        private void ReadArtistName()
        {
            Console.WriteLine();
            Console.WriteLine("What's the Artist Name?");
            artistName = Console.ReadLine();
            Console.WriteLine();
        }

        private void ReadTracks()
        {
            Console.WriteLine();
            Console.WriteLine("Number Of Tracks On The Album?");
            string numOfTracksValue = Console.ReadLine();
            numOfTracks = int.Parse(numOfTracksValue);
            Console.WriteLine();
        }



        private void DisplayAlbumInfo()
        {
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            Console.WriteLine("Album Info:");
       
            Console.WriteLine();
            Console.WriteLine($"Artist Name: {artistName}");
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Number of Tracks On The Album: {numOfTracks}");
            Console.WriteLine();

            Console.WriteLine("Thank You For Using Our Service!");




            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

        }

    }
}
