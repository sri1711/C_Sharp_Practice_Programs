using System;
using System.Collections.Generic;
using System.Text;

namespace Practy
{
    class Inheritance2 : Inheritance1
    {

        public void Display_Play_Song()
        {
            Console.WriteLine($"{base.Actor} plays { base.FavSong }");
        }

        public Inheritance2(string actor_name) : base(actor_name)
        {
        }

        public Inheritance2() { }

        public override void Display()
        {
            Console.WriteLine($"{base.Actor} Doesn't Loves the song {base.FavSong}");
        }




    }
}
