using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            retangulo valor;

            valor = new retangulo();

            valor.l = double.Parse(Console.ReadLine());
            valor.h = double.Parse(Console.ReadLine());

            Console.WriteLine(valor);

            Console.ReadLine();
        }
    }
}
