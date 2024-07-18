using System;
using System.Drawing;
using System.Reflection;

namespace Base
{
    public class World
    {
        public Terrain[][]? TerrainMap { get; set; }
        public World() {
            // Usage example
            Bitmap bitmap = LoadBitmapFromResource("OSRIC.DotNetCore.Maps.Base.World.bmp");
            this.TerrainMap = TerrainInitializer.InitializeTerrainMap(bitmap);
        }
        private Bitmap LoadBitmapFromResource(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new ArgumentException($"Resource {resourceName} not found.");
                return new Bitmap(stream);
            }
        }
    }
}
