using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class retangulo {
        public double heigth;
        public double width;

        public double area() {
            return heigth * width;
        }

        public double perimetro() {
            return 2 * (heigth + width);
        }

        public double diagonal() {
            return Math.Sqrt((heigth * heigth) + (width * width));
        }

        public override string ToString() {
            return "AREA = "
                + area()
                + Environment.NewLine
                + "PERIMETRO = "
                + perimetro()
                + Environment.NewLine
                + "DIAGONAL = "
                + diagonal();
        }
    }
}
