using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRover.Implementations.Helpers
{
    public enum Orientations
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
