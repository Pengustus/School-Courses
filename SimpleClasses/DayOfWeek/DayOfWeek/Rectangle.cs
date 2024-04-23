using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    public class Rectangle
    {
        private int width;
        private int height;
        private string color;

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { if (value != string.Empty) { this.color = value; } else { this.color = "colorless"; } }
        }

        public Rectangle(int width, int height, string color)
        {
            this.Width = width;
            this.Height = height;
            this.color = color;
        }

        public int CalcArea()
        {
            return this.Width * this.Height;
        }
    }
}
