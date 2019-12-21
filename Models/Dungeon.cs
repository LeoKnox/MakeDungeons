using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonMaker.Models
{
    public class Dungeon
    {
        public int ID { get; set; }
        public string RoomName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Wall { get; set; }
    }
}
