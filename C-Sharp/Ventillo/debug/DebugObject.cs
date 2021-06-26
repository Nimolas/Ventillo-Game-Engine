using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventillo.GameObjects;
using Ventillo.Utils;

namespace Ventillo.Debug
{
    class DebugObject
    {
        private int LastTime = 0;
        private int FPS = 0;

        DebugObject(Vector position, MinMax playableArea)
        {
            double xMidPosition = playableArea.Min.x + ((playableArea.Max.x - playableArea.Min.x) / 2);
            double yMidPosition = playableArea.Min.y + ((playableArea.Max.y - playableArea.Min.y) / 2);
        }
    }
}