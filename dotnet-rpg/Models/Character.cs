using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Frod";
        public int Hitbox { get; set; } = 100;
        public int attack { get; set; } = 10;
        public int damage { get; set; } = 10;
        public int intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.knight;

    }
}
