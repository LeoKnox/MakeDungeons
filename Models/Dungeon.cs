using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonMaker.Models
{
    public class Dungeon
    {
        public int ID { get; set; }
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Wall { get; set; }
    }
}
