﻿namespace BattleShipBrain
{
    public struct Coordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"X: {X}, Y: {Y}";
    }
}