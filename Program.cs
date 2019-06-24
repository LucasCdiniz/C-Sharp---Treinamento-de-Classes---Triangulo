/*CLASSE
 Tipo Estrutturado
    Atributod (dados)
    Métodos (funções/operações)
Classes são entidades que contém atributos:
    Exemplo:
Cliente -> Entidade
    Telefone -> Atributo
    Endereço -> Atributo
    CPF -> Atributo
    E-mail -> Atributo
    Uma classe para cada Atributo 
    Adicionado classe ao Projeto:
        Solution Explorer
        Botão direito no Projeto
        ADD
        Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UdemyPrimeirosProjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variáveis utilizando a classe
            Triangulo x, y;
            //Instanciando
            x = new Triangulo();
            y = new Triangulo();

            // X.  Para poder acessar a variável da classe e guardar a informação
            Console.Write("Entre com as medidas do Triangulo X:\nXa\nXb\nXc\n\n");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Y.  Para poder acessar a variável da classe e guardar a informação
            Console.Write("\nEntre com as medidas do Triangulo Y:\nYa\nYb\nYc\n\n");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Conta em X
            double areaX = x.Area();
            //Conta em Y
            double areaY = y.Area();

            Console.WriteLine("A área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // validação de qual é a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é X");
            }
            else
            {
                Console.WriteLine("A maior área é Y");
            }

            Console.ReadKey();
        }
    }
}