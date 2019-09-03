using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Parallelogram : Quadrilateral { //how to implement inharitance in c#

        public int Area() {
            return Side1 * Side2;
        }

        public Parallelogram(int side1, int side2) : base(side1, side2, side1, side2) {  //how to call the constructor in the base class
            
        }
    }
}
