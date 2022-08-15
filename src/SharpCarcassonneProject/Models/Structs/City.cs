using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCarcassonneProject.Models.Structs
{
    internal class City
    {
        public int PlainTilesCount { get; set; }
        public int ArmedTilesCount { get; set; }
        public bool IsCompleted { get; set; }
        public int Points { get; set; }
    }
}
