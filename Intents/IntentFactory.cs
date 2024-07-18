using System;
using System.Collections.Generic;
using System.Text;

namespace Intents
{
    public class IntentFactory
    {
        public static Intent Derive(string? requested)
        {
            if (requested.ToLower() == "n" || requested.ToLower() == "north")
            {
                return Intent.North;
            }
            if (requested.ToLower() == "w" || requested.ToLower() == "west")
            {
                return Intent.West;
            }
            if (requested.ToLower() == "e" || requested.ToLower() == "east")
            {
                return Intent.East;
            }
            if (requested.ToLower() == "s" || requested.ToLower() == "south")
            {
                return Intent.South;
            }
            if (Enum.TryParse(typeof(Intent), requested, out var result) && Enum.IsDefined(typeof(Intent), result))
            {
                return (Intent)result;
            }
            else
            {
                return Intent.Unknown;
            }
        }
    }

}
