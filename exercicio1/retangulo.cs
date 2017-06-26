using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1 {
    class retangulo {
        public double h;
        public double l;

        public double area() {
            return h * l;
        }

        public double perimetro() {
            return 2 * (h + l);
        }

        public double diagonal() {
            return Math.Sqrt((h * h) + (l * l));
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
