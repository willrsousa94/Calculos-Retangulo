using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            retangulo valor;

            valor = new retangulo();

            valor.width = double.Parse(Console.ReadLine());
            valor.height = double.Parse(Console.ReadLine());

            Console.WriteLine(valor);

            Console.ReadLine();
        }
    }
}
