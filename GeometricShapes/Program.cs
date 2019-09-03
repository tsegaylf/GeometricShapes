using GeometricShapesLibrary;
using System;

namespace GeometricShapes {
    class Program {

        void Run() {
            var quad1 = new Quadrilateral(2,3,4,5);
            Console.WriteLine($"quad1: perimeter is {quad1.Perimeter()}");

        }

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
