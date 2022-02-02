using System;
using System.Collections.Generic;
using System.Text;

namespace QUESTAO3_P1
{
    class NumComplexo
    {
        //atributos
        private double Re;
        private double Im;

        //metodos
        public NumComplexo() { //construtor default
            Re = 0.0;
            Im = 0.0;
        }

        public NumComplexo(double _Re, double _Im) {
            Re = _Re;
            Im = _Im;
        }
        //gets
        public double getRe() {
            return Re;
        }
        public double getIm() {
            return Im;
        }
        //sets
        public void setRe(double _Re) {
            Re = _Re;
        }
        public void setIm(double _Im) {
            Im = _Im;
        }
        public NumComplexo soma(NumComplexo num2) {
            double soma_re;
            double soma_im;
            soma_re = getRe() + num2.getRe();
            soma_im = getIm() + num2.getIm();
            NumComplexo num3 = new NumComplexo(soma_re, soma_im);
            return num3;
        }
        public NumComplexo vezes(NumComplexo num2) {
            double mult_re;
            double mult_im;
            mult_re = (getRe() * num2.getRe())-(getIm()*num2.getIm());
            mult_im = (getRe() * num2.getIm()) + (getIm()*num2.getRe());
            NumComplexo num3 = new NumComplexo(mult_re, mult_im);
            return num3;
        }
        public double Modulo() {
            double modulo;
            modulo = Math.Sqrt((getRe() * getRe()) + (getIm() * getIm()));
            return modulo;
        }
        public double Argumento() {
            double tan = (getIm()/getRe());
            double angulo = Math.Atan(tan);
            return angulo;
        }
        public void imprimeFormaPolar() {
            double modulo;
            modulo = Math.Sqrt((getRe() * getRe()) + (getIm() * getIm()));
            double tan = (getIm() / getRe());
            double angulo = Math.Atan(tan);
            Console.WriteLine("A forma polar do numero complexo eh: " + modulo + "(cos " + angulo + " + i sin "+ angulo + ")");
        }

    }
}
