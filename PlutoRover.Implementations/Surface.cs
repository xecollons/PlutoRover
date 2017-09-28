using PlutoRover.Implementations.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRover.Implementations
{
    public static class Surface
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static List<Coordinates> ObstaclesList { get; set; }
    }
}
