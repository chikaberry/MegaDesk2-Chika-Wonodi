using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_Chika_Wonodi
{

    public enum SurfaceMaterial
    {
        laminate,
        Oak,
        Pine,
        Rosewood,
        Veneer,
    }

    internal class Desk
    {

        public const short MAX_WIDTH = 96;
        public const short MIN_WIDTH = 24;
        public const short MAX_DEPTH = 48;
        public const short MIN_DEPTH = 12;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }

    }
}




    