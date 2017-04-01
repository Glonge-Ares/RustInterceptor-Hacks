using System.Drawing;
using Box.Properties;

namespace Box {
    public class Waypoint {

        private string name;
        private int x;
        private int y;
        private int z;
        private Color color;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public string Name { get => name; set => name = value; }
        public Color Colur { get => color; set => color = value; }

        public Waypoint(int x, int y, int z, string name, Color color) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.name = name;
            this.color = color;
            Settings.Default.Waypoints.Add(x + "|" + y + "|" + z + "|" + name + "|" + color.ToArgb());
        }
    }
}
