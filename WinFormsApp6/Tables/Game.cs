using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Studio? Studio { get; set; }
        public string? Style { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Gamemode { get; set; }
        public int Sells { get; set; }
    }
}
