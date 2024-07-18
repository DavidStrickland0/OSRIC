using Base;
using OSRIC.DotNetCore.Characters.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Intents
{
    public class IntentManager
    {
        public static string ProcessEvent(World world, Character character, Intent intent)
        {
            character.Experience++;
            switch (intent)
            {
                case Intent.GoForward:
                case Intent.GoBack:
                case Intent.GoLeft:
                case Intent.GoRight:
                case Intent.LeftTurn:
                case Intent.RightTurn:
                    PositionManager.HandleMovement(world, character, intent);
                    return world.TerrainMap[character.Location.X][character.Location.Y].Description;
                case Intent.Compass:
                    return character.Orientation.ToString();
                case Intent.Locate:
                    return $"X:{character.Location.X}, Y:{character.Location.Y}";
                case Intent.Look:
                    return world.TerrainMap[character.Location.X][character.Location.Y].Description;
                case Intent.Unknown:
                default:
                    return "I cant do that";
            }
        }
     }
}
