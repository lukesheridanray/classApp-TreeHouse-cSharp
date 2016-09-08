﻿using System;
namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new System.OutOfBoundException(x + "," + y + " is outside the boundaries");
            }
        }
    }
}