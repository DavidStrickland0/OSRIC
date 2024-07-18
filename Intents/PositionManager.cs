using Base;
using OSRIC.DotNetCore.Characters.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Intents
{
    public class PositionManager
    {
        public static void HandleMovement(World world, Character character, Intent intent)
        {

            const double DegreesToRadians = Math.PI / 180.0;
            int orientation = character.Orientation;
            switch (intent)
            {
                case Intent.North:
                    orientation = 0;
                    break;
                case Intent.South:
                    orientation = 180;
                    break;
                case Intent.West:
                    orientation = 270;
                    break;
                case Intent.East:
                    orientation = 90;
                    break;
                default:
                    orientation = character.Orientation % 360;
                    break;
            }

            if (orientation < 0)
                orientation += 360;

            int maxX = world.TerrainMap.Length - 1; // Get the width of the world map
            int maxY = world.TerrainMap[0].Length - 1; // Get the height of the world map

            int newX = character.Location.X;
            int newY = character.Location.Y;

            switch (intent)
            {
                case Intent.North:
                case Intent.South:
                case Intent.West:
                case Intent.East:
                case Intent.GoForward:
                    newX += (int)(Math.Sin(orientation * DegreesToRadians));
                    newY -= (int)(Math.Cos(orientation * DegreesToRadians));
                    break;

                case Intent.GoBack:
                    newX -= (int)(Math.Sin(orientation * DegreesToRadians));
                    newY += (int)(Math.Cos(orientation * DegreesToRadians));
                    break;

                case Intent.GoLeft:
                    newX -= (int)(Math.Cos(orientation * DegreesToRadians));
                    newY -= (int)(Math.Sin(orientation * DegreesToRadians));
                    break;

                case Intent.GoRight:
                    newX += (int)(Math.Cos(orientation * DegreesToRadians));
                    newY += (int)(Math.Sin(orientation * DegreesToRadians));
                    break;

                case Intent.LeftTurn:
                    character.Orientation = (character.Orientation - 90) % 360;
                    if (character.Orientation < 0)
                        character.Orientation += 360;
                    break;

                case Intent.RightTurn:
                    character.Orientation = (character.Orientation + 90) % 360;
                    break;
            }

            // Wrap around logic
            if (newX < 0)
                newX = maxX;
            else if (newX > maxX)
                newX = 0;

            if (newY < 0)
                newY = maxY;
            else if (newY > maxY)
                newY = 0;

            character.Location = new Point(newX, newY);
        }

        public static Point DerivePostion(World world,Point currentLocation, Point movement)
        {
            currentLocation= new Point(currentLocation.X+movement.X, currentLocation.Y+movement.Y);
            if(currentLocation.X>world.TerrainMap.Length)
            {
                currentLocation.X = 0;
            }
            if (currentLocation.X <0)
            {
                currentLocation.X = world.TerrainMap.Length;
            }
            if (currentLocation.Y > world.TerrainMap[0].Length)
            {
                currentLocation.Y = 0;
            }
            if (currentLocation.Y < 0)
            {
                currentLocation.X = world.TerrainMap[0].Length;
            }
            return currentLocation;
        }
    }
}
