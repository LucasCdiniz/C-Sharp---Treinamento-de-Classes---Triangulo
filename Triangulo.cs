
using System;
    namespace UdemyPrimeirosProjetos
{
    class Triangulo
    {
        // nome de Atributo com o nome em maiúsculo
        // public - pode ser acessado por outros arquivos
        public double A;
        public double B;
        public double C;

        //Método
        //Tipo de Dado que o método irá Retornar -> Double
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        
    }
}