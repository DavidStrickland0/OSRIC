using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    using System;
    using System.Drawing;

    public class TerrainInitializer
    {

        public static Terrain[][] InitializeTerrainMap(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            var terrainMap = new Terrain[width][];

            for (int x = 0; x < width; x++)
            {
                terrainMap[x] = new Terrain[height];
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    terrainMap[x][y] = GetTerrainFromColor(pixelColor);
                }
            }
            return terrainMap;
        }

        private static Terrain GetTerrainFromColor(Color color)
        {
            if (color == Color.FromArgb(0, 0, 0)) // Black
                return new Terrain { Type = "Void", Description = "An empty void" };
            else if (color == Color.FromArgb(255, 255, 255)) // White
                return new Terrain { Type = "Snow", Description = "A snowy area" };
            else if (color == Color.FromArgb(128, 128, 128)) // Gray
                return new Terrain { Type = "Rock", Description = "A rocky terrain" };
            else if (color == Color.FromArgb(192, 192, 192)) // Light Gray
                return new Terrain { Type = "Gravel", Description = "A gravel path" };
            else if (color == Color.FromArgb(255, 0, 0)) // Red
                return new Terrain { Type = "Volcano", Description = "A volcanic region" };
            else if (color == Color.FromArgb(0, 255, 0)) // Green
                return new Terrain { Type = "Grass", Description = "A grassy plain" };
            else if (color == Color.FromArgb(0, 128, 0)) // Dark Green
                return new Terrain { Type = "Forest", Description = "A dense forest" };
            else if (color == Color.FromArgb(0, 0, 255)) // Blue
                return new Terrain { Type = "Water", Description = "A body of water" };
            else if (color == Color.FromArgb(0, 0, 128)) // Dark Blue
                return new Terrain { Type = "DeepWater", Description = "Deep water" };
            else if (color == Color.FromArgb(255, 255, 0)) // Yellow
                return new Terrain { Type = "Sand", Description = "A sandy area" };
            else if (color == Color.FromArgb(139, 69, 19)) // SaddleBrown
                return new Terrain { Type = "Mountain", Description = "A mountainous region" };
            else if (color == Color.FromArgb(255, 165, 0)) // Orange
                return new Terrain { Type = "Desert", Description = "A desert region" };
            else if (color == Color.FromArgb(255, 192, 203)) // Pink
                return new Terrain { Type = "FlowerField", Description = "A field of flowers" };
            else if (color == Color.FromArgb(128, 0, 128)) // Purple
                return new Terrain { Type = "MysticForest", Description = "A mystical forest" };
            else if (color == Color.FromArgb(255, 20, 147)) // DeepPink
                return new Terrain { Type = "BlossomField", Description = "A field of blossoming flowers" };
            else if (color == Color.FromArgb(255, 105, 180)) // HotPink
                return new Terrain { Type = "RoseGarden", Description = "A rose garden" };
            else if (color == Color.FromArgb(255, 69, 0)) // OrangeRed
                return new Terrain { Type = "LavaField", Description = "A lava field" };
            else if (color == Color.FromArgb(128, 0, 0)) // Maroon
                return new Terrain { Type = "Wasteland", Description = "A barren wasteland" };
            else if (color == Color.FromArgb(255, 222, 173)) // NavajoWhite
                return new Terrain { Type = "Beach", Description = "A sandy beach" };
            else if (color == Color.FromArgb(255, 250, 250)) // FloralWhite
                return new Terrain { Type = "SaltFlat", Description = "A salt flat" };
            else if (color == Color.FromArgb(245, 245, 220)) // Beige
                return new Terrain { Type = "Plain", Description = "A flat plain" };
            else if (color == Color.FromArgb(220, 220, 220)) // Gainsboro
                return new Terrain { Type = "Urban", Description = "An urban area" };
            else if (color == Color.FromArgb(211, 211, 211)) // LightGray
                return new Terrain { Type = "Concrete", Description = "A concrete surface" };
            else if (color == Color.FromArgb(240, 255, 240)) // HoneyDew
                return new Terrain { Type = "Meadow", Description = "A grassy meadow" };
            else if (color == Color.FromArgb(240, 248, 255)) // AliceBlue
                return new Terrain { Type = "Ice", Description = "An icy area" };
            else if (color == Color.FromArgb(230, 230, 250)) // Lavender
                return new Terrain { Type = "LavenderField", Description = "A field of lavender" };
            else if (color == Color.FromArgb(255, 240, 245)) // LavenderBlush
                return new Terrain { Type = "SpringField", Description = "A field in spring bloom" };
            else if (color == Color.FromArgb(255, 228, 225)) // MistyRose
                return new Terrain { Type = "AutumnField", Description = "A field in autumn colors" };
            else if (color == Color.FromArgb(250, 240, 230)) // Linen
                return new Terrain { Type = "Prairie", Description = "A prairie landscape" };
            else if (color == Color.FromArgb(255, 228, 196)) // Bisque
                return new Terrain { Type = "Clay", Description = "A clay surface" };
            else if (color == Color.FromArgb(255, 235, 205)) // BlanchedAlmond
                return new Terrain { Type = "BarrenLand", Description = "A barren land" };
            else if (color == Color.FromArgb(255, 239, 213)) // PapayaWhip
                return new Terrain { Type = "Tundra", Description = "A tundra region" };
            else if (color == Color.FromArgb(255, 245, 238)) // SeaShell
                return new Terrain { Type = "Coastline", Description = "A coastline area" };
            else if (color == Color.FromArgb(240, 255, 255)) // Azure
                return new Terrain { Type = "FrozenLake", Description = "A frozen lake" };
            else if (color == Color.FromArgb(240, 255, 240)) // HoneyDew
                return new Terrain { Type = "Swamp", Description = "A swamp area" };
            else if (color == Color.FromArgb(255, 250, 240)) // FloralWhite
                return new Terrain { Type = "CoralReef", Description = "A coral reef" };
            else if (color == Color.FromArgb(250, 235, 215)) // AntiqueWhite
                return new Terrain { Type = "Ruins", Description = "An area of ancient ruins" };
            else if (color == Color.FromArgb(255, 239, 213)) // PapayaWhip
                return new Terrain { Type = "Wetland", Description = "A wetland area" };
            else if (color == Color.FromArgb(255, 248, 220)) // Cornsilk
                return new Terrain { Type = "Field", Description = "An open field" };
            else if (color == Color.FromArgb(255, 222, 173)) // NavajoWhite
                return new Terrain { Type = "Plateau", Description = "A high plateau" };
            else if (color == Color.FromArgb(255, 250, 250)) // FloralWhite
                return new Terrain { Type = "Iceberg", Description = "A large iceberg" };
            else if (color == Color.FromArgb(250, 240, 230)) // Linen
                return new Terrain { Type = "Desert", Description = "A hot desert" };
            else if (color == Color.FromArgb(255, 218, 185)) // PeachPuff
                return new Terrain { Type = "Savanna", Description = "A savanna region" };
            else if (color == Color.FromArgb(255, 240, 245)) // LavenderBlush
                return new Terrain { Type = "Canyon", Description = "A deep canyon" };
            else if (color == Color.FromArgb(240, 248, 255)) // AliceBlue
                return new Terrain { Type = "Cliff", Description = "A high cliff" };
            else if (color == Color.FromArgb(230, 230, 250)) // Lavender
                return new Terrain { Type = "Hill", Description = "A hilly area" };
            else if (color == Color.FromArgb(255, 255, 240)) // Ivory
                return new Terrain { Type = "Pasture", Description = "A lush pasture" };
            else if (color == Color.FromArgb(255, 228, 225)) // MistyRose
                return new Terrain { Type = "RiceField", Description = "A rice field" };
            else if (color == Color.FromArgb(255, 228, 196)) // Bisque
                return new Terrain { Type = "Meadow", Description = "A flower-filled meadow" };
            else if (color == Color.FromArgb(255, 222, 173)) // NavajoWhite
                return new Terrain { Type = "Grove", Description = "A grove of trees" };
            else if (color == Color.FromArgb(255, 218, 185)) // PeachPuff
                return new Terrain { Type = "Farmland", Description = "An agricultural field" };
            else if (color == Color.FromArgb(255, 228, 196)) // Bisque
                return new Terrain { Type = "Marshland", Description = "A marshy area" };
            else
                return new Terrain { Type = "Unknown", Description = "Unknown terrain" };
        }
    }




}
