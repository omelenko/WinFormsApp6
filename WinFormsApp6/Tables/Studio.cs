using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Studio
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Countries { get; set; }
        public List<string>? Filias { get; set; }

        public override string ToString()
        {
            return Name!;
        }
    }
}
