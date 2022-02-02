using System;

namespace QUESTAO3_P1
{
    class Program
    {
        static void Main(string[] args) {
            NumComplexo z1 = new NumComplexo(1, 1);
            NumComplexo z2 = new NumComplexo(3, -1);
            NumComplexo z3 = z1.soma(z2);
            NumComplexo z4 = z1.vezes(z2);
            z3.imprimeFormaPolar();
            z4.imprimeFormaPolar();
        }
    }
}
