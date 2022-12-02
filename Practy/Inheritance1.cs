using System;
using System.Collections.Generic;
using System.Text;

namespace Practy
{
    class Inheritance1
    {

        private string actor;
        private string favSong;

        public string Actor {
            get { return this.actor; }

            set { actor = value; }
        }


        public string FavSong
        {
            get { return this.favSong; }

            set { favSong = value; }
        }

        public Inheritance1(string actor)
        {
            this.actor = actor;
        }

        public Inheritance1() { }

        
        public void setFavSong(string favSong)
        {
            this.favSong = favSong;
        }

        public virtual void  Display()
        {
            Console.WriteLine($"{actor} Loves the song {favSong}");
        }

    }
}
