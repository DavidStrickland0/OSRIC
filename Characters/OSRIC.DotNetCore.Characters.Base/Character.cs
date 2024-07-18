using System;
using System.Drawing;

namespace OSRIC.DotNetCore.Characters.Base
{
    public class Character
    {
        public Point Location { get; set; }
        public int Orientation { get; set; }
        public int Experience { get; set; }
    }
}
