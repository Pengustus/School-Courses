using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class Rectangle
    {
        public int sideA { get; set; }

        public int sideB { get; set; }

        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        
        public Rectangle()
        {

        }
    }
}
